using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class Person
    {
        string Firstname;
        string Lastname;
        string Email;
        string Password;
        string MobileNumber;
        string TCKN;
        string Gender;
        string DateOfBirth;
        string Address;

        public Person()
        {

        }

        public Person(string Firstname, string Lastname, string Email, string Password, string MobileNumber, string TCKN, string Gender, string DateOfBirth, string Address)
        {
            this.Firstname1 = Firstname;
            this.Lastname1 = Lastname;
            this.Email1 = Email;
            this.Password1 = Password;
            this.MobileNumber1 = MobileNumber;
            this.TCKN1 = TCKN;
            this.Gender1 = Gender;
            this.DateOfBirth1 = DateOfBirth;
            this.Address1 = Address;
        }

        public string Firstname1 { get => Firstname; set => Firstname = value; }
        public string Lastname1 { get => Lastname; set => Lastname = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string MobileNumber1 { get => MobileNumber; set => MobileNumber = value; }
        public string TCKN1 { get => TCKN; set => TCKN = value; }
        public string Gender1 { get => Gender; set => Gender = value; }
        public string DateOfBirth1 { get => DateOfBirth; set => DateOfBirth = value; }
        public string Address1 { get => Address; set => Address = value; }

        public abstract int Login(string email, string Password);


        public void Logout()
        {

        }
        public List<string> ShowAnnouncement()
        {
            return null;
        }
    }
}
