using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf2.Model
{
    class Dish
    {
        private int id;
        private int nameDish;

        public int Id 
        {
            get { return id; }
            set { id = value; }
        }

        public int NameDish
        {
            get { return nameDish; }
            set { nameDish = value; }
        }

        public Dish (int id, int nameDish)
        {
            Id = id;
            NameDish = nameDish;
        }

        public Dish()
        {

        }
    }
}
