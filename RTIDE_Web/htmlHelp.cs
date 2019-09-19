using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RTIDE_Web
{
    /// <summary>
    /// Start of htmlHelp
    /// </summary>
    public partial class htmlHelp : Form
    {
        /// <summary>
        /// html based help class
        /// </summary>
        /// <param name="modeSel"></param>
        public htmlHelp(int modeSel)
        {
            InitializeComponent();
            switch (modeSel)
            {
                case 0://quick start
                    htmlView.DocumentText = htmlResource.quickStart;
                    break;
                case 1://open help
                    try
                    {
                        Process.Start("chrome.exe", Application.StartupPath + @"\manual.pdf");
                    }
                    catch
                    {
                        Process.Start(Application.StartupPath + @"\manual.pdf");
                    }
                    break;
                default:
                    throw new Exception("Invalid mode");
            }
        }
    }
}
