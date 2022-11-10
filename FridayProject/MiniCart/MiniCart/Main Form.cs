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
    public partial class MainForm : Form
    {
        private string search = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Icon = new Icon((Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\Resources\\minicartLogo.ico").ToString());
            minicart48pt.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\Resources\\Mini Cart 48pt.png");
            mainLogo.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\Resources\\minicartImage.png");            
            cartBox.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\Resources\\cartImage.png");
            searchIcon.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\Resources\\searchImage.png");
            minicart48ptLeft.Image = minicart48pt.Image;

            UpdateForm.hasNewData += (s, args) => { reloadData(); };
            reloadData();          
        }

        private void reloadData()
        {            
            if (Functions.getItemCount() != 0)
            {
                itemPanel.Controls.Clear();
                dashboardPanel.Visible = false;
                cartPanel.Visible = true;

                var itemList = Functions.getMultipleData(search);
                ItemUserControl iuc;

                foreach (Item i in itemList)
                {
                    iuc = new ItemUserControl();
                    iuc.SetData(i);
                    itemPanel.Controls.Add(iuc);
                }
            }
            else
            {
                cartPanel.Visible = false;
                dashboardPanel.Visible = true;
            }
        }

        private void cartBox_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm(false);            
            updateForm.ShowDialog();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {            
            search = searchBox.Text.Trim();
            reloadData();         
        }
    }
}
