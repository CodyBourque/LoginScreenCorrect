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

            }

        private void button1_Click(object sender, EventArgs e)
        {
            string correctUsername = "Robert";
            string correctPassword = "hunter2";
            string Username = Convert.ToString(usernameInput);
            string Password = Convert.ToString(passwordInput);

        if(Username == correctUsername && Password == correctPassword)
            {
                LoggedIn li = new LoggedIn();
                this.Controls.Add(li);
            }
            else
            {

            }
        }
    }


        }
    
