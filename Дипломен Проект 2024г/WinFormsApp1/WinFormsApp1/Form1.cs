using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public static string[] molSettings = new string[15];


        public Form1()
        {
            InitializeComponent();
            instance = this;

            if (File.Exists("../../../MOLSettings/MOLSettings.txt"))
            {
                using (StreamReader sr = new StreamReader("../../../MOLSettings/MOLSettings.txt"))
                {
                    string line;

                    //while ((line = sr.ReadLine()) != null)
                    //{
                    //    Console.WriteLine(line);
                    //}

                    for (int i = 0; i < 12; i++)
                    {
                        line = sr.ReadLine();
                        molSettings[i] = line;
                    }


                    for (int i = 0; i < 12; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                textBox1.Text = molSettings[i];
                                textBox1.Update();
                                break;
                            case 1:
                                textBox2.Text = molSettings[i];
                                textBox2.Update();
                                break;
                            case 2:
                                textBox3.Text = molSettings[i];
                                textBox3.Update();
                                break;
                            case 3:
                                textBox4.Text = molSettings[i];
                                textBox4.Update();
                                break;
                            case 4:
                                textBox5.Text = molSettings[i];
                                textBox5.Update();
                                break;
                            case 5:
                                textBox6.Text = molSettings[i];
                                textBox6.Update();
                                break;
                            case 6:
                                textBox7.Text = molSettings[i];
                                textBox7.Update();
                                break;
                            case 7:
                                textBox8.Text = molSettings[i];
                                textBox8.Update();
                                break;
                            case 8:
                                textBox9.Text = molSettings[i];
                                textBox9.Update();
                                break;
                            case 9:
                                textBox10.Text = molSettings[i];
                                textBox10.Update();
                                break;
                            case 10:
                                textBox11.Text = molSettings[i];
                                textBox11.Update();
                                break;
                            //case 11:
                            //    textBox12.Text = molSettings[i];
                            //    textBox12.Update();
                            //    break;

                            default:
                                break;
                        }
                    }


                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            //form.serNumWithValues[""].Add("");
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}