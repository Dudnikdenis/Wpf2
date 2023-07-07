using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
        private string hello = "Расходы ура";
        private BindingList<Test> tests =new BindingList<Test>() { new Test(12,12), new Test(15,15)};

        #region Postgres
        //ConectPostgres con = new ConectPostgres();
        //BindingList<Salary> salaries = new BindingList<Salary>();
        //BindingList<Credits> crediits = new BindingList<Credits>();
        #endregion

        #region SQLite
        //AppConect db = new AppConect();
        
        #endregion

        #region привязка текста
        

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

        public BindingList<Test> Tests
        {
            get { return tests; }
            set 
            {
                if(tests == value)
                    return ;
                tests = value;
                OnClouseAppCommandExecuted("Test");
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
            //Tests = db.Tests.ToList(); 

            #region Команды
            ClouseAppCommand = new LiambdaCommand(OnClouseAppCommandExecuted, CanClouseAppCommandExecut);
            #endregion
        }
    }
}
