using System.Windows;
using System.Windows.Controls;
using Npgsql;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using Wpf2.Data;
using Wpf2.Model;
using Wpf2.ViewModel;

namespace Wpf2.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ConectPostgres con = new ConectPostgres();
        AppConect db = new AppConect();
        BindingList<Salary> salaries = new BindingList<Salary>();
        //BindingList<Credits> crediits = new BindingList<Credits>();
        

        public MainWindow()
        {
            this.InitializeComponent();
            //DataContext = new MyWindowViewModel();
            
        }
        
        private void ButtonClic(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Привет!");
        }

        private void Button_newTab_Clic(object sender, RoutedEventArgs e)
        {
            
            MyTabControl.Items.Add(new TabItem { Header = "Прочие расходы" });
            MessageBox.Show("Вкладка добавлена!");
        }

        private void TabItem_Initialized_Salary(object sender, System.EventArgs e)
        {
            /*salaries = con.Answer("SELECT * FROM public.\"Income\"");
            DataGridSalary.ItemsSource = salaries;
            salaries.ListChanged += Salaries_ListChanged;*/
        }

        private void Salaries_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                /*if (con.UpdateSlary(salaries[e.NewIndex]) == 1)
                    MessageBox.Show("Ура получилось!");*/
            }      
        }

        private void TabItem_Initialized_Credit(object sender, System.EventArgs e)
        {
           /* crediits = con.AnswerCredit("SELECT * FROM public.\"Credits\";");
            DataGridCredit.ItemsSource = crediits;
            crediits.ListChanged += Crediits_ListChanged;*/
        }

        private void Crediits_ListChanged(object sender, ListChangedEventArgs e)
        {
            /*if(e.ListChangedType == ListChangedType.ItemChanged)
            {
                if(e.ListChangedType == ListChangedType.ItemChanged)
                {
                    if (con.UpdateCredits(crediits[e.NewIndex]) == 1)
                        MessageBox.Show("Ура получилось!");
                }
            }*/
        }

        private void DataGridIncome_Initialized(object sender, System.EventArgs e)
        {
             
            
            
        }
        
    }
}
