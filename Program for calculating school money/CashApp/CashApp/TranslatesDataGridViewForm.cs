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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CashApp
{
    public partial class TranslatesDataGridViewForm : Form
    {
        public List<Translate> Translates { get; set; }

        CalculatorContext context;

        public TranslatesDataGridViewForm()
        {
            InitializeComponent();

            Translates = new List<Translate>();

            context = new CalculatorContext();
        }

        private void TranslatesDataGridViewForm_Load(object sender, EventArgs e)
        {
            foreach (var item in context.Translates)
            {
                Translates.Add(item);
            }

            var payments = this.Translates;

            dataGridView1.DataSource = payments;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ТranslatingMoneyForm translatingMoneyForm = new();
            translatingMoneyForm.Show();
            this.Hide();
        }
    }
}
