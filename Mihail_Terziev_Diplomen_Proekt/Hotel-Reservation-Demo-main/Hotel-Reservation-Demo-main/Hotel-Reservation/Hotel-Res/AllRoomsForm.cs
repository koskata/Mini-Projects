using Hotel_Res.Models;
using Hotel_Res.Utilities;
using Hotel_Reservations;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Res
{
    public partial class AllRoomsForm : Form
    {
        private MethodList methodList;

        List<Room> Rooms;
        public AllRoomsForm()
        {
            InitializeComponent();

            Rooms = new List<Room>();

            methodList = new MethodList();

        }

        private void AllRoomsForm_Load(object sender, EventArgs e)
        {
            methodList.LoadingData(Rooms);
            dataGridView1.DataSource = Rooms;
            DisplayingData();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            methodList.ReturnToHome();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void DisplayingData()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (Convert.ToBoolean(row.Cells[i].Value) == true)
                    {
                        row.Cells[i].Style.BackColor = Color.Green;
                    }
                    else if (Convert.ToBoolean(row.Cells[i].Value) == false)
                    {
                        row.Cells[i].Style.BackColor = Color.Red;
                    }
                }
            }
        }
    }
}
