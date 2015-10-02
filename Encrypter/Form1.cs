using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypter
{
    public partial class Form1 : Form
    {
        string keyE = "";
        string keyU = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            keyE = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            keyU = textBox2.Text;
        }

        private void encrypt_click(object sender, EventArgs e)
        {
            lock (this)
            {
                if (!string.IsNullOrEmpty(keyE))
                {
                    Encrypt c = new Encrypt();
                    displayEncrypt.Text = c.encryptUsingKey(keyE, userEncrypt.Text);
                }
            }
            
        }
        
        private void unEncrypt_click(object sender, EventArgs e)
        {
            lock (this)
            {
                if (!string.IsNullOrEmpty(keyU))
                {
                    Encrypt c = new Encrypt();
                    displayUnEncrypt.Text = c.decryptUsingKey(keyU, userUnEncrypt.Text);
                }
            }
        }
        private void evaluateString(object sender, KeyPressEventArgs e)
        {
            Encrypt c = new Encrypt();
            e.Handled = (c.al.IndexOf(e.KeyChar) == -1 && (e.KeyChar != (char)8));
        }
    }
}
