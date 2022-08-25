using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf2.Model
{
    class Salary : INotifyPropertyChanged
    {
        private int id;
        private double firstSalary;
        private DateTime dateFirstSalary;        
        private double secondSalary;
        private DateTime dateSecondSalary;

        public int Id 
        { 
            get { return id; } 
            set 
            {
                if (id == value)
                    return;
                id = value;
                OnPropertyChanged("id");
            }
        }

        public double FirstSalary
        {
            get { return firstSalary; }
            set
            {
                if (firstSalary == value)
                    return;
                firstSalary = value;
                OnPropertyChanged("firstSalary");
            }
        }
        public DateTime DateFirstSalary
        {
            get { return dateFirstSalary; }

            set
            {
                if (dateFirstSalary == value)
                    return;
                dateFirstSalary = value;
                OnPropertyChanged("dateFirstSalary");
            }
        }
        public double SecondSalary 
        { 
            get { return secondSalary; }
            set
            {
                if (secondSalary == value)
                    return;
                secondSalary = value;
                OnPropertyChanged("secondSalary");
            }
        }
        public DateTime DateSecondSalary 
        {
            get { return dateSecondSalary; }
            set 
            {
                if (dateSecondSalary == value)
                    return;
                dateSecondSalary = value;
                OnPropertyChanged("dateSecondSalary");
            }
        }

        

        public Salary(int id, double firstSalary, DateTime dateFirstSalary, double secondSalary, DateTime dateSecondSalary)
        {
            this.Id = id;
            this.FirstSalary = firstSalary;
            this.DateFirstSalary = dateFirstSalary;
            this.SecondSalary = secondSalary;
            this.DateSecondSalary = dateSecondSalary;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));// аналогичная запись ниже
           
            /*if(PropertyChanged!=null) 
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }*/
            
        }


    }
}
