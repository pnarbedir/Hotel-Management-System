using BLL;
using DAL;
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
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               int result = Guest.saveGuest(comboBoxCity.SelectedItem.ToString(),
                    textName.Text,
                    textSurname.Text,
                    textEposta.Text,
                    textID.Text,
                    textNumber.Text,
                    comboBoxRoom.SelectedItem.ToString(),
                    dtpArrived.Text,
                    dtpReturn.Text);

                if(result != 0)
                {
                    MessageBox.Show("Successfully added");
                }
                else
                {
                    MessageBox.Show("Not added");
                }


            }catch(Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpReturn_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
