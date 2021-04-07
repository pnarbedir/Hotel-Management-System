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
    public partial class SwimmingForm : Form
    {
        public SwimmingForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int result = SwimmingPool.saveSwimming(
                     textName.Text,
                     textSurname.Text,
                     textNumber.Text,
                     comboBoxDay.SelectedItem.ToString(),
                     comboBoxTime.SelectedItem.ToString()
                     );

                if (result != 0)
                {
                    MessageBox.Show("Your appointment has been approved.");

                    
                }
                else
                {
                    MessageBox.Show("Please,try again.");
                }


            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }
    }
}
