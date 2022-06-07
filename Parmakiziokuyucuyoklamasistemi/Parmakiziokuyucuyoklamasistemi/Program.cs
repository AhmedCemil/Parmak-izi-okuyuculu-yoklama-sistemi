using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parmakiziokuyucuyoklamasistemi
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın acb girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_YoklamaSistemiGirisi());
        }
    }
}
