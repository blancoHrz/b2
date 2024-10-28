using System;
using System.Windows.Forms;

namespace ISNP201823_UNIDAD_2
{
    static class Program
    {
      
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PELICULAS());
        }
    }
}
