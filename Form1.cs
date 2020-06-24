using ClientProjetDomLog.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProjetDomLog
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            warning.Text = "";
            if (username.Text == null || username.Text == "" || password.Text == null || password.Text== "")
            {
                warning.Text = "Veuillez entrer l'identifiant et le mot de passe";
            }
            else
            {
                 ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                User user;
                var message = new {method= "login",version="1.0",param=new {username= username.Text,password=password.Text} };
                user = client.login(username.Text, password.Text);
                if (!user.valid)
                {
                    warning.Text = "l'identifiant ou le mot de passe est incorrect";
                }
                else
                {
                    var frm = new uploadPage();
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.FormClosing += delegate { this.Show(); };
                    frm.Show();
                    this.Hide();
                }
            }

        }
    }
}
