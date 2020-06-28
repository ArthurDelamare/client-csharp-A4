using ClientProjetDomLog.CUT;
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
    public partial class LoginPage : Form
    {
        public LoginPage()
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
                bool valid = LoginController.Authenticate(username.Text, password.Text);

                if (!valid)
                {
                    warning.Text = "l'identifiant ou le mot de passe est incorrect";
                }
                else
                {
                    var uploadForm = new UploadForm(LoginController.UserToken);
                    uploadForm.Location = this.Location;
                    uploadForm.StartPosition = FormStartPosition.Manual;
                    uploadForm.FormClosing += delegate { this.Show(); };
                    uploadForm.Show();
                    this.Hide();
                }
            }

        }
    }
}
