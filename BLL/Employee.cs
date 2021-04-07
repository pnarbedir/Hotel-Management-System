using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Employee : Person
    {
        int EmployeeID;
        int WorkingTime;
        int Salary;
        int RoomID;
        int PriceOfHour;

        public Employee(int EmployeeID, string FirstName, string LastName, string Email, string Password, string MobileNumber, string TCKN, string Gender, String DataOfBirth, String Adress)
            : base(FirstName, LastName, Email, Password, MobileNumber, TCKN, Gender, DataOfBirth, Adress)
        {
            this.EmployeeID1 = EmployeeID;
            this.WorkingTime1 = WorkingTime1;
            this.Salary1 = Salary1;
            this.RoomID1 = RoomID1;
            this.PriceOfHour1 = PriceOfHour1;
        }

        public int EmployeeID1 { get => EmployeeID; set => EmployeeID = value; }
        public int WorkingTime1 { get => WorkingTime; set => WorkingTime = value; }
        public int Salary1 { get => Salary; set => Salary = value; }
        public int RoomID1 { get => RoomID; set => RoomID = value; }
        public int PriceOfHour1 { get => PriceOfHour; set => PriceOfHour = value; }

        public override int Login(string Email, string Password)
        {
            if (Email == "admin@otel.com.tr" && Password == "4434")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }

}
