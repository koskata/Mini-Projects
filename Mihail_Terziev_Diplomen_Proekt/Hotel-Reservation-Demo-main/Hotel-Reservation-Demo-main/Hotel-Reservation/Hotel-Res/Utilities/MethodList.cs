using Hotel_Res.Models;
using Hotel_Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Res.Utilities
{
    public class MethodList
    {
        public void LoadingData(List<Room> Rooms)
        {
            string filePath2 = FilePaths.ReservationFileSavePath;
            using (StreamReader reader = new StreamReader(filePath2))
            {

                while (reader.EndOfStream != true)
                {
                    var tempVariable = reader.ReadLine();
                    var newLine = tempVariable.Split(", ");
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

        public void ReturnToHome()
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

    }
}
