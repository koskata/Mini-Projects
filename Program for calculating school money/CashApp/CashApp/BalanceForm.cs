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
    public partial class BalanceForm : Form
    {
        //private static decimal balance;

        CalculatorContext context;

        public BalanceForm()
        {
            InitializeComponent();

            context = new CalculatorContext();

            //balance = context.Calculators.Sum(x => x.СумаЗаМесеца);

            List<Balance> list = new List<Balance>();

            foreach (var balance in context.Balances)
            {
                list.Add(balance);
            }

            var balanceLast = list[list.Count - 1];

            label2.Text = $"Баланс - {balanceLast.LastBalance:f2}";
        }

        private void BalanceForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }
    }
}
