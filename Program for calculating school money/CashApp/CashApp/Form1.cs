namespace CashApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
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

        private void button5_Click(object sender, EventArgs e)
        {
            PaymentsForm payments = new PaymentsForm();

            payments.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "1234")
            {
                label1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;

                label2.Visible = false;
                textBox2.Visible = false;
                button6.Visible = false;
            }
            else
            {
                MessageBox.Show($"Ãðåøåí ÏÈÍ!");
            }
        }
    }
}