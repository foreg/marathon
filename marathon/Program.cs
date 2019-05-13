using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    static class Program
    {
        public static PanelsManageer PanelsManageer { get; set; } = new PanelsManageer();
        public static ApplicationContext db = new ApplicationContext();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
