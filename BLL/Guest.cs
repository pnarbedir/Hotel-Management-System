using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Guest : Person
    {
        int GuestID;
        String DatePositionEntered;
        String DatePositionOut;
        int RoomID;

        public Guest(int GuestID, String DatePositionEntered, String DataPositionOut, string FirstName, string LastName, string Email, string Password, string MobileNumber, string TCKN, string Gender, String DataOfBirth, String Adress)
            : base(FirstName, LastName, Email, Password, MobileNumber, TCKN, Gender, DataOfBirth, Adress)
        {
            this.GuestID1 = GuestID;
            this.DatePositionEntered1 = DatePositionEntered;
            this.DatePositionOut1 = DatePositionOut1;
            this.RoomID1 = RoomID1;
        }

        public int GuestID1 { get => GuestID; set => GuestID = value; }
        public string DatePositionEntered1 { get => DatePositionEntered; set => DatePositionEntered = value; }
        public string DatePositionOut1 { get => DatePositionOut; set => DatePositionOut = value; }
        public int RoomID1 { get => RoomID; set => RoomID = value; }

        public static int saveGuest(string city, string name, string surname, string TCKimlik, string eposta, string phoneNumber, string room , string DateOfArrived, string DateOfReturn)
        {
            string query = string.Format("insert into Guest (city,name,surname,TCKimlik,eposta,phoneNumber,room ,DateOfArrived,DateOfReturn) " +
                    "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');",
                    city,name,surname,TCKimlik,eposta,phoneNumber,room,DateOfArrived,DateOfReturn
                    );
            DataAcess da = new DataAcess();
            return da.ExecuteNonQuery(query);
        }

        public override int Login(string email,string password)
        {
            return 1;
        }
    }
}
