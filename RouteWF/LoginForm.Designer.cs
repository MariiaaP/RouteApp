namespace RouteWF
{
    partial class LoginForm
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
            this.labelemail = new System.Windows.Forms.Label();
            this.labelpass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.buttonexit1 = new System.Windows.Forms.Button();
            this.registerbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(16, 15);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(60, 24);
            this.labelemail.TabIndex = 0;
            this.labelemail.Text = "email";
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpass.Location = new System.Drawing.Point(16, 59);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(94, 24);
            this.labelpass.TabIndex = 1;
            this.labelpass.Text = "password";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(118, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 30);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(118, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(258, 30);
            this.textBox2.TabIndex = 3;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Location = new System.Drawing.Point(20, 108);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(104, 50);
            this.buttonLogIn.TabIndex = 4;
            this.buttonLogIn.Text = "Log in";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonregister_Click);
            // 
            // buttonexit1
            // 
            this.buttonexit1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit1.Location = new System.Drawing.Point(272, 108);
            this.buttonexit1.Name = "buttonexit1";
            this.buttonexit1.Size = new System.Drawing.Size(104, 50);
            this.buttonexit1.TabIndex = 5;
            this.buttonexit1.Text = "Exit";
            this.buttonexit1.UseVisualStyleBackColor = true;
            this.buttonexit1.Click += new System.EventHandler(this.buttonexit1_Click);
            // 
            // registerbutton
            // 
            this.registerbutton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbutton.Location = new System.Drawing.Point(148, 107);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(104, 50);
            this.registerbutton.TabIndex = 6;
            this.registerbutton.Text = "Register";
            this.registerbutton.UseVisualStyleBackColor = true;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(400, 181);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.buttonexit1);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelpass);
            this.Controls.Add(this.labelemail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "RegLog";
            this.Load += new System.EventHandler(this.RegLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Button buttonexit1;
        private System.Windows.Forms.Button registerbutton;
    }
}