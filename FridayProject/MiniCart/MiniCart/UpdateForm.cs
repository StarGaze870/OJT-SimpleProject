using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCart
{
    public partial class UpdateForm : Form
    {
        public static EventHandler hasNewData;
        private Item item;
        private int id;
        private bool isUpdate;
        public UpdateForm(bool isUpdate)
        {
            InitializeComponent();
            this.isUpdate = isUpdate;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            minicart24pt.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\Resources\\Mini Cart 48pt.png");
            deleteBox.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\Resources\\deleteImage.png");            

            if (!isUpdate)
            {
                image.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\Resources\\defaultImage.png");
                idLabel.Visible = false;
                deleteBox.Visible = false;
                update.Text = "SAVE";
            }
        }

        public void setData(Object item) 
        {         
            try
            {
                this.item = (Item) item;
                var data = this.item.getData();
                id = data.id;
                idLabel.Text = "#" + data.id.ToString("D3");
                itemName.Text = data.itemName.Trim();
                quantity.Text = data.quantity.ToString();
                price.Text = data.price.ToString("N2");
                image.Image = data.image;                
            }
            catch (Exception)
            {
                image.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\Resources\\defaultImage.png");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {            
            Dispose();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {                
                try
                {
                    if (itemName.TextLength == 0)                    
                    {
                        MessageBox.Show("Item Name is Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Functions.InsertData(itemName.Text.Trim(), Int32.Parse(quantity.Text), Decimal.Parse(price.Text), image.Image);                  
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }                    
            }            
            else
            {
                Item newItem = null;
                try
                {
                    newItem = new Item(id, itemName.Text.Trim(), Int32.Parse(quantity.Text), Decimal.Parse(price.Text), image.Image);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show($"Update {idLabel.Text} ?", "UPDATE", buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Functions.UpdateData(newItem);                                                            
                }
            }
            newItem();
            Dispose();            
        }

        public void newItem()
        {
            hasNewData?.Invoke(this, EventArgs.Empty);
        }

        private void deleteBox_Click(object sender, EventArgs e)
        {            
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show($"Delete {idLabel.Text} ?", "DELETE", buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Functions.DeleteData(id);                
                newItem();                
                Dispose();                
            }
        }

        private void editImage_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png;) | *.jpg; *.jpeg; *.png;";
            fileDialog.FileName = null;
            var result = fileDialog.ShowDialog();
            
            if (result == DialogResult.OK)
            {                                
                image.Image = Image.FromFile(fileDialog.FileName);
            }
            Cursor.Current = Cursors.Default;
        }        
    }
}
