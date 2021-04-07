using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;


namespace BLL
{
    public class SwimmingPool:Person
    {
        string day;
        string time;


       
    
    public SwimmingPool()
    {

    }
    public SwimmingPool(string day,string time, string FirstName, string LastName, string Email, string Password, string MobileNumber, string TCKN, string Gender, string DateOfBirth, string Adress)
        : base(FirstName, LastName, Email, Password, MobileNumber, TCKN, Gender, DateOfBirth, Adress)
    {
        this.day = day;
        this.time = time;

    }
    public string Day { get => day; set => day = value; }
    public string Time { get => time; set => time = value; }

        public override int Login(string Email, string Password)
        {
            string query = string.Format("SELECT * FROM SWIMMINGPOOL WHERE " +
                "NAME = '{0}' , SURNAME = '{1}' ,  PHONENUMBER = '{2}' , DAY = '{3}' , TIME = '{4}' " , Firstname1, Lastname1,MobileNumber1,day,time);

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

        public DataTable ListSwimming()
        {
            try
            {
                string query = "select * from swimmingpool";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddSwimming(SwimmingPool sw)
        {
            try
            {
                string query = string.Format("INSERT INTO SwimmingPool(name,surname,phoneNumber,day,time) " +
                    "VALUES('{0}','{1}','{2}','{3}','{4}')", sw.Firstname1, sw.Lastname1,sw.MobileNumber1,sw.day,sw.time);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static int saveSwimming(string Name, string Surname, string PhoneNumber, string Day, string Time)
        {
            string query = string.Format("insert into SwimmingPool (Name,Surname,PhoneNumber,Day,Time) " +
                    "values('{0}','{1}','{2}','{3}','{4}');",
                   Name, Surname, PhoneNumber, Day, Time
                    );
            DataAcess da = new DataAcess();
            return da.ExecuteNonQuery(query);
        }


        public static DataTable ShowSwimming()
        {
            try
            {
                string query = string.Format("select * from SwimmingPool");
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
    
