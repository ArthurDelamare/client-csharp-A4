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
                 ServiceReference1.ServerClient client = new ServiceReference1.ServerClient();

                var message2 = new ServiceReference1.Message();
                message2.OperationName = "authenticate";
                message2.OperationVersion = "1";
                object[] data = { username.Text, password.Text};
                message2.Data = data;

                bool valid = false;
                string token = "";

                var answer = client.Process(message2);

                try
                {
                    valid = (bool)answer.Data[0];
                    token = (string)answer.Data[1];
                } 
                catch
                {
                    Console.WriteLine("Error while parsing answer");
                }
                

                if (!valid)
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
