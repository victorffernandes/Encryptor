namespace Encrypter
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
            this.displayEncrypt = new System.Windows.Forms.TextBox();
            this.userUnEncrypt = new System.Windows.Forms.TextBox();
            this.displayUnEncrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.userEncrypt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // displayEncrypt
            // 
            this.displayEncrypt.HideSelection = false;
            this.displayEncrypt.Location = new System.Drawing.Point(396, 31);
            this.displayEncrypt.Multiline = true;
            this.displayEncrypt.Name = "displayEncrypt";
            this.displayEncrypt.Size = new System.Drawing.Size(221, 149);
            this.displayEncrypt.TabIndex = 1;
            this.displayEncrypt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.evaluateString);
            // 
            // userUnEncrypt
            // 
            this.userUnEncrypt.HideSelection = false;
            this.userUnEncrypt.Location = new System.Drawing.Point(12, 186);
            this.userUnEncrypt.Multiline = true;
            this.userUnEncrypt.Name = "userUnEncrypt";
            this.userUnEncrypt.Size = new System.Drawing.Size(224, 149);
            this.userUnEncrypt.TabIndex = 2;
            this.userUnEncrypt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.evaluateString);
            // 
            // displayUnEncrypt
            // 
            this.displayUnEncrypt.HideSelection = false;
            this.displayUnEncrypt.Location = new System.Drawing.Point(396, 186);
            this.displayUnEncrypt.Multiline = true;
            this.displayUnEncrypt.Name = "displayUnEncrypt";
            this.displayUnEncrypt.Size = new System.Drawing.Size(224, 149);
            this.displayUnEncrypt.TabIndex = 3;
            this.displayUnEncrypt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.evaluateString);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(242, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "--> Encrypt -->";
            this.label1.Click += new System.EventHandler(this.encrypt_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "--> Decrypt-->";
            this.label2.Click += new System.EventHandler(this.unEncrypt_click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Key:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Key:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.evaluateString);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.evaluateString);
            // 
            // userEncrypt
            // 
            this.userEncrypt.Location = new System.Drawing.Point(12, 33);
            this.userEncrypt.Multiline = true;
            this.userEncrypt.Name = "userEncrypt";
            this.userEncrypt.Size = new System.Drawing.Size(224, 147);
            this.userEncrypt.TabIndex = 12;
            this.userEncrypt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.evaluateString);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 355);
            this.Controls.Add(this.userEncrypt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayUnEncrypt);
            this.Controls.Add(this.userUnEncrypt);
            this.Controls.Add(this.displayEncrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayEncrypt;
        private System.Windows.Forms.TextBox userUnEncrypt;
        private System.Windows.Forms.TextBox displayUnEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox userEncrypt;
    }
}

