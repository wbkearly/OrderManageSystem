using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connection = "Server = localhost;  Database = OrderDB; Integrated Security = SSPI;";
            if(SqlManage.connectToDatabase(connection))
            {
                //WordOperator word = new WordOperator();
                //word.CreateWord();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm());
            }
            else
            {
                MessageBox.Show("数据库连接失败!");
            }  
        }
    }
}
