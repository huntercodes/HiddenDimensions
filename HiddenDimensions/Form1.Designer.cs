namespace HiddenDimensions
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileEncrypt = new System.Windows.Forms.TextBox();
            this.txtEncryptPassword = new System.Windows.Forms.TextBox();
            this.btnBrowseEncrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnBrowseDecrypt = new System.Windows.Forms.Button();
            this.txtDecryptPassword = new System.Windows.Forms.TextBox();
            this.txtFileDecrypt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(99, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(50, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select a file:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(229, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "set an encryption key";
            // 
            // txtFileEncrypt
            // 
            this.txtFileEncrypt.Location = new System.Drawing.Point(53, 158);
            this.txtFileEncrypt.Name = "txtFileEncrypt";
            this.txtFileEncrypt.Size = new System.Drawing.Size(292, 20);
            this.txtFileEncrypt.TabIndex = 3;
            // 
            // txtEncryptPassword
            // 
            this.txtEncryptPassword.Location = new System.Drawing.Point(53, 294);
            this.txtEncryptPassword.Name = "txtEncryptPassword";
            this.txtEncryptPassword.Size = new System.Drawing.Size(292, 20);
            this.txtEncryptPassword.TabIndex = 4;
            this.txtEncryptPassword.TextChanged += new System.EventHandler(this.txtEncryptPassword_TextChanged);
            // 
            // btnBrowseEncrypt
            // 
            this.btnBrowseEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.btnBrowseEncrypt.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnBrowseEncrypt.Location = new System.Drawing.Point(53, 184);
            this.btnBrowseEncrypt.Name = "btnBrowseEncrypt";
            this.btnBrowseEncrypt.Size = new System.Drawing.Size(142, 34);
            this.btnBrowseEncrypt.TabIndex = 5;
            this.btnBrowseEncrypt.Text = "Browse Files";
            this.btnBrowseEncrypt.UseVisualStyleBackColor = false;
            this.btnBrowseEncrypt.Click += new System.EventHandler(this.btnBrowseEncrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnEncrypt.Location = new System.Drawing.Point(53, 320);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(142, 34);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt File";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnDecrypt.Location = new System.Drawing.Point(475, 320);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(142, 34);
            this.btnDecrypt.TabIndex = 13;
            this.btnDecrypt.Text = "Decrypt File";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnBrowseDecrypt
            // 
            this.btnBrowseDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.btnBrowseDecrypt.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnBrowseDecrypt.Location = new System.Drawing.Point(475, 184);
            this.btnBrowseDecrypt.Name = "btnBrowseDecrypt";
            this.btnBrowseDecrypt.Size = new System.Drawing.Size(142, 34);
            this.btnBrowseDecrypt.TabIndex = 12;
            this.btnBrowseDecrypt.Text = "Browse Files";
            this.btnBrowseDecrypt.UseVisualStyleBackColor = false;
            this.btnBrowseDecrypt.Click += new System.EventHandler(this.btnBrowseDecrypt_Click);
            // 
            // txtDecryptPassword
            // 
            this.txtDecryptPassword.Location = new System.Drawing.Point(475, 294);
            this.txtDecryptPassword.Name = "txtDecryptPassword";
            this.txtDecryptPassword.Size = new System.Drawing.Size(292, 20);
            this.txtDecryptPassword.TabIndex = 11;
            this.txtDecryptPassword.TextChanged += new System.EventHandler(this.txtDecryptPassword_TextChanged);
            // 
            // txtFileDecrypt
            // 
            this.txtFileDecrypt.Location = new System.Drawing.Point(475, 158);
            this.txtFileDecrypt.Name = "txtFileDecrypt";
            this.txtFileDecrypt.Size = new System.Drawing.Size(292, 20);
            this.txtFileDecrypt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.label4.Location = new System.Drawing.Point(616, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "confirm your encryption key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.label5.Location = new System.Drawing.Point(472, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select a file:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.label6.Location = new System.Drawing.Point(521, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 33);
            this.label6.TabIndex = 7;
            this.label6.Text = "Decrypt";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.panel1.Location = new System.Drawing.Point(409, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 369);
            this.panel1.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(816, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnBrowseDecrypt);
            this.Controls.Add(this.txtDecryptPassword);
            this.Controls.Add(this.txtFileDecrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnBrowseEncrypt);
            this.Controls.Add(this.txtEncryptPassword);
            this.Controls.Add(this.txtFileEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileEncrypt;
        private System.Windows.Forms.TextBox txtEncryptPassword;
        private System.Windows.Forms.Button btnBrowseEncrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnBrowseDecrypt;
        private System.Windows.Forms.TextBox txtDecryptPassword;
        private System.Windows.Forms.TextBox txtFileDecrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

