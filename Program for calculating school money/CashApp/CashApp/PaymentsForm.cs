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
    public partial class PaymentsForm : Form
    {
        CalculatorContext context;

        public List<Payment> Payments { get; set; }

        public PaymentsForm()
        {
            InitializeComponent();
            //Payments = GetPayments();
            context = new CalculatorContext();

            Payments = new List<Payment>();
        }

        //private List<Payment> GetPayments()
        //{
        //
        //    List<Payment> paymentNewList = new List<Payment>();
        //
        //    foreach (var item in context.Payments)
        //    {
        //        paymentNewList.Add(item);
        //    }
        //
        //
        //    var list = new List<Payment>();
        //
        //    foreach (var payment in paymentNewList)
        //    {
        //        list.Add(payment);
        //    }
        //
        //    return list;
        //}

        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            //var payments = this.Payments;
            //
            //dataGridView1.DataSource = payments;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            decimal price = decimal.Parse(textBox2.Text);

            if (price >= 0)
            {
                List<Balance> list = new List<Balance>();

                foreach (var balance in context.Balances)
                {
                    list.Add(balance);
                }

                var balanceLast = list[list.Count - 1];

                context.Balances.Add(new Balance()
                {
                    LastBalance = balanceLast.LastBalance - price
                });

                context.Payments.Add(new Payment()
                {
                    Name = name,
                    Price = price,
                });

                context.SaveChanges();

                MessageBox.Show($"Успешно платени {price:f2} лв.!");
            }
            else
            {
                MessageBox.Show($"Невалидна дата!\r\nЧислото не може да бъде отрицателно!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            PaymentsDataGridViewForm paymentsDataGridViewForm = new PaymentsDataGridViewForm();
            Form1 form1 = new();


            paymentsDataGridViewForm.Show();
            this.Hide();


        }
    }
}
