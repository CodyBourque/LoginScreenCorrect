using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginscreen
{
    public partial class Form1 : Form
    {
        public static string correctUsername = "Robert";
        public static string correctPassword = "hunter2";

        public Form1()
        {
            InitializeComponent();
            loginscreen ls = new loginscreen();
            this.Controls.Add(ls);
        }
    }
}
