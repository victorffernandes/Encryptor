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

        private void keyPress_PassWord(object sender, KeyPressEventArgs e)
        {
            string allowedChar = "ç:╪[{,.<>};~´!ùºúõó╫òªìíèéã/àázyx?wv]ut|srqpo#nmlk$jihgf%edcba¨0987&654A32*1§ÚÙÕ(ÒÓ\"\'ÌÍ)ÈÉÃÀÁ- ZYX_WVUTS+RQPON=MLKJIHGFE\\@DCB πσ┌³²";
            e.Handled = (allowedChar.IndexOf(e.KeyChar) == -1) ? true : false;
            e.Handled = (e.KeyChar == (char)8) ? false : e.Handled;

        }
    }
}
