using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf2.Data;
using Wpf2.Model;
using Wpf2.ViewModel.Base;

namespace Wpf2.ViewModel
{
    class MyWindowViewModel : ViewModelBase
    {        
        private string hello = "Расходы ура";

        public string Hello
        {
            get { return hello; }
            set 
            {
                if(hello == value)
                    return;
                hello = value;
                OnPropertyChanged("Hello");
            }
        }        
    }
}
