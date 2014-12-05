/**
 * About this : This is the Statis Main Class or Module Main by work with global attributes in the StoreProcedureGenerator Application.
 * Creation Date : 01-Dic-2014
 * Created By : Irvin Ponce
 * Last Update Date : 01-Dic-2014
 * Last Update By : Irvin Ponce 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace StoreProcedureGenerator.Static_Class
{
    /// <summary>
    /// 
    /// </summary>
    static class StaticMain
    {

        #region "Properties"

            static public string ServerName { get; set; }
            static public int AuthenticationMode { get; set; }
            static public string UserName { get; set; }
            static public string Password { get; set; }
            static public SqlConnectionStringBuilder ConnectionString { get; set; }
            static public SqlConnection Connection { get; set; }
            static public MDIMaster MDIMaster { get; set; }

        #endregion

        #region

            [STAThread]
            public static void goMain()
            {
                ConnectionString = new SqlConnectionStringBuilder();

                if (AuthenticationMode == 0)
                {
                    ConnectionString.DataSource = ServerName;
                    ConnectionString.IntegratedSecurity = true;
                }
                else if (AuthenticationMode == 1)
                {
                    ConnectionString.DataSource = ServerName;
                    ConnectionString.UserID = UserName;
                    ConnectionString.Password = Password;
                }

                Connection = new SqlConnection(ConnectionString.ConnectionString);
            }

        #endregion 

    }
}
