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
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReservationForm resf = new ReservationForm();
            resf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SwimmingForm sf = new SwimmingForm();
            sf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CafeteriaForm cf = new CafeteriaForm();
            cf.Show();
            this.Hide();
        }
    }
}
