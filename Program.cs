using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MBTileTool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            if (args.Name.StartsWith("System.Data.SQLite", StringComparison.OrdinalIgnoreCase))
            {
                string rootDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData) + Path.DirectorySeparatorChar + "GMap.NET" + Path.DirectorySeparatorChar;
                string dllDir = rootDir + "DllCache" + Path.DirectorySeparatorChar;
                string dll = dllDir + "SQLite_v84_NET" + Environment.Version.Major + "_" + (IntPtr.Size == 8 ? "x64" : "x86") + Path.DirectorySeparatorChar + "System.Data.SQLite.DLL";
                if (!File.Exists(dll))
                {
                    string dir = Path.GetDirectoryName(dll);
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }

                    Debug.WriteLine("Saving to DllCache: " + dll);

                    if (Environment.Version.Major == 2)
                    {
                        using (MemoryStream gzipDll = new MemoryStream((IntPtr.Size == 8 ? Properties.Resources.System_Data_SQLite_x64_NET2_dll : Properties.Resources.System_Data_SQLite_x86_NET2_dll)))
                        {
                            using (var gs = new System.IO.Compression.GZipStream(gzipDll, System.IO.Compression.CompressionMode.Decompress))
                            {
                                using (MemoryStream exctDll = new MemoryStream())
                                {
                                    byte[] tmp = new byte[1024 * 256];
                                    int r = 0;
                                    while ((r = gs.Read(tmp, 0, tmp.Length)) > 0)
                                    {
                                        exctDll.Write(tmp, 0, r);
                                    }
                                    File.WriteAllBytes(dll, exctDll.ToArray());
                                }
                            }
                        }
                    }
                    else if (Environment.Version.Major == 4)
                    {
                        using (MemoryStream gzipDll = new MemoryStream((IntPtr.Size == 8 ? Properties.Resources.System_Data_SQLite_x64_NET4_dll : Properties.Resources.System_Data_SQLite_x86_NET4_dll)))
                        {
                            using (var gs = new System.IO.Compression.GZipStream(gzipDll, System.IO.Compression.CompressionMode.Decompress))
                            {
                                using (MemoryStream exctDll = new MemoryStream())
                                {
                                    byte[] tmp = new byte[1024 * 256];
                                    int r = 0;
                                    while ((r = gs.Read(tmp, 0, tmp.Length)) > 0)
                                    {
                                        exctDll.Write(tmp, 0, r);
                                    }
                                    File.WriteAllBytes(dll, exctDll.ToArray());
                                }
                            }
                        }
                    }
                }

                Debug.WriteLine("Assembly.LoadFile: " + dll);

                return System.Reflection.Assembly.LoadFile(dll);
            }
            return null;
        }

    }
}
