using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTIDE_Web
{
    class webControl : WebBrowser
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modeSel"></param>
        /// <param name="data"></param>
        /// <param name="filename"></param>
        public void previewControl(int modeSel, string data, string filename)
        {
            switch (modeSel)
            {
                case 0://Live update
                    this.Document.OpenNew(true);
                    this.Document.Write(data);
                    break;
                case 1://Clear page
                    this.Navigate("about:blank");
                    break;
                case 2://Refresh
                    this.Refresh();
                    break;
                case 3://Load from file
                    this.Navigate(filename);
                    break;
                default:
                    throw new Exception("Invalid Function");
            }
        }
    }
}
