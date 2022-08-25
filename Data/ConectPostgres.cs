using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf2.Data
{
    internal class ConectPostgres
    {
        //private string conString = "Host=localhost;Username=postgres;Database=FamilyBudget";
        NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=1111;Database=FamilyBudget");

        public ConectPostgres()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ошибка подключения! {0}", ex.Message.ToString()));
            }
        }

       /* public BindingList<Salary> Answer(string request)
        {
            BindingList<Salary> result = new BindingList<Salary>();
            #region TODO обработка исключений
            NpgsqlCommand command = new NpgsqlCommand(request, con);
            //int rows_changed = command.ExecuteNonQuery(); //Если не возвращает таблицу
            NpgsqlDataReader reader = command.ExecuteReader();

            #endregion
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Salary salary = new Salary(
                        reader.GetInt32(0),
                        reader.GetDouble(1),
                        reader.GetDateTime(2),
                        reader.GetDouble(3),
                        reader.GetDateTime(4));

                    result.Add(salary);
                }
            }
            reader.Close();
            return result;
        }

        /*public BindingList<Credits> AnswerCredit (string request)
        {
            BindingList<Credits> credits = new BindingList<Credits>();

            NpgsqlCommand command = new NpgsqlCommand(request, con);
            NpgsqlDataReader reader = command.ExecuteReader();

            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    Credits credit = new Credits(
                        reader.GetString(0),
                        reader.GetDateTime(1),
                        reader.GetDateTime(2),
                        reader.GetInt32(3),
                        reader.GetDouble(4));
                    credits.Add(credit);
                }
            }
            reader.Close();
            return credits;
        }*/


        /*public int UpdateSlary(Salary salary)
        {
            string request = string.Format("UPDATE public.\"Income\" SET \"Id\" ={0}, prepaid_expense ={1}, \"date_P_E\" ='{2:yyyy/MM/dd}', salary ={3}, date_salary ='{4:yyyy/MM/dd}' WHERE \"Id\" = {5} ",
                salary.Id, salary.FirstSalary, salary.DateFirstSalary, salary.SecondSalary, salary.DateSecondSalary, salary.Id);
            NpgsqlCommand command = new NpgsqlCommand(request, con);
            return command.ExecuteNonQuery();
        }

        /*public int UpdateCredits(Credits credit)
        {
            string request = string.Format("UPDATE public.\"Credits\" SET name ='{0}', \"Start_date\" ='{1:yyyy/MM/dd}', \"End_date\" ='{2:yyyy/MM/dd}', \"Payment_date\" ={3}, \"Payment_amount\" ={4} WHERE name = '{5}'; ",
                credit.Name,credit.StartDate, credit.EndDate,credit.PaymentDate,credit.PaymentAmount,credit.Name);
            NpgsqlCommand command = new NpgsqlCommand(request, con);
            return command.ExecuteNonQuery();
        }*/
    }
}

