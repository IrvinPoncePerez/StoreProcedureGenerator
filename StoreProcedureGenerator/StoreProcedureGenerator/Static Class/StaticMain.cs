using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreProcedureGenerator.Static_Class
{
    static class StaticMain
    {

        #region "Properties"

            static public string ServerName { get; set; }
            static public int AuthenticationMode { get; set; }
            static public string UserName { get; set; }
            static public string Password { get; set; }
            static public string ConnectionString { get; set; }

        #endregion

        #region

            [STAThread]
            public static void goMain()
            {
                if (AuthenticationMode == 0)
                {
                    ConnectionString = string.Format("Data Source={0};Integrated Security=True", ServerName);
                }
                else if (AuthenticationMode == 1)
                {
                    ConnectionString = string.Format("Data Source={0};User ID={1};Password={2};", ServerName, UserName, Password);
                }
            }

        #endregion 

    }
}
