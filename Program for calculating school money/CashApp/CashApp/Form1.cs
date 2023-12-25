namespace CashApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeData form3 = new ChangeData();

            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BalanceForm form4 = new BalanceForm();

            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ÒranslatingMoneyForm translatingMoneyForm = new();
            translatingMoneyForm.Show();
        }
    }
}