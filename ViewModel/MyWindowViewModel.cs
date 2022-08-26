using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Wpf2.Command;
using Wpf2.Data;
using Wpf2.Model;
using Wpf2.ViewModel.Base;

namespace Wpf2.ViewModel
{
    class MyWindowViewModel : ViewModelBase
    {
        #region Текст для вкладки
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
        #endregion

        #region ClouseAppCommand
        public ICommand ClouseAppCommand { get; }

        private bool CanClouseAppCommandExecut(object p) => true;

        private void OnClouseAppCommandExecuted (object p )
        {
            Application.Current.Shutdown();
        }
        #endregion

        public MyWindowViewModel()
        {
            #region Команды
            ClouseAppCommand = new LiambdaCommand(OnClouseAppCommandExecuted, CanClouseAppCommandExecut);
            #endregion
        }
    }
}
