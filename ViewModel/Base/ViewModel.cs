using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf2.ViewModel.Base
{
    internal class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged (string PropertyName)
        {
            PropertyChanged?.Invoke (this, new PropertyChangedEventArgs (PropertyName));
        }
    }
}
