﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADP_Tests
{
    public partial class SmokeTestWindowInfo : Form
    {
        public SmokeTestWindowInfo()
        {
            InitializeComponent();
        }

        private void StartTest_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SmokeTestWindowInfo_Load(object sender, EventArgs e)
        {
            this.Visible = true;
        }
    }
}
