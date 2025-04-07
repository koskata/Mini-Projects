namespace ConverterAppWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Error! There is not entered number to convert!");
            }

            //Decimal to binary
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {

                long number = Convert.ToInt64(textBox1.Text);
                long binary = 0;
                long I = 0;

                while (number != 0)
                {
                    long d = (long)number % 2;
                    binary = binary + (long)d * (long)Math.Pow(10, I);
                    I = I + 1;
                    number = number / 2;
                }
                textBox2.Text = binary.ToString();

            }
            //Binary to decimal
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {


                long num, binary, decimal_val = 0, base_val = 1, rem;

                num = long.Parse(textBox1.Text);

                binary = num;
                while (num > 0)
                {
                    rem = num % 10;
                    decimal_val = decimal_val + rem * base_val;
                    num = num / 10;
                    base_val = base_val * 2;
                }
                textBox2.Text = decimal_val.ToString();
            }




            //Decimal to hex
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
            {
                long decimalNumber = Convert.ToInt64(textBox1.Text);
                string hexadecimalNumber = decimalNumber.ToString("X");
                textBox2.Text = hexadecimalNumber;
            }
            //Hex to Decimal
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
            {
                string hex_value = textBox1.Text;
                long int_value = Convert.ToInt64(hex_value, 16);
                textBox2.Text = int_value.ToString();

            }


            //Hex to Binary
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                string hexValue = textBox1.Text;
                string binaryValue = Convert.ToString(Convert.ToInt32(hexValue, 16), 2);
                textBox2.Text = binaryValue.ToString();
            }
            //Binary to Hex
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                string binaryNumber = textBox1.Text;
                long decimalNumber = Convert.ToInt64(binaryNumber, 2);
                string hexadecimalNumber = Convert.ToString(decimalNumber, 16).ToUpper();
                textBox2.Text = hexadecimalNumber;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = button1;
        }
    }
}
