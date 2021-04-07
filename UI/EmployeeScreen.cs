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
    public partial class EmployeeScreen : Form
    {
        public EmployeeScreen()
        {
            InitializeComponent();
        }

        public DataTable dataGridView1 { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            per p = new per();
            p.Show();
            try
               {
                   Receptionist r = new Receptionist();
                    dataGridView1 = r.ListPerson();
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
            
        }
        public DataTable dgvSwimming { get; private set; }
        public DataTable dgvRestorant { get; private set; }

        private void button3_Click(object sender, EventArgs e)
        {
            swlist sw = new swlist();
            sw.Show();
            try
            {
                SwimmingPool s= new SwimmingPool();
                dgvSwimming = s.ListSwimming();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            restform r = new restform();
            r.Show();

            try
            {
                Restaurant rs = new Restaurant();
                dgvRestorant = rs.ListRest();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
    }
    
