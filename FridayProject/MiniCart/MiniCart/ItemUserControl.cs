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
    public partial class ItemUserControl : UserControl
    {
        private Item item;
        public ItemUserControl()
        {
            InitializeComponent();
        }

        private void ItemUserControl_Load(object sender, EventArgs e)
        {
            menuBox.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\Resources\\menuImage.png");

            try
            {
                var data = item.getData();
                idLabel.Text = "#" + data.id.ToString("D3");
                itemName.Text = data.itemName;
                quantity.Text = "Available Stock :  " + data.quantity;
                price.Text = "$" + data.price.ToString("N2");
                image.Image = data.image;
            }
            catch(Exception)
            {
                image.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\Resources\\defaultImage.png");
            }
        }

        public void SetData(Object item)
        {
            this.item = (Item) item;
        }

        private void menuBox_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm(true);
            updateForm.setData(item);
            updateForm.ShowDialog();
        }
    }
}
