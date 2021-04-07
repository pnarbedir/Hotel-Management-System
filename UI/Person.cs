using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace UI
{
    public partial class Person : Form
    {
        public Person()
        {
            InitializeComponent();
        }

        private void Person_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

             try
             {

             string email = textBox1.Text;
             string password = textBox2.Text;


                 if (email == string.Empty)
                   {
                      MessageBox.Show("Please enter your email");
                      return;
                    }

                   if (password == string.Empty)
                    {
                        MessageBox.Show("Please enter your password");
                     return;
                   }


                    Receptionist r = new Receptionist();


                    r.Email1 = email;
                    r.Password1 = password;

                    int result = r.AddPerson(r);
                    if (result > 0)
                   {

                        textBox1.Text = "";
                        textBox2.Text = "";
                        if(email=="pinar" && password == "2317")
                    {
                        MessageBox.Show("Welcome Pınar");
                        EmployeeScreen Employees = new EmployeeScreen();
                        Employees.Show();
                        this.Hide();
                    }
                    else if (email == "seyma" && password == "0506")
                    {
                        MessageBox.Show("Welcome Şeyma");
                        EmployeeScreen Employees = new EmployeeScreen();
                        Employees.Show();
                        this.Hide();
                    }
                    else if (email == "hilal" && password == "2525")
                    {
                        MessageBox.Show("Welcome Hilal");
                        EmployeeScreen Employees = new EmployeeScreen();
                        Employees.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please try again");
                    }


                }

            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               

            }



        //    SqlConnection con;
        //    SqlCommand cmd;
        //    SqlDataReader dr;
        //    string user = textBox1.Text;
        //    string pass = textBox2.Text;
        //    con = new SqlConnection("server=DESKTOP-JU1LJ2M\\SQLEXPRESS; Initial Catalog=dbLogin;Integrated Security=SSPI");
        //    cmd = new SqlCommand();
        //    con.Open();
        //    cmd.Connection = con;
        //    cmd.CommandText = "SELECT * FROM Person where Email='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'";
        //    dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
        //    }
        //    con.Close();

        //}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}


        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Home h = new Home();
        //    h.Show();
        //    this.Hide();


        //}

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{

        //}
    

