using Hotel_Res;
using Hotel_Res.Models;
using Hotel_Res.Utilities;
using System.DirectoryServices.ActiveDirectory;

namespace Hotel_Reservations
{
    public partial class Form1 : Form
    {
        List<Room> Rooms = new List<Room>();
        public Form1()
        {
            InitializeComponent();

            string filePath = FilePaths.LocalStorageFolderPath;
            Directory.CreateDirectory(filePath);

            string filePath2 = FilePaths.ReservationFileSavePath;

            using (StreamReader reader = new StreamReader(filePath2))
            {

                if (reader.EndOfStream == true)
                {
                    Room roomToAdd;
                    for (int i = 1; i <= 30; i++)               
                    {
                        if (i % 2 == 0)
                        {
                            string roomType = "Стая";
                            roomToAdd = new Room(i, "", roomType, true, false);
                        }
                        else
                        {
                            string roomType = "Апартамент";
                            roomToAdd = new Room(i, "", roomType, true, false);
                        }

                        Rooms.Add(roomToAdd);
                    }

                    reader.Close();

                    using (StreamWriter writer = new StreamWriter(filePath2))//problem here with true value for append

                        foreach (var room in Rooms)
                        {
                            writer.WriteLine($"{room.RoomNumber}, {room.ReservationName}, {room.RoomType}, {room.IsCleaned}, {room.IsOccupated}");

                        }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllRoomsForm form = new AllRoomsForm();
            form.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakeReservationForm makeReservationForm = new MakeReservationForm();
            makeReservationForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CleanRoomForm cleanRoomForm = new CleanRoomForm();
            cleanRoomForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FreeingRoomForm cleanRoomForm = new FreeingRoomForm();
            cleanRoomForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}