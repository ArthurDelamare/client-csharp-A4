namespace ClientProjetDomLog
{
    partial class uploadPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.textToDecrypt = new System.Windows.Forms.OpenFileDialog();
            this.Filename = new System.Windows.Forms.TextBox();
            this.filename2 = new System.Windows.Forms.TextBox();
            this.textToDecrypt2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Location = new System.Drawing.Point(520, 169);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DecryptBtn.Size = new System.Drawing.Size(138, 62);
            this.DecryptBtn.TabIndex = 0;
            this.DecryptBtn.Text = "Décrypter";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textToDecrypt
            // 
            this.textToDecrypt.FileOk += new System.ComponentModel.CancelEventHandler(this.textToDecrypt_FileOk);
            // 
            // Filename
            // 
            this.Filename.Location = new System.Drawing.Point(157, 134);
            this.Filename.Multiline = true;
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(309, 46);
            this.Filename.TabIndex = 1;
            this.Filename.Text = "\r\nSéléctionner un fichier";
            this.Filename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Filename.Click += new System.EventHandler(this.filename_TextChanged);
            // 
            // filename2
            // 
            this.filename2.Location = new System.Drawing.Point(157, 223);
            this.filename2.Multiline = true;
            this.filename2.Name = "filename2";
            this.filename2.Size = new System.Drawing.Size(309, 46);
            this.filename2.TabIndex = 2;
            this.filename2.Text = "\r\nSéléctionner un fichier";
            this.filename2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.filename2.Click += new System.EventHandler(this.filename2_TextChanged);
            // 
            // textToDecrypt2
            // 
            this.textToDecrypt2.FileOk += new System.ComponentModel.CancelEventHandler(this.textToDecrypt2_FileOk);
            // 
            // uploadPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filename2);
            this.Controls.Add(this.Filename);
            this.Controls.Add(this.DecryptBtn);
            this.Name = "uploadPage";
            this.Text = "Selectionner un fichier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.OpenFileDialog textToDecrypt;
        private System.Windows.Forms.TextBox Filename;
        private System.Windows.Forms.TextBox filename2;
        private System.Windows.Forms.OpenFileDialog textToDecrypt2;
    }
}