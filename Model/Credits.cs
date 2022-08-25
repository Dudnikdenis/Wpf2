using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf2.Model
{
    internal class Credits : INotifyPropertyChanged
    {
        public Credits(int id, string name, DateTime startDate, DateTime endDate, int paymentDate, double paymentAmount)
        {
            this.Id = id;
            this.NameBank = name;
            this.DateFirstPayment = startDate;
            this.DateSecondPayment = endDate;
            this.NumberMonthlyPayment = paymentDate;
            this.AmountMonthlyPayment = paymentAmount;
        }

        public Credits()
        {

        }

        private int id;
        private string nameBank;
        private DateTime dateFirstPayment;
        private DateTime dateSecondPayment;
        private int numberMonthlyPayment;
        private double amountMonthlyPayment;

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

        public double AmountMonthlyPayment
        {
            get { return amountMonthlyPayment; }
            set
            {
                if (amountMonthlyPayment == value)
                    return;
                amountMonthlyPayment = value;
                OnPropertyChanged("amountMonthlyPayment");
            }
        }

        public int NumberMonthlyPayment
        {
            get { return numberMonthlyPayment; }
            set
            {
                if (numberMonthlyPayment == value)
                    return;
                numberMonthlyPayment = value;
                OnPropertyChanged("numberMonthlyPayment");
            }
        }

        public DateTime DateSecondPayment
        {
            get { return dateSecondPayment; }
            set
            {
                if (dateSecondPayment == value)
                    dateSecondPayment = value;
                OnPropertyChanged("dateSecondPayment");
            }
        }

        public DateTime DateFirstPayment
        {
            get { return dateFirstPayment; }
            set
            {

                if (dateFirstPayment == value)
                    return;
                dateFirstPayment = value;
                OnPropertyChanged("dateFirstPayment");
            }
        }
        public string NameBank
        {
            get { return nameBank; }
            set
            {
                if (nameBank == value)
                    return;
                nameBank = value;
                OnPropertyChanged("nameBank");
            }
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
