using System;
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

    public partial class loginscreen : UserControl
    {


        public loginscreen()
        {
            InitializeComponent();



            usernameLabel.Text = "Username:";
            passwordLabel.Text = "Password:";
            label1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (usernameInput.Text == Form1.correctUsername && passwordInput.Text == Form1.correctPassword)
            {
                // f is the form that this control is on - ("this" is the current User Control)
                Form f = this.FindForm();
                f.Controls.Remove(this);
                LoggedIn li = new LoggedIn();
                f.Controls.Add(li);
                
            }
            else
            {
                label1.Text = "The username or password is incorrect";
            }
        }

    }


}
    
