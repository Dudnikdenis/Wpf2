using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf2.Model
{
    internal class HomeWarehouse
    {
        private int id;
        private double weight;
        private int idProduct;
        private double price;

        public int Id 
        {
            get { return id;}
            set 
            {
                id = value;
            }
        }
        public double Weight 
        {
            get {return weight;}
            set
            { weight = value; }
        }

        public int IdProduct 
        {
            get { return idProduct; }
            set { idProduct = value; }
        }

        public double Price 
        {
            get { return price; }
            set { price = value; }
        }

        public HomeWarehouse (int id, double weight, int idProduct, double price)
        {
            Id = id;
            Weight = weight;
            IdProduct = idProduct;
            Price = price;
        }

        public HomeWarehouse()
        {

        }
    }
}
