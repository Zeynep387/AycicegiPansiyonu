using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayçiçeği_Pansiyon_Uygulaması_v1._0
{
    static class Program
    {
        /// <summary>
        /// Ayçiçeği Pansiyon Uygulaması v1.0
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmAdminGiris());
        }
    }
}
