using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RTIDE_Web
{
    static class Program
    {
        static string path = Application.StartupPath + @"\manual.pdf";
        static string codePath = Application.StartupPath + @"\codeList.ini";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(File.Exists(path) == false)
            {
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter binaryWriter = new BinaryWriter(fileStream);
                binaryWriter.Write(htmlResource.manual);
            }
            if (File.Exists(codePath) == false)
            {
                File.CreateText(codePath);
            }
            Application.Run(new startForm());
        }
    }
}
