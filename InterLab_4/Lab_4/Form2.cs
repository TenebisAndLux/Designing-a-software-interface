﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(DataSet dss, string tableName)
        {
            InitializeComponent();
            dgvSearch.DataSource = dss;
            dgvSearch.DataMember = tableName;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
