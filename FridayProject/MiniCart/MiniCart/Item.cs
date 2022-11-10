using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCart
{
    internal class Item
    {
        private int id;
        private string itemName;
        private int quantity;
        private decimal price;
        private Image image;        

        public Item(int id, string itemName, int quantity, decimal price, Image image)
        {
            this.id = id;
            this.itemName = itemName;
            this.quantity = quantity;
            this.price = price;
            this.image = image;
        }

        public (int id, string itemName, int quantity, decimal price, Image image) getData()
        {
            return (id, itemName, quantity, price, image);
        }

        public int getID()
        {
            return id;
        }
    }
}
