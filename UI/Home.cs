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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            GuestForm Guestf = new GuestForm();
            Guestf.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Show(); //tıklanınca diğer forma gitsin
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InformationHotel InfH = new InformationHotel();
            InfH.Show();
        }
    }
}
