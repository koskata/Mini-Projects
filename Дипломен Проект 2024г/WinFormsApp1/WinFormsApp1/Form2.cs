using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{


    public partial class Form2 : Form
    {
        public string year1;
        public string month1;

        public string prodSN = "";
        public string buffer = "";
        Dictionary<string, List<string>> serNumWithValues2;
        Dictionary<string, List<string>> serNumWithValues22;

        Dictionary<string, List<string>> engineInfo;

        public string prodCode;
        public string prodDescr;
        public string compSN;
        public string compSN1Code;
        public string compSN1Descr;
        public string compDate;

        public Form2()
        {
            InitializeComponent();

            serNumWithValues2 = new Dictionary<string, List<string>>();
            serNumWithValues22 = new Dictionary<string, List<string>>();

            engineInfo = new Dictionary<string, List<string>>();

            if (File.Exists("C:\\MOLSettings\\STD\\out.txt"))
            {
                using (StreamReader sr = new StreamReader("C:\\MOLSettings\\STD\\out.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lineArgs = line.Split(";");

                        string serialNumber = lineArgs[0];


                        serNumWithValues2[serialNumber] = new List<string>();

                        for (int j = 1; j <= lineArgs.Length - 1; j++)
                        {
                            serNumWithValues2[serialNumber].Add(lineArgs[j]);
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


                        serNumWithValues22[number] = new List<string>();

                        for (int j = 1; j <= lineArgs.Length - 1; j++)
                        {
                            serNumWithValues22[number].Add(lineArgs[j]);
                        }
                    }
                }
            }


            if (File.Exists("C:\\MOLSettings\\engineinfo.txt"))
            {
                using (StreamReader sr = new StreamReader("C:\\MOLSettings\\engineinfo.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lineArgs = line.Split(";");

                        string serialNumber = lineArgs[0];


                        engineInfo[serialNumber] = new List<string>();

                        for (int j = 1; j <= lineArgs.Length - 1; j++)
                        {
                            engineInfo[serialNumber].Add(lineArgs[j]);
                        }
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int symbolToAsciiCode = 0;
            if (textBox1.Text.Length > 0)
            {
                char symbol = textBox1.Text[textBox1.Text.Length - 1];
                symbolToAsciiCode = (Int32)symbol;
            }


            if (symbolToAsciiCode == 10 && textBox1.Text.Length > 3 && prodSN == "")
            {
                textBox5.Text = textBox1.Text;


                buffer = textBox5.Text.Substring(0, textBox5.Text.Length - 2);

                if (buffer.Length == 12 && buffer.Substring(0, 3) == "202" && prodSN == "")
                {
                    prodSN = buffer;
                }

                if (((buffer.Length == 7 && buffer.Substring(0, 1).ToLower() == "f") || (buffer.Length == 9 && buffer.Substring(0, 3).ToLower() == "bgf")) && (prodSN == ""))
                {
                    prodSN = buffer;
                }

                //-----------------------Update-----------------------------------------------

                

                if (File.Exists(Form1.molSettings[0] + "\\out.txt"))
                {
                    File.Delete("C:\\MOLSettings\\STD\\out.txt");
                    File.Copy(Form1.molSettings[0] + "\\out.txt", "C:\\MOLSettings\\STD\\out.txt");

                    if (File.Exists(Form1.molSettings[6] + "\\out.txt"))
                    {
                        File.Delete(Form1.molSettings[6] + "\\out.txt");
                    }


                    File.Copy(Form1.molSettings[0] + "\\out.txt", Form1.molSettings[6] + "\\out.txt");
                    File.Delete(Form1.molSettings[0] + "\\out.txt");

                    serNumWithValues2.Clear();

                    if (File.Exists("C:\\MOLSettings\\STD\\out.txt"))
                    {
                        using (StreamReader sr = new StreamReader("C:\\MOLSettings\\STD\\out.txt"))
                        {
                            string line;

                            while ((line = sr.ReadLine()) != null)
                            {
                                string[] lineArgs = line.Split(";");

                                string serialNumber = lineArgs[0];


                                serNumWithValues2[serialNumber] = new List<string>();

                                for (int j = 1; j <= lineArgs.Length - 1; j++)
                                {
                                    serNumWithValues2[serialNumber].Add(lineArgs[j]);
                                }
                            }
                        }
                    }
                }

                if (serNumWithValues2.ContainsKey(prodSN))
                {
                    //TODO
                    prodCode = serNumWithValues2[prodSN][0];
                    prodDescr = serNumWithValues22[prodCode][0];
                    compSN1Code = serNumWithValues2[prodSN][3];
                    compSN1Descr = serNumWithValues22[compSN1Code][0];

                    productCode.Text = prodCode;
                    productDescription.Text = prodDescr;
                    componentDescription.Text = compSN1Descr;
                    compSerNumCode.Text = compSN1Code;
                    textBox6.Text = serNumWithValues2[prodSN][1];

                    textBox1.Text = "";

                    //-----------------------------------------------

                    string HIDstr;

                    HIDstr = productCode.Text + "JR8" + prodSN;

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


                    string fileInfo = Form1.molSettings[4] + HIDstr + "$" + prodSN;


                    using (StreamWriter sw = new StreamWriter(Form1.molSettings[3] + $"\\{HIDstr}.txt"))
                    {
                        sw.WriteLine(fileInfo);
                    }


                    File.Copy(Form1.molSettings[3] + $"\\{HIDstr}.txt", Form1.molSettings[2] + $"\\{HIDstr}.txt");

                    File.Delete(Form1.molSettings[3] + $"\\{HIDstr}.txt");


                }
                else
                {
                    MessageBox.Show("Серийния номер не е открит! Актуализирайте и сканирайте отново!");
                }

            }



            if (symbolToAsciiCode == 10 && textBox1.Text.Length > 3 && prodSN != "")
            {
                compSN = textBox1.Text;
                compSerNum.Text = compSN;

                textBox1.Text = "";


                year1 = "";
                month1 = "";

                if (engineInfo.ContainsKey(compSN1Code))
                {
                    string engineProducer = engineInfo[compSN1Code][1];

                    int year4 = 0;

                    switch (engineProducer)
                    {
                        case "Kohler co.":
                            if (compSN.Substring(0, 2) == "48")
                            {
                                year1 = "2018";
                            }
                            if (compSN.Substring(0, 2) == "49")
                            {
                                year1 = "2019";
                            }
                            if (compSN.Substring(0, 2) == "50")
                            {
                                year1 = "2020";
                                year4 = 1;
                            }
                            if (compSN.Substring(0, 2) == "51")
                            {
                                year1 = "2021";
                            }
                            if (compSN.Substring(0, 2) == "52")
                            {
                                year1 = "2022";
                            }
                            if (compSN.Substring(0, 2) == "53")
                            {
                                year1 = "2023";
                            }
                            if (compSN.Substring(0, 2) == "54")
                            {
                                year1 = "2024";
                                year4 = 1;
                            }
                            if (compSN.Substring(0, 2) == "55")
                            {
                                year1 = "2025";
                            }
                            if (compSN.Substring(0, 2) == "56")
                            {
                                year1 = "2026";
                            }
                            if (compSN.Substring(0, 2) == "57")
                            {
                                year1 = "2027";
                            }
                            if (compSN.Substring(0, 2) == "58")
                            {
                                year1 = "2028";
                                year4 = 1;
                            }
                            if (compSN.Substring(0, 2) == "59")
                            {
                                year1 = "2029";
                            }
                            if (compSN.Substring(0, 2) == "60")
                            {
                                year1 = "2030";
                            }

                            //---------------------



                            if (int.Parse(compSN.Substring(2, 3)) < 32)
                            {
                                month1 = "01.";
                            }
                            if (int.Parse(compSN.Substring(2, 3)) < 60 + year4)
                            {
                                month1 = "02.";
                            }
                            if (int.Parse(compSN.Substring(2, 3)) < 91 + year4)
                            {
                                month1 = "03.";
                            }
                            if (int.Parse(compSN.Substring(2, 3)) < 121 + year4)
                            {
                                month1 = "04.";
                            }
                            if (int.Parse(compSN.Substring(2, 3)) < 152 + year4)
                            {
                                month1 = "05.";
                            }
                            if (int.Parse(compSN.Substring(2, 3)) < 182 + year4)
                            {
                                month1 = "06.";
                            }
                            if (int.Parse(compSN.Substring(2, 3)) < 213 + year4)
                            {
                                month1 = "07.";
                            }
                            if (int.Parse(compSN.Substring(2, 3)) < 244 + year4)
                            {
                                month1 = "08.";
                            }
                            if (int.Parse(compSN.Substring(2, 3)) < 274 + year4)
                            {
                                month1 = "09.";
                            }
                            if (int.Parse(compSN.Substring(2, 3)) < 305 + year4)
                            {
                                month1 = "10.";
                            }
                            if (int.Parse(compSN.Substring(2, 3)) < 335 + year4)
                            {
                                month1 = "11.";
                            }
                            if (int.Parse(compSN.Substring(2, 3)) < 365 + year4)
                            {
                                month1 = "12.";
                            }
                            break;
                        case "Kubota Corporation":
                            if (compSN.Substring(2, 1).ToLower() == "a" || compSN.Substring(2, 1).ToLower() == "b")
                            {
                                month1 = "01.";
                            }
                            if (compSN.Substring(2, 1).ToLower() == "c" || compSN.Substring(2, 1).ToLower() == "d")
                            {
                                month1 = "02.";
                            }
                            if (compSN.Substring(2, 1).ToLower() == "e" || compSN.Substring(2, 1).ToLower() == "f")
                            {
                                month1 = "03.";
                            }
                            if (compSN.Substring(2, 1).ToLower() == "g" || compSN.Substring(2, 1).ToLower() == "h")
                            {
                                month1 = "04.";
                            }
                            if (compSN.Substring(2, 1).ToLower() == "j" || compSN.Substring(2, 1).ToLower() == "k")
                            {
                                month1 = "05.";
                            }
                            if (compSN.Substring(2, 1).ToLower() == "l" || compSN.Substring(2, 1).ToLower() == "m")
                            {
                                month1 = "06.";
                            }
                            if (compSN.Substring(2, 1).ToLower() == "n" || compSN.Substring(2, 1).ToLower() == "p" || compSN.Substring(2, 1).ToLower() == "o")
                            {
                                month1 = "07.";
                            }
                            if (compSN.Substring(2, 1).ToLower() == "q" || compSN.Substring(2, 1).ToLower() == "r")
                            {
                                month1 = "08.";
                            }
                            if (compSN.Substring(2, 1).ToLower() == "s" || compSN.Substring(2, 1).ToLower() == "t")
                            {
                                month1 = "09.";
                            }
                            if (compSN.Substring(2, 1).ToLower() == "u" || compSN.Substring(2, 1).ToLower() == "v")
                            {
                                month1 = "10.";
                            }
                            if (compSN.Substring(2, 1).ToLower() == "w" || compSN.Substring(2, 1).ToLower() == "x")
                            {
                                month1 = "11.";
                            }
                            if (compSN.Substring(2, 1).ToLower() == "y" || compSN.Substring(2, 1).ToLower() == "z")
                            {
                                month1 = "12.";
                            }

                            //-------------------

                            if (compSN.Substring(1, 1).ToLower() == "j")
                            {
                                year1 = "2018";
                            }
                            if (compSN.Substring(1, 1).ToLower() == "k")
                            {
                                year1 = "2019";
                            }
                            if (compSN.Substring(1, 1).ToLower() == "l")
                            {
                                year1 = "2020";
                            }
                            if (compSN.Substring(1, 1).ToLower() == "m")
                            {
                                year1 = "2021";
                            }
                            if (compSN.Substring(1, 1).ToLower() == "n")
                            {
                                year1 = "2022";
                            }
                            if (compSN.Substring(1, 1).ToLower() == "p")
                            {
                                year1 = "2023";
                            }
                            if (compSN.Substring(1, 1).ToLower() == "r")
                            {
                                year1 = "2024";
                            }
                            if (compSN.Substring(1, 1).ToLower() == "s")
                            {
                                year1 = "2025";
                            }
                            if (compSN.Substring(1, 1).ToLower() == "t")
                            {
                                year1 = "2026";
                            }
                            if (compSN.Substring(1, 1).ToLower() == "u")
                            {
                                year1 = "2027";
                            }
                            if (compSN.Substring(1, 1).ToLower() == "v")
                            {
                                year1 = "2028";
                            }
                            if (compSN.Substring(1, 1).ToLower() == "w")
                            {
                                year1 = "2029";
                            }
                            if (compSN.Substring(1, 1).ToLower() == "x")
                            {
                                year1 = "2030";
                            }
                            break;
                        case "Motorenfabrik Hatz GmbH & Co.KG":
                            year1 = "20" + compSN.Substring(5, 2);

                            break;
                        default:
                            year1 = "";
                            month1 = "";
                            break;

                    }


                }

                DateTime TestDateTime1 = DateTime.Now;
                string strDate = "D" + TestDateTime1.ToString("yyyy/MM/dd/hh/mm/ss");

                string newString = strDate.Replace(".", "");

                Form4 form = new Form4();
                form.Show();

                compSN = compSN.Replace("\r\n", "");

                form.textBox3.Text = month1 + year1;
                form.textBox5.Text = prodSN + ";" + textBox6.Text + ";" + newString + ";" + compSN1Code + ";" + compSN + ";";

                switch (year1)
                {
                    case "2020":
                        form.y2020.Checked = true;
                        break;
                    case "2021":
                        form.y2021.Checked = true;
                        break;
                    case "2022":
                        form.y2022.Checked = true;
                        break;
                    case "2023":
                        form.y2023.Checked = true;
                        break;
                    case "2024":
                        form.y2024.Checked = true;
                        break;
                    case "2025":
                        form.y2025.Checked = true;
                        break;
                    case "2026":
                        form.y2026.Checked = true;
                        break;
                    case "2027":
                        form.y2027.Checked = true;
                        break;
                    case "2028":
                        form.y2028.Checked = true;
                        break;

                    default:
                        break;
                }

                switch (month1)
                {
                    case "01.":
                        form.jan.Checked = true;
                        break;
                    case "02.":
                        form.feb.Checked = true;
                        break;
                    case "03.":
                        form.mar.Checked = true;
                        break;
                    case "04.":
                        form.apr.Checked = true;
                        break;
                    case "05.":
                        form.may.Checked = true;
                        break;
                    case "06.":
                        form.june.Checked = true;
                        break;
                    case "07.":
                        form.july.Checked = true;
                        break;
                    case "08.":
                        form.aug.Checked = true;
                        break;
                    case "09.":
                        form.sep.Checked = true;
                        break;
                    case "10.":
                        form.oct.Checked = true;
                        break;
                    case "11.":
                        form.nov.Checked = true;
                        break;
                    case "12.":
                        form.dec.Checked = true;
                        break;

                    default:
                        break;
                }
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
