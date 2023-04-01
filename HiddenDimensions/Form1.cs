using System;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiddenDimensions
{
    public partial class Form1 : Form
    {
        private string inputFileLocation;
        private string outputFileLocation;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Hidden Dimension";
        }

        public static byte[] EncryptStringToBytes_Aes(string plainText, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        return msEncrypt.ToArray();
                    }
                }
            }
        }

        public static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputFileLocation))
            {
                MessageBox.Show("Please select a file to decrypt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string password = txtDecryptPassword.Text;

            // Generate a key and IV from the password
            using (var derivedBytes = new Rfc2898DeriveBytes(password, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 }, 10000))
            {
                byte[] key = derivedBytes.GetBytes(32); // AES-256 key size
                byte[] iv = derivedBytes.GetBytes(16); // AES block size

                // Read the encrypted file
                byte[] encryptedBytes = File.ReadAllBytes(inputFileLocation);

                // Decrypt the content
                string decryptedText = DecryptStringFromBytes_Aes(encryptedBytes, key, iv);

                // Display the decrypted content in a new TextBox control
                var textBox = new TextBox();
                textBox.Dock = DockStyle.Fill;
                textBox.Multiline = true;
                textBox.ReadOnly = true;
                textBox.BackColor = Color.FromArgb(0x30, 0x30, 0x30);
                textBox.ForeColor = Color.FromArgb(0xba, 0xcd, 0xdb);
                textBox.Font = new Font("Palatino Linotype", 10, FontStyle.Bold);
                textBox.Text = decryptedText;
                textBox.SelectionStart = 0;
                textBox.SelectionLength = 0;
                textBox.Padding = new Padding(10, 0, 0, 0); // add a left padding of 10 pixels
                textBox.ScrollBars = ScrollBars.Vertical; // enable vertical scrollbar

                var form = new Form();
                form.Controls.Add(textBox);
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
        }

        private void btnBrowseDecrypt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Encrypted Files (*.hd)|*.hd|All Files (*.*)|*.*";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFileLocation = openFileDialog.FileName;
                    txtFileDecrypt.Text = inputFileLocation;
                }
            }
        }

        private void txtDecryptPassword_TextChanged(object sender, EventArgs e)
        {
            btnDecrypt.Enabled = !string.IsNullOrEmpty(txtDecryptPassword.Text);
        }

        private void txtEncryptPassword_TextChanged(object sender, EventArgs e)
        {
            btnEncrypt.Enabled = !string.IsNullOrEmpty(txtEncryptPassword.Text);
        }

        private void btnBrowseEncrypt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|Word Documents (*.docx)|*.docx|All Files (*.*)|*.*";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFileLocation = openFileDialog.FileName;
                    txtFileEncrypt.Text = inputFileLocation;
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputFileLocation))
            {
                MessageBox.Show("Please select a file to encrypt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string password = txtEncryptPassword.Text;

            // Generate a key and IV from the password
            using (var derivedBytes = new Rfc2898DeriveBytes(password, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 }, 10000))
            {
                byte[] key = derivedBytes.GetBytes(32); // AES-256 key size
                byte[] iv = derivedBytes.GetBytes(16); // AES block size

                // Read the input file
                string plainText = File.ReadAllText(inputFileLocation);

                // Encrypt the content
                byte[] encryptedBytes = EncryptStringToBytes_Aes(plainText, key, iv);

                // Save the encrypted content to a new file
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Encrypted Files (*.hd)|*.hd|All Files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        outputFileLocation = saveFileDialog.FileName;
                        File.WriteAllBytes(outputFileLocation, encryptedBytes);
                        MessageBox.Show("Encryption completed. Hidden Dimension File saved successfully!.");
                    }
                }
            }
        }
    }
}
