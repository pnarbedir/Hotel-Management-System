using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Receptionist : Person

    {
        string Date;
        string Reservation;
        string Room;
        int NumberOfPerson;
        int NumberOfBaby;
        int price;
        int RoomID;

        public Receptionist()
        {

        }
        public Receptionist(string Date, string Reservation, string Room, int NumberOfPerson, int NumberOfBaby, int price, int RoomID, string FirstName, string LastName, string Email, string Password, string MobileNumber, string TCKN, string Gender, string DataOfBirth, string Adress)
            : base(FirstName, LastName, Email, Password, MobileNumber, TCKN, Gender, DataOfBirth, Adress)
        {
            this.Date1 = Date;
            this.Reservation1 = Reservation;
            this.Room1 = Room;
            this.NumberOfPerson1 = NumberOfPerson;
            this.NumberOfBaby1 = NumberOfBaby;
            this.Price = price;
            this.RoomID1 = RoomID;
        }

        public string Date1 { get => Date; set => Date = value; }
        public string Reservation1 { get => Reservation; set => Reservation = value; }
        public string Room1 { get => Room; set => Room = value; }
        public int NumberOfPerson1 { get => NumberOfPerson; set => NumberOfPerson = value; }
        public int NumberOfBaby1 { get => NumberOfBaby; set => NumberOfBaby = value; }
        public int Price { get => price; set => price = value; }
        public int RoomID1 { get => RoomID; set => RoomID = value; }

        public override int Login(string Email, string Password)
        {
            string query = string.Format("SELECT * FROM PERSON WHERE " +
                "EMAIL = '{0}' AND PASSWORD = '{1}'", Email, Password);

            DataAcess da = new DataAcess();
            DataTable dt = da.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
       
        public DataTable ListPerson()
        {
            try
            {
                string query = "select * from person";
              DataAcess da = new DataAcess();
              return da.ExecuteQuery(query);
          }
          catch (Exception ex)
          {
             throw new Exception(ex.Message);
         }
        }

        public int AddPerson(Receptionist r)
        {
            try
            {
                string query = string.Format("INSERT INTO person(email,password) " +
                    "VALUES('{0}','{1}')", r.Email1, r.Password1);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


       
        public static DataTable ShowGuest()
        {
            try
            {
                string query = string.Format("select * from Guest");
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
