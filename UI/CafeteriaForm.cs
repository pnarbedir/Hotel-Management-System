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

namespace UI
{
    public partial class CafeteriaForm : Form
    {
        public CafeteriaForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int sayi_1, sayi_2;
           
            sayi_1 = int.Parse(tbb1.Text);
            sayi_2 = 15;
            

            label4.Text = Convert.ToString(sayi_1 * sayi_2);
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int result = Restaurant.SaveRest(
                     cb1.SelectedItem.ToString(),
                     tbb1.Text,
                     label5.Text
                     );

                if (result != 0)
                {
                    label6.Text = "Thanks for your order";
                }
                else
                {
                    label6.Text = "Please try again";
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                
            }
        }
    }
}
