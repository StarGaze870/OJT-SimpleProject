using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCart
{
    internal class Functions
    {
        public static SqlCommand command;
        public static SqlDataReader reader;

        public static void Query(String query)
        {
            try
            {
                Connection.Connect();
                command = new SqlCommand(query, Connection.conn);
                command.ExecuteNonQuery();
                Connection.conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured in Function.Query()\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void InsertData(string itemName, int quantity, decimal price, Image image)
        {
            try
            {
                Connection.Connect();
                command = new SqlCommand("INSERT INTO ItemData VALUES(@itemName, @quantity, @price, @image)", Connection.conn);
                command.Parameters.AddWithValue("@itemName", itemName);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@image", ConvertImageToBytes(image));
                command.ExecuteNonQuery();
                Connection.conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured in Function.InsertData()\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        public static void UpdateData(Item item)
        {
            var data = item.getData();

            try
            {
                Connection.Connect();
                command = new SqlCommand("UPDATE ItemData SET itemName = @itemName, quantity = @quantity, price = @price, image = @image WHERE id = @id;", Connection.conn);
                command.Parameters.AddWithValue("@id", data.id);
                command.Parameters.AddWithValue("@itemName", data.itemName.Trim());
                command.Parameters.AddWithValue("@quantity", data.quantity);
                command.Parameters.AddWithValue("@price", data.price);
                command.Parameters.AddWithValue("@image", ConvertImageToBytes(data.image));
                command.ExecuteNonQuery();
                Connection.conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured in Function.UpdateData()\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public static void DeleteData(int id)
        {
            Query($"DELETE FROM ItemData WHERE id = {id};");
        }

        public static List<Item> getMultipleData(string search)
        {
            List<Item> itemList = new List<Item>();

            DataTable dt = new DataTable();
            try
            {                
                Connection.Connect();                
                SqlCommand command = new SqlCommand($"SELECT * FROM ItemData WHERE itemName LIKE '{search}%' OR id LIKE '{search}%';", Connection.conn);
                SqlDataAdapter data = new SqlDataAdapter(command);
                data.Fill(dt);                
                Connection.conn.Close();

                int id = 0;
                string itemName = null;
                int quantity = 0;
                decimal price = 0;
                Image image = null;
                Item item = null;

                foreach (DataRow dr in dt.Rows)
                {
                    id = Int32.Parse(dr["id"].ToString());
                    itemName = dr["itemName"].ToString();
                    quantity = Int32.Parse(dr["quantity"].ToString());
                    price = Decimal.Parse(dr["price"].ToString());
                    image = ConvertByteArrayToImage((byte[])dr["image"]);
                    item = new Item(id, itemName, quantity, price, image);
                    itemList.Add(item);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured in Function.getMultipleData()\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return itemList;
        }      

        public static int getItemCount()
        {
            try
            {
                Connection.Connect();
                command = new SqlCommand($"SELECT COUNT(*) FROM ItemData;", Connection.conn);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int res = 0;
                    Int32.TryParse(reader.GetValue(0).ToString(), out res);
                    return res;
                }
                Connection.conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured in Functions.getItemCount()\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;
        }    

        public static Object ConvertImageToBytes(Image img)
        {            
            ImageConverter ic = new ImageConverter();
            var res = ic.ConvertTo(img, typeof(byte[]));

            return res;
        }

        public static Image ConvertByteArrayToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data, true);            
            return Image.FromStream(ms);            
        }       
        
        public static Image getSingleImage(string id)
        {            
            try
            {
                Connection.Connect();
                command = new SqlCommand($"SELECT image FROM ItemData WHERE id = '{id}';", Connection.conn);
                reader = command.ExecuteReader();
                if (reader.Read())
                {                    
                    return ConvertByteArrayToImage((byte[]) reader.GetValue(0));
                }
                Connection.conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured in Functions.getImage()\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
    }
}
