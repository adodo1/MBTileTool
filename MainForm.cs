using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MBTileTool
{
    public partial class MainForm : Form
    {
        private string _outroot = "";

        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 打赏
        /// </summary>
        private void toolStripStatusLabelReward_Click(object sender, EventArgs e)
        {
            RewardForm form = new RewardForm();
            form.ShowDialog(this);
        }
        
        /// <summary>
        /// 添加目录
        /// </summary>
        private void toolStripButtonMore_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog(this) != DialogResult.OK) return;
            string path = dlg.DirectoryPath;

            string[] files = System.IO.Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            
            listBoxFiles.BeginUpdate();
            foreach (var file in files) {
                double[] rowcolzoom = GetColRowZoom(file);
                if (rowcolzoom == null || rowcolzoom.Length != 3) continue;
                listBoxFiles.Items.Add(file);
            }
            listBoxFiles.EndUpdate();
            if (listBoxFiles.Items.Count == 0) toolStripStatusLabelStatus.Text = "就绪";
            else toolStripStatusLabelStatus.Text = string.Format("共 {0} 个文件", listBoxFiles.Items.Count);
        }
        /// <summary>
        /// 添加文件
        /// </summary>
        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "矢量瓦片文件|*.*";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() != DialogResult.OK) return;
            listBoxFiles.BeginUpdate();
            foreach (string file in dialog.FileNames) {
                double[] colrowzoom = GetColRowZoom(file);
                if (colrowzoom == null || colrowzoom.Length != 3) continue;
                listBoxFiles.Items.Add(file);
            }
            listBoxFiles.EndUpdate();
            if (listBoxFiles.Items.Count == 0) toolStripStatusLabelStatus.Text = "就绪";
            else toolStripStatusLabelStatus.Text = string.Format("共 {0} 个文件", listBoxFiles.Items.Count);
        }
        /// <summary>
        /// 删除选中
        /// </summary>
        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItems.Count == 0) return;
            for (int i = listBoxFiles.SelectedItems.Count - 1; i >= 0; i--) {
                listBoxFiles.Items.Remove(listBoxFiles.SelectedItems[i]);
            }
            if (listBoxFiles.Items.Count == 0) toolStripStatusLabelStatus.Text = "就绪";
            else toolStripStatusLabelStatus.Text = string.Format("共 {0} 个文件", listBoxFiles.Items.Count);
        }
        /// <summary>
        /// 清空列表
        /// </summary>
        private void toolStripButtonClearn_Click(object sender, EventArgs e)
        {
            listBoxFiles.Items.Clear();
            toolStripStatusLabelStatus.Text = "就绪";
        }
        /// <summary>
        /// 打包瓦片
        /// </summary>
        private void toolStripButtonPack_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "瓦片集合|*.mbtile|所有文件|*.*";
            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            // 
            string mbtiles = dialog.FileName;
            SQLiteHelper.SetConnectionString = string.Format("Data Source=\"{0}\"", mbtiles);
            InitDB();

            // 必须使用事务 否则太慢了
            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source=\"{0}\"", mbtiles));
            connection.Open();
            SQLiteTransaction transaction = connection.BeginTransaction();


            //
            int num = 0;
            foreach (var item in listBoxFiles.Items) {
                if (num % 100 == 0) {
                    toolStripStatusLabelStatus.Text = string.Format("[{0}/{1}] {2:##}%", num, listBoxFiles.Items.Count, 100.0 * num / listBoxFiles.Items.Count);
                    Application.DoEvents();
                }
                num++;

                string filename = Convert.ToString(item);
                double[] colrowzoom = GetColRowZoom(filename);
                if (colrowzoom == null || colrowzoom.Length != 3) continue;

                // 插入数据库
                byte[] data = File.ReadAllBytes(filename);
                string sql = @"
                    replace into TILES(TILE_COLUMN, TILE_ROW, ZOOM_LEVEL, TILE_DATA)
                    values(@TILE_COLUMN, @TILE_ROW, @ZOOM_LEVEL, @TILE_DATA)";

                SQLiteParameter[] args = new SQLiteParameter[4];
                args[0] = new SQLiteParameter("@TILE_COLUMN", colrowzoom[0]);
                args[1] = new SQLiteParameter("@TILE_ROW", colrowzoom[1]);
                args[2] = new SQLiteParameter("@ZOOM_LEVEL", colrowzoom[2]);
                args[3] = new SQLiteParameter("@TILE_DATA", data);
                // 
                int result = SQLiteHelper.ExecuteNonQuery(transaction, CommandType.Text, sql, args);
            }
            transaction.Commit();
            connection.Close();

            toolStripStatusLabelStatus.Text = "就绪";
            MessageBox.Show("完成", "数据打包", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 设置输出路径
        /// </summary>
        private void toolStripButtonOutPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog(this) != DialogResult.OK) return;
            string outroot = dlg.DirectoryPath;
            _outroot = outroot;
        }
        /// <summary>
        /// 提取瓦片
        /// </summary>
        private void toolStripButtonExtract_Click(object sender, EventArgs e)
        {
            string extname = toolStripComboBoxExt.Text.Trim();
            extname.Replace(":", "");
            extname.Replace("\\", "");
            extname.Replace("/", "");
            extname.Replace("|", "");
            extname.Replace(">", "");
            extname.Replace("<", "");
            extname.Replace("*", "");
            extname.Replace(".", "");
            if (string.IsNullOrEmpty(extname)) {
                MessageBox.Show("请设置文件扩展!", "瓦片提取", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(_outroot) ||
                System.IO.Directory.Exists(_outroot) == false) {
                MessageBox.Show("请设置输出路径!", "瓦片提取", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                _outroot = dlg.DirectoryPath;
            }

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "瓦片集合|*.mbtile|所有文件|*.*";
            if (dialog.ShowDialog(this) != DialogResult.OK) return;
            string mbtiles = dialog.FileName;
            //
            ExtractTiles(_outroot, extname, mbtiles);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="outroot"></param>
        /// <param name="extname"></param>
        /// <param name="mbtiles"></param>
        private void ExtractTiles(string outroot, string extname, string mbtiles)
        {
            // 
            SQLiteHelper.SetConnectionString = string.Format("Data Source=\"{0}\"", mbtiles);
            //
            try {
                string sql = "";
                sql = "select count(*) from TILES";
                int sum = Convert.ToInt32(SQLiteHelper.ExecuteScalar(CommandType.Text, sql));
                sql = @"select TILE_COLUMN, TILE_ROW, ZOOM_LEVEL, TILE_DATA from TILES";
                SQLiteDataReader reader = SQLiteHelper.ExecuteReader(CommandType.Text, sql);
                int count = 0;
                for (; reader.Read(); ) {

                    if (count % 100 == 0) {
                        toolStripStatusLabelStatus.Text = string.Format("[{0}/{1}] {2:##}%", count, sum, 100.0 * count / sum);
                        Application.DoEvents();
                    }

                    count++;
                    int col = Convert.ToInt32(reader["TILE_COLUMN"]);
                    int row = Convert.ToInt32(reader["TILE_ROW"]);
                    int zoom = Convert.ToInt32(reader["ZOOM_LEVEL"]);
                    byte[] data = (byte[])reader["TILE_DATA"];

                    //
                    string savename = string.Format("{0}\\{1}\\{2}\\{3}.{4}", outroot, zoom, row, col, extname);
                    string savedir = Path.GetDirectoryName(savename);
                    if (Directory.Exists(savedir) == false) Directory.CreateDirectory(savedir);
                    File.WriteAllBytes(savename, data);
                }
                toolStripStatusLabelStatus.Text = "就绪";
                MessageBox.Show("完成", "数据提取", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "数据提取", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 解析文件行列号
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        private double[] GetColRowZoom(string filename)
        {
            string[] infos = System.IO.Path.GetFullPath(filename).Split('\\');
            ulong col, row, zoom;
            try {
                col = ulong.Parse(Path.GetFileNameWithoutExtension(infos[infos.Length - 1]));
                row = ulong.Parse(infos[infos.Length - 2]);
                zoom = ulong.Parse(infos[infos.Length - 3]);
                return new double[] { col, row, zoom };
            }
            catch (Exception ex) {
                // 如果目录不包含瓦片信息
                return new double[0];
            }
        }
        /// <summary>
        /// 初始化数据库
        /// </summary>
        private void InitDB()
        {
            string sql = "";
            sql = @"
            CREATE TABLE IF NOT EXISTS [HEADERS] (
              [NAME] VARCHAR2(50),   --header名称
              [VAL] VARCHAR2(200)    --header值
            );
            ";
            SQLiteHelper.ExecuteNonQuery(CommandType.Text, sql);
            sql = @"
            CREATE TABLE IF NOT EXISTS [TILES] (
              [ZOOM_LEVEL] INTEGER,  --瓦片等级
              [TILE_COLUMN] INTEGER, --瓦片列
              [TILE_ROW] INTEGER,    --瓦片行
              [TILE_DATA] BLOB       --瓦片数据
            );
            ";
            SQLiteHelper.ExecuteNonQuery(CommandType.Text, sql);
            sql = @"
            CREATE UNIQUE INDEX IF NOT EXISTS [INDEX_TILES_XYZ] ON [TILES] ([ZOOM_LEVEL], [TILE_COLUMN], [TILE_ROW]);
            ";
            SQLiteHelper.ExecuteNonQuery(CommandType.Text, sql);
        }
        /// <summary>
        /// 跳转到Github
        /// </summary>
        private void toolStripStatusLabelName_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/adodo1/MBTileTool");
        }


    }
}
