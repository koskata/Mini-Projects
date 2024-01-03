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
    public partial class PaymentsDataGridViewForm : Form
    {
        CalculatorContext context;

        public List<Payment> Payments { get; set; }
        public PaymentsDataGridViewForm()
        {
            InitializeComponent();

            context = new CalculatorContext();

            Payments = new List<Payment>();
        }

        private void PaymentsDataGridViewForm_Load(object sender, EventArgs e)
        {
            foreach (var item in context.Payments)
            {
                Payments.Add(item);
            }

            var payments = this.Payments;

            dataGridView1.DataSource = payments;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PaymentsForm paymentsForm = new PaymentsForm();


            paymentsForm.Show();

            this.Hide();
        }
    }
}
