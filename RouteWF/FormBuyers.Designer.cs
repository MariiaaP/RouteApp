namespace RouteWF
{
    partial class FormBuyers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelHello = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Georgia", 20F);
            this.labelHello.Image = global::RouteWF.Properties.Resources.photo_2019_03_30_21_20_10;
            this.labelHello.Location = new System.Drawing.Point(147, 27);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(284, 39);
            this.labelHello.TabIndex = 0;
            this.labelHello.Text = "Hello, dear buyer ";
            this.labelHello.Click += new System.EventHandler(this.labelHello_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnStart,
            this.ColumnFinish,
            this.ColumnLenght,
            this.ColumnPrice});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(9, 98);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(783, 278);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "id";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnStart
            // 
            this.ColumnStart.HeaderText = "Start";
            this.ColumnStart.Name = "ColumnStart";
            this.ColumnStart.Width = 200;
            // 
            // ColumnFinish
            // 
            this.ColumnFinish.HeaderText = "Finish";
            this.ColumnFinish.Name = "ColumnFinish";
            this.ColumnFinish.Width = 200;
            // 
            // ColumnLenght
            // 
            this.ColumnLenght.HeaderText = "Lenght";
            this.ColumnLenght.Name = "ColumnLenght";
            this.ColumnLenght.Width = 120;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Price";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.Width = 120;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RouteWF.Properties.Resources.photo_2019_03_30_21_20_10;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.labelHello);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 436);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.White;
            this.buttonLogOut.BackgroundImage = global::RouteWF.Properties.Resources.photo_2019_03_30_21_20_10;
            this.buttonLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogOut.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogOut.Location = new System.Drawing.Point(671, 384);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(121, 42);
            this.buttonLogOut.TabIndex = 2;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // FormBuyers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 440);
            this.Controls.Add(this.panel1);
            this.Name = "FormBuyers";
            this.Text = "FormSeller";
            this.Load += new System.EventHandler(this.FormSeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogOut;
    }
}