using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace APU
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DirCheck();
        }
        private static void DirCheck()
        {
            if (!Directory.Exists(Properties.Settings.Default.GamePath))
            {
                string steampath = SteamPath();
                if (steampath != "")
                {
                    Properties.Settings.Default.GamePath = steampath.Replace("/", "\\") + @"\steamapps\common\Car Mechanic Simulator 2021";
                    Properties.Settings.Default.ShopPath = steampath.Replace("/", "\\") + @"\steamapps\workshop\content\1190000";
                    Properties.Settings.Default.Save();
                }
                /*FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Select Your Car Mechanic Simulator 2021 Installation Folder.";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.GamePath = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                    FolderBrowserDialog fbd1 = new FolderBrowserDialog();
                    fbd1.Description = "Select A Folder With Any Additional (Workshop) Cars, Or Cancel To Continue.";
                    if (fbd1.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.ShopPath = fbd1.SelectedPath;
                    }
                    Properties.Settings.Default.Save();
                    Application.Run(new FormMain());
                }
                else
                {
                    Application.Exit();
                }*/
                FolderBrowserDialog f = new FolderBrowserDialog();
                f.Description = "Select Your Car Mechanic Simulator 2021 Installation Folder.";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.GamePath = f.SelectedPath;
                }
                else
                    Environment.Exit(404);

                /*FolderBrowserDialog f1 = new FolderBrowserDialog();*/
                f.Description = "Select A Folder With Any Additional (Workshop) Cars, Or Cancel To Continue.";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.ShopPath = f.SelectedPath;
                }
                else
                    Environment.Exit(404);

                Properties.Settings.Default.Save();
                Application.Run(new AllowedPlacesUtilityCMS2021());
            }
            else
            {
                Application.Run(new AllowedPlacesUtilityCMS2021());
            }
        }
        private static string SteamPath()
        {
            object path = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Valve").OpenSubKey("Steam").GetValue("SteamPath");
            if (path != null)
                return path as string;
            else
                return "";
        }
    }
}
