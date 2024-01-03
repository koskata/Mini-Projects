using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cadastre.Data;

using CashApp.Data.Models;

namespace CashApp
{
    public partial class ChangeData : Form
    {

        //private static decimal balance;

        CalculatorContext context;

        Calculator tableToFind;

        string[] months = new string[] { "Януари", "Февруари", "Март", "Април", "Май", "Юни", "Юли", "Август", "Септември", "Октомври", "Ноември", "Декември" };

        public ChangeData()
        {
            InitializeComponent();

            context = new CalculatorContext();

            //balance = context.Calculators.Sum(x => x.СумаЗаМесеца);

            label2.Visible = false;
            Schoolarship.Visible = false;
            Transport.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;


        }

        private void ChangeData_Load(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string month = textBox1.Text;
            if (String.IsNullOrWhiteSpace(month) || !months.Contains(month))
            {
                MessageBox.Show("Невалиден месец!\r\nОпитай пак");
            }

            tableToFind = context.Calculators.FirstOrDefault(x => x.Месец == month);

            if (tableToFind is null)
            {
                MessageBox.Show("Не е намерен такъв запис!\r\nОпитай пак");
            }
            else
            {
                label2.Visible = true;
                Schoolarship.Visible = true;
                Transport.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;


            }

        }

        private void Schoolarship_Click(object sender, EventArgs e)
        {


            decimal newSt = decimal.Parse(textBox2.Text);

            if (newSt < 0)
            {
                MessageBox.Show("Невалидна дата!\r\nЧислото не може да бъде отрицателно!");
            }

            tableToFind.Стипендия = newSt;

            decimal temp = 0.0m;

            if (newSt < tableToFind.Стипендия)
            {
                temp = tableToFind.СумаЗаМесеца - (newSt + tableToFind.Транспортни);
                //balance -= temp;
                tableToFind.СумаЗаМесеца -= temp;

                List<Balance> list = new List<Balance>();

                foreach (var balance in context.Balances)
                {
                    list.Add(balance);
                }

                var balanceLast = list[list.Count - 1];

                context.Balances.Add(new Balance()
                {
                    LastBalance = balanceLast.LastBalance - temp
                });
            }
            else
            {
                temp = (newSt + tableToFind.Транспортни) - tableToFind.СумаЗаМесеца;
                //balance += temp;
                tableToFind.СумаЗаМесеца += temp;

                List<Balance> list = new List<Balance>();

                foreach (var balance in context.Balances)
                {
                    list.Add(balance);
                }

                var balanceLast = list[list.Count - 1];

                context.Balances.Add(new Balance()
                {
                    LastBalance = balanceLast.LastBalance + temp
                });
            }

            context.SaveChanges();

            MessageBox.Show("Успешно променена стипендия!");
        }


        private void Transport_Click(object sender, EventArgs e)
        {
            decimal newTs = decimal.Parse(textBox3.Text);

            if (newTs < 0)
            {
                MessageBox.Show("Невалидна дата!\r\nЧислото не може да бъде отрицателно!");
            }

            tableToFind.Транспортни = newTs;

            decimal temp = 0.0m;

            if (newTs < tableToFind.Транспортни)
            {
                temp = tableToFind.СумаЗаМесеца - (newTs + tableToFind.Стипендия);
                //balance -= temp;
                tableToFind.СумаЗаМесеца -= temp;

                List<Balance> list = new List<Balance>();

                foreach (var balance in context.Balances)
                {
                    list.Add(balance);
                }

                var balanceLast = list[list.Count - 1];

                context.Balances.Add(new Balance()
                {
                    LastBalance = balanceLast.LastBalance - temp
                });
            }
            else
            {
                temp = (newTs + tableToFind.Стипендия) - tableToFind.СумаЗаМесеца;
                //balance += temp;
                tableToFind.СумаЗаМесеца += temp;

                List<Balance> list = new List<Balance>();

                foreach (var balance in context.Balances)
                {
                    list.Add(balance);
                }

                var balanceLast = list[list.Count - 1];

                context.Balances.Add(new Balance()
                {
                    LastBalance = balanceLast.LastBalance + temp
                });
            }

            context.SaveChanges();


            if (tableToFind.Месец == "Септемрви")
            {
                MessageBox.Show($"Успешно променени транспортни!\r\n" +
                    $"Пари, които да приведе Бащицата за месец {tableToFind.Месец} - {50 - tableToFind.Транспортни}");
            }
            else
            {
                MessageBox.Show($"Успешно променени транспортни!\r\n" +
                    $"Пари, които да приведе Бащицата за месец {tableToFind.Месец} - {100 - tableToFind.Транспортни}");
            }

            
        }
    }
}
