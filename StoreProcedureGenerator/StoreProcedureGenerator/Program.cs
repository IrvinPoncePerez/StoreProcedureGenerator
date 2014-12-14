using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace StoreProcedureGenerator
{
    static class Program
    {

        private static Mutex objMutex;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool isRun;
            objMutex = new Mutex(true, "StoredProcedureGenerator", out isRun);

            if (isRun)
            {
                Application.Run(new MDIMaster());
            }
            
        }
    }
}
