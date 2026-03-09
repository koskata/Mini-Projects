using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Hotel_Res.Models;
using Hotel_Res.Utilities;
using Hotel_Reservations;

namespace Hotel_Res
{
    public partial class FreeingRoomForm : Form
    {

        List<Room> Rooms;
        List<Room> newListRooms = new();
        public FreeingRoomForm()
        {
            InitializeComponent();

            Rooms = new List<Room>();

            string filePath2 = FilePaths.ReservationFileSavePath;
            using (StreamReader reader = new StreamReader(filePath2))
            {

                int charsRemeining = reader.Peek();
                if (charsRemeining > 1)
                {
                    while (reader.EndOfStream != true)
                    {

                        var t = reader.ReadLine();
                        var newLine = t.Split(", ");
                        int roomNumber = int.Parse(newLine[0]);
                        string name = newLine[1];
                        string roomType = newLine[2];
                        bool isCleaned = bool.Parse(newLine[3]);
                        bool isOccupated = bool.Parse(newLine[4]);


                        var roomToAdd = new Room(roomNumber, name, roomType, isCleaned, isOccupated);

                        Rooms.Add(roomToAdd);

                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (int.TryParse(input, out _))
            {
                int inputNumber = int.Parse(input);
                if (inputNumber < 1 || inputNumber > 30)
                {
                    MessageBox.Show(ExceptionMessages.nonExistantRoomNumber);
                }
                else
                {
                    Room currentRoom = Rooms.FirstOrDefault(x => x.RoomNumber == inputNumber);

                    if (currentRoom.IsOccupated == false)
                    {
                        MessageBox.Show($"Тази стая е свободна вече!");
                    }
                    else
                    {
                        currentRoom.IsOccupated = false;
                        currentRoom.ReservationName = "";
                        MessageBox.Show($"Стаята е освободена!");

                        Room roomToAdd;

                        var index = Rooms.IndexOf(currentRoom);
                        Rooms.RemoveAt(index);
                        Rooms.Insert(index, currentRoom);

                        string filePath2 = FilePaths.ReservationFileSavePath;
                        using (StreamWriter writer = new StreamWriter(filePath2)) //problem here with true value for append

                            foreach (var room in Rooms)
                            {
                                writer.WriteLine($"{room.RoomNumber}, {room.ReservationName}, {room.RoomType}, {room.IsCleaned}, {room.IsOccupated}");
                            }
                    }
                }
            }
            else
            {
                MessageBox.Show("Използвайте само числа!");
            }
        }

        private void FreeingRoomForm_Load(object sender, EventArgs e)
        {

        }
    }
}
