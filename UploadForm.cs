﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using ClientProjetDomLog.ServiceReference1;

namespace ClientProjetDomLog
{
    public partial class UploadForm : Form
    {
        private string token;
        public UploadForm(string token)
        {
            
            InitializeComponent();
            this.token = token;
        }
        private string file1;
        private string file2;

        private void button1_Click(object sender, EventArgs e)
        {

            var filedata1 = new FileData();
            filedata1.content = file1;
            filedata1.name = Filename.Text;

            var filedata2 = new FileData();
            filedata2.content = file2;
            filedata2.name = filename2.Text;

            object[] data = { (object)filedata1, (object)filedata2 };
            ServiceReference1.Message message = new ServiceReference1.Message();
            message.Info = "Request to decrypt files.";
            message.OperationName = "decrypt";
            message.OperationVersion = "1";
            message.AppVersion = "1";
            message.Data = data;
            message.TokenUser = this.token;
            message.TokenApp = "Client123";

            ServerClient client = new ServerClient();
            var answer = client.Process(message);

            Console.WriteLine(file1);
            Console.WriteLine(file2);
            

        }


        private void textToDecrypt_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void textToDecrypt2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void filename_TextChanged(object sender, EventArgs e)
        {

            this.file1 = readfile(textToDecrypt, Filename);

        }

        private void filename2_TextChanged(object sender, EventArgs e)
        {
            this.file2 = readfile(textToDecrypt2, filename2);

        }

        private string readfile(OpenFileDialog fileDialog, TextBox label)
        {
            string fileName;
            

            // On interdit la sélection de plusieurs fichiers.
            fileDialog.Multiselect = false;

            // On supprime le nom de fichier, qui ici vaut "openFileDialog1" (avant sélection d'un fichier).
            fileDialog.FileName = string.Empty;

            // On met des filtres pour les types de fichiers : "Nom|*.extension|autreNom|*.autreExtension" (autant de filtres qu'on veut).
            fileDialog.Filter = "Fichiers texte|*.txt|Tous les fichiers|*.*";

            // Le filtre sélectionné : le 2e (là on ne commence pas à compter à 0).
            fileDialog.FilterIndex = 2;

            // On affiche le dernier dossier ouvert.
            fileDialog.RestoreDirectory = true;

            // Si l'utilisateur clique sur "Ouvrir"...
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // On récupère le nom du fichier.
                    fileName = fileDialog.FileName;
                    label.Text = fileName;
                    

                    // On lit le fichier.
                    return File.ReadAllText(fileName);
                }
                // En cas d'erreur...
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de l'ouverture du fichier : {0}.", ex.Message);
                }
            }

            return "";
        }
    }
}
