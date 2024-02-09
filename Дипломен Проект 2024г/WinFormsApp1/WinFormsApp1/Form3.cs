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
    public partial class Form3 : Form
    {

        public Dictionary<string, List<string>> serNumWithValues;

        public Dictionary<string, List<string>> numWithValues;

        string HIDstr;
        public Form3()
        {
            InitializeComponent();

            serNumWithValues = new Dictionary<string, List<string>>();
            numWithValues = new Dictionary<string, List<string>>();


            if (File.Exists("C:\\MOLSettings\\HTC\\out.txt"))
            {
                using (StreamReader sr = new StreamReader("C:\\MOLSettings\\HTC\\out.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lineArgs = line.Split(";");

                        string serialNumber = lineArgs[0];


                        serNumWithValues[serialNumber] = new List<string>();

                        for (int j = 1; j <= lineArgs.Length - 1; j++)
                        {
                            serNumWithValues[serialNumber].Add(lineArgs[j]);
                        }
                    }
                }
            }


            if (File.Exists("C:\\MOLSettings\\itemsnav.txt"))
            {
                using (StreamReader sr = new StreamReader("C:\\MOLSettings\\itemsnav.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lineArgs = line.Split(";");

                        string number = lineArgs[0];


                        numWithValues[number] = new List<string>();

                        for (int j = 1; j <= lineArgs.Length - 1; j++)
                        {
                            numWithValues[number].Add(lineArgs[j]);
                        }
                    }
                }
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 12)
            //if (textBox1.AcceptsReturn)
            {
                textBox2.Text = "Ok!";
                textBox2.Update();
                textBox1.Update();




                if (serNumWithValues.ContainsKey(textBox1.Text))
                {
                    komp0.Text = serNumWithValues[textBox1.Text][0];
                }
                else
                {
                    MessageBox.Show("Серийния номер не е открит! Актуализирайте и сканирайте отново!");
                }

                komp0.Update();
                if (komp0.Text == "-" || !numWithValues.ContainsKey(komp0.Text))
                {
                    komp00.Text = "-";
                    komp00.Update();

                    komp000.Text = "-";
                    komp000.Update();
                }
                else
                {
                    komp00.Text = numWithValues[komp0.Text][0];
                    komp00.Update();

                    komp000.Text = numWithValues[komp0.Text][1];
                    komp000.Update();
                }

                komp1.Text = serNumWithValues[textBox1.Text][3];
                komp1.Update();
                if (komp1.Text == "-" || !numWithValues.ContainsKey(komp1.Text))
                {
                    komp11.Text = "-";
                    komp11.Update();

                    komp111.Text = "-";
                    komp111.Update();
                }
                else
                {
                    komp11.Text = numWithValues[komp1.Text][0];
                    komp11.Update();

                    komp111.Text = numWithValues[komp1.Text][1];
                    komp111.Update();
                }

                komp2.Text = serNumWithValues[textBox1.Text][4];
                komp2.Update();
                if (komp2.Text == "-" || !numWithValues.ContainsKey(komp2.Text))
                {
                    komp22.Text = "-";
                    komp22.Update();

                    komp222.Text = "-";
                    komp222.Update();
                }
                else
                {
                    komp22.Text = numWithValues[komp2.Text][0];
                    komp22.Update();

                    komp222.Text = numWithValues[komp2.Text][1];
                    komp222.Update();
                }

                komp3.Text = serNumWithValues[textBox1.Text][5];
                komp3.Update();
                if (komp3.Text == "-" || !numWithValues.ContainsKey(komp3.Text))
                {
                    komp33.Text = "-";
                    komp33.Update();

                    komp333.Text = "-";
                    komp333.Update();
                }
                else
                {
                    komp33.Text = numWithValues[komp3.Text][0];
                    komp33.Update();

                    komp333.Text = numWithValues[komp3.Text][1];
                    komp333.Update();
                }

                komp4.Text = serNumWithValues[textBox1.Text][6];
                komp4.Update();
                if (komp4.Text == "-" || !numWithValues.ContainsKey(komp4.Text))
                {
                    komp44.Text = "-";
                    komp44.Update();

                    komp444.Text = "-";
                    komp444.Update();
                }
                else
                {
                    komp44.Text = numWithValues[komp4.Text][0];
                    komp44.Update();

                    komp444.Text = numWithValues[komp4.Text][1];
                    komp444.Update();
                }

                komp5.Text = serNumWithValues[textBox1.Text][12];
                komp5.Update();
                if (komp5.Text == "-" || !numWithValues.ContainsKey(komp5.Text))
                {
                    komp55.Text = "-";
                    komp55.Update();

                    komp555.Text = "-";
                    komp555.Update();
                }
                else
                {
                    komp55.Text = numWithValues[komp5.Text][0];
                    komp55.Update();

                    komp555.Text = numWithValues[komp5.Text][1];
                    komp555.Update();
                }

                komp6.Text = serNumWithValues[textBox1.Text][13];
                komp6.Update();
                if (komp6.Text == "-" || !numWithValues.ContainsKey(komp6.Text))
                {
                    komp66.Text = "-";
                    komp66.Update();

                    komp666.Text = "-";
                    komp666.Update();
                }
                else
                {
                    komp66.Text = numWithValues[komp6.Text][0];
                    komp66.Update();

                    komp666.Text = numWithValues[komp6.Text][1];
                    komp666.Update();
                }

                komp7.Text = serNumWithValues[textBox1.Text][14];
                komp7.Update();
                if (komp7.Text == "-" || !numWithValues.ContainsKey(komp7.Text))
                {
                    komp77.Text = "-";
                    komp77.Update();

                    komp777.Text = "-";
                    komp777.Update();
                }
                else
                {
                    komp77.Text = numWithValues[komp7.Text][0];
                    komp77.Update();

                    komp777.Text = numWithValues[komp7.Text][1];
                    komp777.Update();
                }

                komp8.Text = serNumWithValues[textBox1.Text][15];
                komp8.Update();
                if (komp8.Text == "-" || !numWithValues.ContainsKey(komp8.Text))
                {
                    komp88.Text = "-";
                    komp88.Update();

                    komp888.Text = "-";
                    komp888.Update();
                }
                else
                {
                    komp88.Text = numWithValues[komp8.Text][0];
                    komp88.Update();

                    komp888.Text = numWithValues[komp8.Text][1];
                    komp888.Update();
                }

                komp9.Text = serNumWithValues[textBox1.Text][16];
                komp9.Update();
                if (komp9.Text == "-" || !numWithValues.ContainsKey(komp9.Text))
                {
                    komp99.Text = "-";
                    komp99.Update();

                    komp999.Text = "-";
                    komp999.Update();
                }
                else
                {
                    komp99.Text = numWithValues[komp9.Text][0];
                    komp99.Update();

                    komp999.Text = numWithValues[komp9.Text][1];
                    komp999.Update();
                }
            }
            else
            {
                textBox2.Text = textBox1.Text;
                textBox2.Update();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(Form1.molSettings[8] + "\\out.txt"))
            {
                File.Delete("C:\\MOLSettings\\HTC\\out.txt");
                File.Copy(Form1.molSettings[8] + "\\out.txt", "C:\\MOLSettings\\HTC\\out.txt");

                if (File.Exists(Form1.molSettings[10] + "\\out.txt"))
                {
                    File.Delete(Form1.molSettings[10] + "\\out.txt");
                }


                File.Copy(Form1.molSettings[8] + "\\out.txt", Form1.molSettings[10] + "\\out.txt");
                File.Delete(Form1.molSettings[8] + "\\out.txt");
            }


            serNumWithValues.Clear();

            if (File.Exists("C:\\MOLSettings\\HTC\\out.txt"))
            {
                using (StreamReader sr = new StreamReader("C:\\MOLSettings\\HTC\\out.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lineArgs = line.Split(";");

                        string serialNumber = lineArgs[0];


                        serNumWithValues[serialNumber] = new List<string>();

                        for (int j = 1; j <= lineArgs.Length - 1; j++)
                        {
                            serNumWithValues[serialNumber].Add(lineArgs[j]);
                        }
                    }
                }
            }
        }

        private void komp0_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void komp999_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HIDstr = komp0.Text + "JR8" + textBox1.Text;

            int evenSum = 0;
            int oddSum = 0;
            int sum = 0;

            for (int i = 1; i <= 12; i++)
            {
                int even_I = i * 2;

                if (Char.IsLetter(HIDstr[even_I - 1]))
                {
                    evenSum += (Int32)HIDstr[even_I - 1] - 55;
                }
                else
                {
                    if (Char.IsDigit(HIDstr[even_I - 1]))
                    {
                        evenSum += (Int32)HIDstr[even_I - 1] - 48;
                    }
                }


                if (Char.IsLetter(HIDstr[even_I - 2]))
                {
                    oddSum += (Int32)HIDstr[even_I - 2] - 55;
                }
                else
                {
                    if (Char.IsDigit(HIDstr[even_I - 2]))
                    {
                        oddSum += (Int32)HIDstr[even_I - 2] - 48;
                    }
                }
            }

            sum = 3 * evenSum + oddSum;

            sum %= 10;

            if (sum != 0)
            {
                sum = 10 - sum;

            }

            HIDstr += sum;

            //------------------------------------------------------


            string fileInfo = Form1.molSettings[4] + HIDstr + "$" + textBox1.Text;


            using (StreamWriter sw = new StreamWriter(Form1.molSettings[3] + $"\\{HIDstr}.txt"))
            {
                sw.WriteLine(fileInfo);
            }


            File.Copy(Form1.molSettings[3] + $"\\{HIDstr}.txt", Form1.molSettings[2] + $"\\{HIDstr}.txt");

            File.Delete(Form1.molSettings[3] + $"\\{HIDstr}.txt");

            //-----------------------------------------------

            string str2 = komp0.Text;
            string str3 = komp1.Text;
            string str4 = bKomp1.Text;
            string str5 = "11.9999";
            DateTime TestDateTime1 = DateTime.Now;
            string strDate = "D" + TestDateTime1.ToString("yyyy/MM/dd/hh/mm/ss");

            string newString = strDate.Replace(".", "");

            string str6 = komp2.Text;
            string str7 = bKomp2.Text;
            string str8 = komp3.Text;
            string str9 = bKomp3.Text;
            string str10 = komp4.Text;
            string str11 = bKomp4.Text;

            string str12 = komp5.Text;
            string str13 = bKomp5.Text;

            string str14 = komp6.Text;
            string str15 = bKomp6.Text;

            string str16 = komp7.Text;
            string str17 = bKomp7.Text;

            string str18 = komp8.Text;
            string str19 = bKomp8.Text;

            string str20 = komp9.Text;
            string str21 = bKomp9.Text;

            string fullString = textBox1.Text + ";" + str2 + ";" + newString + ";" + str3 + ";" + str4 + ";" + str5 + ";" + str6 + ";" + str7 + ";" + str8 + ";" + str9 + ";" + str10 + ";" + str11 + ";" + str12 + ";" + str13 + ";" + str14 + ";" + str15 + ";" + str16 + ";" + str17 + ";" + str18 + ";" + str19 + ";" + str20 + ";" + str21 + ";";

            using (StreamWriter sw = new StreamWriter(Form1.molSettings[1] + $"\\{textBox1.Text}.txt"))
            {
                sw.WriteLine(fullString);
            }

            bKomp9.Text = "";
            bKomp8.Text = "";
            bKomp7.Text = "";
            bKomp6.Text = "";
            bKomp5.Text = "";
            bKomp4.Text = "";
            bKomp3.Text = "";
            bKomp2.Text = "";
            bKomp1.Text = "";
        }
    }
}
