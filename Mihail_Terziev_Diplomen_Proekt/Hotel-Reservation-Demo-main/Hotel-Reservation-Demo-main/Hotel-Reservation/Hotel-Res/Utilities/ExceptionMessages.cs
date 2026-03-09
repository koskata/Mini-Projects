using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Res.Utilities
{
    public class ExceptionMessages
    {
        public const string nonExistantRoomNumber = "Такъв номер на стая не съществува! Стаите са с номера от 1-30!";
        public const string useOnlyNums = "Използвайте само числа!";
        public const string roomCleanedSuccessfully = "Стаята е изчистена!";
        public const string roomAlreadyCleaned = "Тази стая е чиста вече!";
        public const string reservationNameNecessary = "Името на резервацията е задължително!";
        public const string impossibleReservation = $"Стаята не е изчистена. \r\nРезервацията не е възможна!";
        public const string doneReservation = "Успешно направена резервация на името на ";
    }
}
