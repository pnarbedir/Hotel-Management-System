﻿using System;
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
    public partial class swlist : Form
    {
        public swlist()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void swlist_Load(object sender, EventArgs e)
        {
            dgvSwimming.DataSource = SwimmingPool.ShowSwimming();
        }
    }
}
