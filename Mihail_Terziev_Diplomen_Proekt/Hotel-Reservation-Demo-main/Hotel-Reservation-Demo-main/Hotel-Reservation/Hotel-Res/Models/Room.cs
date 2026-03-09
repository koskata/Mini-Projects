using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Res.Models
{
    public class Room
    {
		private string reservationName;
		private int roomNumber;

		private string roomType;
		private bool isCleaned;
        private bool isOccupated;


		public Room(int roomNumber, string reservationName, string roomType, bool isCleaned, bool isOccupated)
		{
            this.roomNumber = roomNumber;
            this.reservationName = reservationName;
            this.roomType = roomType;
            this.isCleaned = isCleaned;
            this.isOccupated = isOccupated;
        }



        public bool IsOccupated
		{
			get { return isOccupated; }
			set { isOccupated = value; }
		}

		public bool IsCleaned
		{
			get { return isCleaned; }
			set { isCleaned = value; }
		}

		public string RoomType
		{
			get { return roomType; }
			set { roomType = value; }
		}

		public string ReservationName
		{
			get { return reservationName; }
			set { reservationName = value; }
		}

		public int RoomNumber
		{
			get { return roomNumber; }
			set { roomNumber = value; }
		}

	}
}
