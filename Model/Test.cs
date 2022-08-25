using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf2.Model
{
    internal class Test : INotifyPropertyChanged
    {
        private int id;
        private int name;

        

        public int Id
        {
            get { return id; }
            set 
            {
                if (id == value)
                    return;
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public int Name
        {
            get { return name; }
            set 
            { 
                if(name == value) 
                    return;
                name = value;
                OnPropertyChanged("Name");

            }
        }

        public Test(int id, int name)
        {
            Id = id;
            Name = name;
            
        }

        public Test()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged (string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
