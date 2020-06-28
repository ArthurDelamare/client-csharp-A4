using System;
using System.Windows.Forms;

using ClientProjetDomLog.CUT;

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
                    var uploadForm = new UploadForm();
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
