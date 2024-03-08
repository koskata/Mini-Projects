using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "2020";
            }
            else if (textBox3.Text.Length > 4)
            {
                textBox3.Text = textBox3.Text.Substring(0, 3) + "2020";
            }
            else
            {
                textBox3.Text = "2020";
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "2021";
            }
            else if (textBox3.Text.Length > 4)
            {
                textBox3.Text = textBox3.Text.Substring(0, 3) + "2021";
            }
            else
            {
                textBox3.Text = "2021";
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void y2022_CheckedChanged(object sender, EventArgs e)
        {

            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "2022";
            }
            else if (textBox3.Text.Length > 4)
            {
                textBox3.Text = textBox3.Text.Substring(0, 3) + "2022";
            }
            else
            {
                textBox3.Text = "2022";
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void y2023_CheckedChanged(object sender, EventArgs e)
        {

            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "2023";
            }
            else if (textBox3.Text.Length > 4)
            {
                textBox3.Text = textBox3.Text.Substring(0, 3) + "2023";
            }
            else
            {
                textBox3.Text = "2023";
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void y2024_CheckedChanged(object sender, EventArgs e)
        {

            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "2024";
            }
            else if (textBox3.Text.Length > 4)
            {
                textBox3.Text = textBox3.Text.Substring(0, 3) + "2024";
            }
            else
            {
                textBox3.Text = "2024";
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void y2025_CheckedChanged(object sender, EventArgs e)
        {

            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "2025";
            }
            else if (textBox3.Text.Length > 4)
            {
                textBox3.Text = textBox3.Text.Substring(0, 3) + "2025";
            }
            else
            {
                textBox3.Text = "2025";
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void y2026_CheckedChanged(object sender, EventArgs e)
        {

            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "2026";
            }
            else if (textBox3.Text.Length > 4)
            {
                textBox3.Text = textBox3.Text.Substring(0, 3) + "2026";
            }
            else
            {
                textBox3.Text = "2026";
            }


            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void y2027_CheckedChanged(object sender, EventArgs e)
        {

            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "2027";
            }
            else if (textBox3.Text.Length > 4)
            {
                textBox3.Text = textBox3.Text.Substring(0, 3) + "2027";
            }
            else
            {
                textBox3.Text = "2027";
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void y2028_CheckedChanged(object sender, EventArgs e)
        {

            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "2028";
            }
            else if (textBox3.Text.Length > 4)
            {
                textBox3.Text = textBox3.Text.Substring(0, 3) + "2028";
            }
            else
            {
                textBox3.Text = "2028";
            }


            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void jan_CheckedChanged(object sender, EventArgs e)
        {

            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "01.";
            }
            else
            {
                textBox3.Text = "01." + textBox3.Text.Substring(textBox3.TextLength - 4, 4);
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void feb_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "02.";
            }
            else
            {
                textBox3.Text = "02." + textBox3.Text.Substring(textBox3.TextLength - 4, 4);
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void mar_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "03.";
            }
            else
            {
                textBox3.Text = "03." + textBox3.Text.Substring(textBox3.TextLength - 4, 4);
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void apr_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "04.";
            }
            else
            {
                textBox3.Text = "04." + textBox3.Text.Substring(textBox3.TextLength - 4, 4);
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void may_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "05.";
            }
            else
            {
                textBox3.Text = "05." + textBox3.Text.Substring(textBox3.TextLength - 4, 4);
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void june_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "06.";
            }
            else
            {
                textBox3.Text = "06." + textBox3.Text.Substring(textBox3.TextLength - 4, 4);
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void july_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "07.";
            }
            else
            {
                textBox3.Text = "07." + textBox3.Text.Substring(textBox3.TextLength - 4, 4);
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void aug_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "08.";
            }
            else
            {
                textBox3.Text = "08." + textBox3.Text.Substring(textBox3.TextLength - 4, 4);
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void sep_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "09.";
            }
            else
            {
                textBox3.Text = "09." + textBox3.Text.Substring(textBox3.TextLength - 4, 4);
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void oct_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "10.";
            }
            else
            {
                textBox3.Text = "10." + textBox3.Text.Substring(textBox3.TextLength - 4, 4);
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void nov_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "11.";
            }
            else
            {
                textBox3.Text = "11." + textBox3.Text.Substring(textBox3.TextLength - 4, 4);
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void dec_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 4)
            {
                textBox3.Text += "12.";
            }
            else
            {
                textBox3.Text = "12." + textBox3.Text.Substring(textBox3.TextLength - 4, 4);
            }

            if (textBox3.Text.Length == 7 && textBox3.Text[2] == '.')
            {
                textBox4.Text = "Дата ОК!";
            }
            else
            {
                textBox4.Text = "Непълна дата!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime TestDateTime1 = DateTime.Now;
            string strDate = "D" + TestDateTime1.ToString("yyyy/MM/dd/hh/mm/ss");

            string newString = strDate.Replace(".", "");

            Form2 form = new Form2();

            string fileInfo = textBox5.Text + textBox3.Text + ";";

            if (fileInfo.Contains((Char)10))
            {
                MessageBox.Show("Contains");
            }

            using (StreamWriter sw = new StreamWriter(Form1.molSettings[1] + $"\\{textBox5.Text.Substring(0, 12)}.txt"))
            {
                sw.WriteLine(fileInfo);
            }

            Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
