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
    public partial class ТranslatingMoneyForm : Form
    {

        CalculatorContext context;
        public ТranslatingMoneyForm()
        {
            InitializeComponent();

            context = new CalculatorContext();

            label2.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
        }

        private void ТranslatingMoneyForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                label2.Visible = true;
                textBox2.Visible = true;
                button2.Visible = true;

                label1.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
            }
            else
            {
                MessageBox.Show($"Грешен ПИН!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(textBox2.Text) >= 0)
            {
                List<Balance> list = new List<Balance>();

                foreach (var balance in context.Balances)
                {
                    list.Add(balance);
                }

                var balanceLast = list[list.Count - 1];

                context.Balances.Add(new Balance()
                {
                    LastBalance = balanceLast.LastBalance + decimal.Parse(textBox2.Text)
                });

                context.SaveChanges();

                MessageBox.Show($"Успешно преведени {textBox2.Text} в картата!");
            }
            else
            {
                MessageBox.Show($"Невалидна стойност!\r\nЧислото не може да бъде отрицателно!");
            }
            
        }
    }
}
