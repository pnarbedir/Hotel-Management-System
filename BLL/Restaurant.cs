using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Restaurant : Person
    {
        string drinkName;
        string drinkNumber;
        string drinkPrice;


        public Restaurant()
        {

        }
        public Restaurant(string drinkName, string drinkNumber, string drinkPrice, string FirstName, string LastName, string Email, string Password, string MobileNumber, string TCKN, string Gender, string DateOfBirth, string Adress)
             : base(FirstName, LastName, Email, Password, MobileNumber, TCKN, Gender, DateOfBirth, Adress)
        {
            this.drinkName = drinkName;
            this.drinkNumber = drinkNumber;
            this.drinkPrice = drinkPrice;
        }

        public string DrinkName { get => drinkName; set => drinkName = value; }
        public string DrinkNumber { get => drinkNumber; set => drinkNumber = value; }
        public string DrinkPrice { get => drinkPrice; set => drinkPrice = value; }
        public override int Login(string Email, string Password)
        {
            string query = string.Format("SELECT * FROM RESTAURANT WHERE " +
                 "DRINKNAME = '{0}' , DRINKNUMBER = '{1}' , DRINKPRICE = '{2}'", drinkName, drinkNumber, drinkPrice);

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
        public DataTable ListRest()
        {
            try
            {
                string query = "select * from restaurantform";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddRest(Restaurant r)
        {
            try
            {
                string query = string.Format("INSERT INTO RestaurantForm(drinkname,drinknumber,drinkprice) " +
                    "VALUES('{0}','{1}','{2}')", r.DrinkName, r.DrinkNumber, r.DrinkPrice);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static int SaveRest(string DrinkName, string DrinkNumber, string DrinkPrice)
        {
            string query = string.Format("insert into RestaurantForm (DrinkName,DrinkNumber,DrinkPrice) " +
                    "values('{0}','{1}','{2}');",
                    DrinkName, DrinkNumber, DrinkPrice
                    );
            DataAcess da = new DataAcess();
            return da.ExecuteNonQuery(query);
        }

        public static DataTable ShowRest()
        {
            try
            {
                string query = string.Format("select * from RestaurantForm");
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
