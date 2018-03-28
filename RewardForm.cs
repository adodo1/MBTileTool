using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing.QrCode.Internal;

namespace MBTileTool
{
    public partial class RewardForm : Form
    {
        public RewardForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Bitmap wx = MakeQRCode("wxp://f2f0_54rn3AJaTtepbaTzGdWgvBHiPofTsxX");
            Bitmap zfb = MakeQRCode("https://qr.alipay.com/tsx04773tjbyukgfrnmkl72");
            pictureBoxWX.Image = wx;
            pictureBoxZFB.Image = zfb;
        }

        /// <summary>
        /// 生成二维码图片
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private Bitmap MakeQRCode(string text)
        {
            int width = 400;
            QRCode code = ZXing.QrCode.Internal.Encoder.encode(text, ErrorCorrectionLevel.H);
            ByteMatrix m = code.Matrix;
            int blockSize = Math.Max(width / (m.Width + 2), 1);
            Bitmap drawArea = new Bitmap(((m.Width + 2) * blockSize), ((m.Height + 2) * blockSize));
            using (Graphics g = Graphics.FromImage(drawArea)) {
                g.Clear(Color.White);
                using (Brush b = new SolidBrush(Color.Black)) {
                    for (int row = 0; row < m.Width; row++) {
                        for (int col = 0; col < m.Height; col++) {
                            if (m[row, col] != 0) {
                                g.FillRectangle(b, blockSize * (row + 1), blockSize * (col + 1),
                                    blockSize, blockSize);
                            }
                        }
                    }
                }
            }
            return drawArea;
        }
    }
}
