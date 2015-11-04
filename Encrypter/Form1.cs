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
            Encrypt h = new Encrypt();
            Bitmap b = (Bitmap)Image.FromFile("C:/Users/victor.fernandes/Downloads/logo.jpg");
            for (int i = 0; i < b.Width; i++)
            {
                for(int j = 0;j<b.Height;j++)
                {
                    b.SetPixel(i, j, Color.FromArgb(h.getResultAfterCicles(b.GetPixel(i, j).R + 100),h.getResultAfterCicles(b.GetPixel(i, j).G + 100),h.getResultAfterCicles(b.GetPixel(i, j).B +100)));
                    Console.WriteLine(b.GetPixel(i, j).R.ToString() + b.GetPixel(i, j).G.ToString() + b.GetPixel(i, j).B.ToString());
                }
            }
            Image a = b;
            a.Save("hue.jpg");
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
