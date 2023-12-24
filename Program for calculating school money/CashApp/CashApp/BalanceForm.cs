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

namespace CashApp
{
    public partial class BalanceForm : Form
    {
        private static decimal balance;

        CalculatorContext context;

        public BalanceForm()
        {
            InitializeComponent();

            context = new CalculatorContext();

            balance = context.Calculators.Sum(x => x.СумаЗаМесеца);

            label2.Visible = false;
            progressBar1.Visible = false;


        }

        private void BalanceForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                label2.Visible = true;
                progressBar1.Visible = true;

                label1.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;

                label2.Text = $"Баланс - {balance:f2}";
            }
            else
            {
                MessageBox.Show($"Грешен ПИН!");
            }

        }
    }
}
