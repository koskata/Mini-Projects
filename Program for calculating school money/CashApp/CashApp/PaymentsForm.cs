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

        public PaymentsForm()
        {
            InitializeComponent();
            context = new CalculatorContext();

            label1.Visible = false;
            textBox1.Visible = false;

            label3.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
        }

        private void PaymentsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "1234")
            {
                label1.Visible = true;
                textBox1.Visible = true;

                label3.Visible = true;
                textBox2.Visible = true;
                button2.Visible = true;

                label2.Visible = false;
                textBox3.Visible = false;
                button1.Visible = false;


            }
            else
            {
                MessageBox.Show($"Грешен ПИН!");
            }
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
    }
}
