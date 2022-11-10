using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCart
{
    internal class Connection
    {
        public static SqlConnection conn;
        public static string dataSource = "Data Source=MOONGAZE;Initial Catalog=MiniCart;Integrated Security=True";
        public static void Connect()
        {
            try
            {
                conn = new SqlConnection(dataSource);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured in Connection.Connect()\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
    }
}
