﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginscreen
{
    public partial class LoggedIn : UserControl
    {
        public LoggedIn()
        {
            InitializeComponent();
            
        }

        private void LoggedIn_Load(object sender, EventArgs e)
        {
            outputLabel.Text = "Welcome" + Form1.correctUsername;
        }
    }
}
