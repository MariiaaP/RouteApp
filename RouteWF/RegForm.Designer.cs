namespace RouteWF
{
    partial class RegForm
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
            this.labelsurname = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelrole = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSingIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelsurname
            // 
            this.labelsurname.AutoSize = true;
            this.labelsurname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsurname.Location = new System.Drawing.Point(0, 20);
            this.labelsurname.Name = "labelsurname";
            this.labelsurname.Size = new System.Drawing.Size(91, 24);
            this.labelsurname.TabIndex = 0;
            this.labelsurname.Text = "Surname";
            this.labelsurname.Click += new System.EventHandler(this.labelsurname_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(0, 74);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(63, 24);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "Name";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(0, 130);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(63, 24);
            this.labelemail.TabIndex = 2;
            this.labelemail.Text = "Email";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.Location = new System.Drawing.Point(0, 182);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(95, 24);
            this.labelpassword.TabIndex = 3;
            this.labelpassword.Text = "Password";
            // 
            // labelrole
            // 
            this.labelrole.AutoSize = true;
            this.labelrole.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrole.Location = new System.Drawing.Point(0, 236);
            this.labelrole.Name = "labelrole";
            this.labelrole.Size = new System.Drawing.Size(51, 24);
            this.labelrole.TabIndex = 4;
            this.labelrole.Text = "Role";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurname.Location = new System.Drawing.Point(107, 12);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(251, 30);
            this.textBoxSurname.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(107, 71);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(251, 30);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(107, 127);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(251, 30);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(107, 179);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(251, 30);
            this.textBoxPassword.TabIndex = 8;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "buyer",
            "seller"});
            this.comboBoxRole.Location = new System.Drawing.Point(107, 236);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(251, 32);
            this.comboBoxRole.TabIndex = 9;
            this.comboBoxRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxRole_SelectedIndexChanged);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(4, 302);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(112, 49);
            this.buttonRegister.TabIndex = 10;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(270, 302);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(118, 49);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSingIn
            // 
            this.buttonSingIn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSingIn.Location = new System.Drawing.Point(134, 302);
            this.buttonSingIn.Name = "buttonSingIn";
            this.buttonSingIn.Size = new System.Drawing.Size(118, 49);
            this.buttonSingIn.TabIndex = 12;
            this.buttonSingIn.Text = "Sing in";
            this.buttonSingIn.UseVisualStyleBackColor = true;
            this.buttonSingIn.Click += new System.EventHandler(this.buttonSingIn_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(400, 363);
            this.Controls.Add(this.buttonSingIn);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelrole);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.labelsurname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelsurname;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelrole;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSingIn;
    }
}