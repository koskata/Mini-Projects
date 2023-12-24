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
    public partial class Form2 : Form
    {

        int counter;

        private static decimal balance;

        CalculatorContext context;

        string[] months = new string[] { "Януари", "Февруари", "Март", "Април", "Май", "Юни", "Юли", "Август", "Септември", "Октомври", "Ноември", "Декември" };
        public Form2()
        {
            InitializeComponent();

            context = new CalculatorContext();

            balance = context.Calculators.Sum(x => x.СумаЗаМесеца);

            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;

            textBox1.AcceptsReturn = true;
            counter = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string month = textBox1.Text;
            if (String.IsNullOrWhiteSpace(month) || !months.Contains(month))
            {
                MessageBox.Show("Невалиден месец!\r\nОпитай пак");
            }

            else
            {
                label2.Visible = true;
                textBox2.Visible = true;
                label3.Visible = true;
                textBox3.Visible = true;

                label2.Text = $"Въведете стипендия за месец - {textBox1.Text}";
                label3.Text = $"Въведете транспортни за месец - {textBox1.Text}";

                textBox2.Focus();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(textBox1.Text[0].ToString());

            bool isSchoolarshipWrong = false;
            bool isTransWrong = false;

            string month = textBox1.Text;

            decimal scholarship = decimal.Parse(textBox2.Text);
            if (scholarship < 0)
            {
                MessageBox.Show("Невалидна стипендия!\r\nОпитай пак");
                isSchoolarshipWrong = true;
            }


            decimal transportMoney = decimal.Parse(textBox3.Text);
            if (transportMoney < 0)
            {
                MessageBox.Show("Невалидни транспортни!\r\nОпитай пак");
                isTransWrong = true;
            }

            //---------

            if (isSchoolarshipWrong == false && isTransWrong == false)
            {
                MessageBox.Show(AddingRecord(context, month, scholarship, transportMoney));
            }


        }















        private static string AddingRecord(CalculatorContext context, string month, decimal scholarship, decimal transportMoney)
        {

            balance += scholarship + transportMoney;


            var calculatorToAdd = new Calculator()
            {
                Месец = month,
                Стипендия = scholarship,
                Транспортни = transportMoney,
                СумаЗаМесеца = scholarship + transportMoney,
            };


            context.Calculators.Add(calculatorToAdd);
            context.SaveChanges();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Успешно прибавяне!");
            sb.AppendLine($"Сума (Стипендия + Транспортни) за месец {month} - {scholarship + transportMoney}");

            if (month == "Септемрви")
            {
                sb.AppendLine($"Пари, които да приведе Бащицата за месец {month} - {50 - transportMoney}");
            }
            else
            {
                sb.AppendLine($"Пари, които да приведе Бащицата за месец {month} - {100 - transportMoney}");
            }

            return sb.ToString().TrimEnd();
        }

    }
}
