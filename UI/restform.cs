using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class restform : Form
    {
        public restform()
        {
            InitializeComponent();
        }

        private void dgvRestorant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void restform_Load(object sender, EventArgs e)
        {
            dgvRestorant.DataSource = Restaurant.ShowRest();
        }
    }
}
