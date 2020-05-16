namespace RouteWF
{
    partial class FormSellers
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
            this.labelhello = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSort = new System.Windows.Forms.Button();
            this.textBoxSort = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxWorkPrice = new System.Windows.Forms.TextBox();
            this.textBoxWorkLenght = new System.Windows.Forms.TextBox();
            this.textBoxWorkFinish = new System.Windows.Forms.TextBox();
            this.textBoxWorkStart = new System.Windows.Forms.TextBox();
            this.textBoxWorkId = new System.Windows.Forms.TextBox();
            this.labelWorkPrice = new System.Windows.Forms.Label();
            this.labelWorkLenght = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelWorkStart = new System.Windows.Forms.Label();
            this.labelWorkId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDeleteRow = new System.Windows.Forms.Button();
            this.buttonAddNewRoute = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelhello
            // 
            this.labelhello.AutoSize = true;
            this.labelhello.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelhello.Font = new System.Drawing.Font("Georgia", 20F);
            this.labelhello.Image = global::RouteWF.Properties.Resources.photo_2019_03_30_21_20_10;
            this.labelhello.Location = new System.Drawing.Point(4, 0);
            this.labelhello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelhello.Name = "labelhello";
            this.labelhello.Size = new System.Drawing.Size(280, 39);
            this.labelhello.TabIndex = 0;
            this.labelhello.Text = "Hello, dear seller ";
            this.labelhello.Click += new System.EventHandler(this.labelhello_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnStart,
            this.ColumnFinish,
            this.ColumnLenght,
            this.ColumnPrice});
            this.dataGridView1.Location = new System.Drawing.Point(4, 303);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(900, 255);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RouteWF.Properties.Resources.photo_2019_03_30_21_20_10;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.buttonSort);
            this.panel1.Controls.Add(this.textBoxSort);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.textBoxWorkPrice);
            this.panel1.Controls.Add(this.textBoxWorkLenght);
            this.panel1.Controls.Add(this.textBoxWorkFinish);
            this.panel1.Controls.Add(this.textBoxWorkStart);
            this.panel1.Controls.Add(this.textBoxWorkId);
            this.panel1.Controls.Add(this.labelWorkPrice);
            this.panel1.Controls.Add(this.labelWorkLenght);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelWorkStart);
            this.panel1.Controls.Add(this.labelWorkId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonDeleteRow);
            this.panel1.Controls.Add(this.buttonAddNewRoute);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.labelhello);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 562);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.Gray;
            this.buttonSort.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonSort.Location = new System.Drawing.Point(536, 63);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(128, 50);
            this.buttonSort.TabIndex = 20;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // textBoxSort
            // 
            this.textBoxSort.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSort.Location = new System.Drawing.Point(507, 29);
            this.textBoxSort.Name = "textBoxSort";
            this.textBoxSort.Size = new System.Drawing.Size(157, 27);
            this.textBoxSort.TabIndex = 19;
            this.textBoxSort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxSort_MouseDown);
            this.textBoxSort.MouseLeave += new System.EventHandler(this.textBoxSort_MouseLeave);
            this.textBoxSort.MouseHover += new System.EventHandler(this.textBoxSort_MouseHover);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Gray;
            this.buttonSearch.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonSearch.Location = new System.Drawing.Point(776, 63);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(128, 50);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            this.buttonSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSearch_MouseClick);
            // 
            // textBoxWorkPrice
            // 
            this.textBoxWorkPrice.Font = new System.Drawing.Font("Georgia", 15F);
            this.textBoxWorkPrice.Location = new System.Drawing.Point(747, 163);
            this.textBoxWorkPrice.Name = "textBoxWorkPrice";
            this.textBoxWorkPrice.Size = new System.Drawing.Size(157, 36);
            this.textBoxWorkPrice.TabIndex = 17;
            // 
            // textBoxWorkLenght
            // 
            this.textBoxWorkLenght.Font = new System.Drawing.Font("Georgia", 15F);
            this.textBoxWorkLenght.Location = new System.Drawing.Point(585, 163);
            this.textBoxWorkLenght.Name = "textBoxWorkLenght";
            this.textBoxWorkLenght.Size = new System.Drawing.Size(156, 36);
            this.textBoxWorkLenght.TabIndex = 16;
            // 
            // textBoxWorkFinish
            // 
            this.textBoxWorkFinish.Font = new System.Drawing.Font("Georgia", 15F);
            this.textBoxWorkFinish.Location = new System.Drawing.Point(343, 163);
            this.textBoxWorkFinish.Name = "textBoxWorkFinish";
            this.textBoxWorkFinish.Size = new System.Drawing.Size(239, 36);
            this.textBoxWorkFinish.TabIndex = 15;
            // 
            // textBoxWorkStart
            // 
            this.textBoxWorkStart.Font = new System.Drawing.Font("Georgia", 15F);
            this.textBoxWorkStart.Location = new System.Drawing.Point(112, 163);
            this.textBoxWorkStart.Name = "textBoxWorkStart";
            this.textBoxWorkStart.Size = new System.Drawing.Size(225, 36);
            this.textBoxWorkStart.TabIndex = 14;
            // 
            // textBoxWorkId
            // 
            this.textBoxWorkId.Font = new System.Drawing.Font("Georgia", 15F);
            this.textBoxWorkId.Location = new System.Drawing.Point(14, 163);
            this.textBoxWorkId.Name = "textBoxWorkId";
            this.textBoxWorkId.Size = new System.Drawing.Size(92, 36);
            this.textBoxWorkId.TabIndex = 13;
            // 
            // labelWorkPrice
            // 
            this.labelWorkPrice.AutoSize = true;
            this.labelWorkPrice.Font = new System.Drawing.Font("Georgia", 15F);
            this.labelWorkPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelWorkPrice.Image = global::RouteWF.Properties.Resources.photo_2019_03_30_21_20_10;
            this.labelWorkPrice.Location = new System.Drawing.Point(742, 130);
            this.labelWorkPrice.Name = "labelWorkPrice";
            this.labelWorkPrice.Size = new System.Drawing.Size(67, 30);
            this.labelWorkPrice.TabIndex = 12;
            this.labelWorkPrice.Text = "price";
            // 
            // labelWorkLenght
            // 
            this.labelWorkLenght.AutoSize = true;
            this.labelWorkLenght.Font = new System.Drawing.Font("Georgia", 15F);
            this.labelWorkLenght.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelWorkLenght.Image = global::RouteWF.Properties.Resources.photo_2019_03_30_21_20_10;
            this.labelWorkLenght.Location = new System.Drawing.Point(580, 130);
            this.labelWorkLenght.Name = "labelWorkLenght";
            this.labelWorkLenght.Size = new System.Drawing.Size(84, 30);
            this.labelWorkLenght.TabIndex = 11;
            this.labelWorkLenght.Text = "lenght";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 15F);
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Image = global::RouteWF.Properties.Resources.photo_2019_03_30_21_20_10;
            this.label4.Location = new System.Drawing.Point(338, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "finish";
            // 
            // labelWorkStart
            // 
            this.labelWorkStart.AutoSize = true;
            this.labelWorkStart.Font = new System.Drawing.Font("Georgia", 15F);
            this.labelWorkStart.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelWorkStart.Image = global::RouteWF.Properties.Resources.photo_2019_03_30_21_20_10;
            this.labelWorkStart.Location = new System.Drawing.Point(107, 130);
            this.labelWorkStart.Name = "labelWorkStart";
            this.labelWorkStart.Size = new System.Drawing.Size(65, 30);
            this.labelWorkStart.TabIndex = 9;
            this.labelWorkStart.Text = "start";
            // 
            // labelWorkId
            // 
            this.labelWorkId.AutoSize = true;
            this.labelWorkId.Font = new System.Drawing.Font("Georgia", 15F);
            this.labelWorkId.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelWorkId.Image = global::RouteWF.Properties.Resources.photo_2019_03_30_21_20_10;
            this.labelWorkId.Location = new System.Drawing.Point(19, 130);
            this.labelWorkId.Name = "labelWorkId";
            this.labelWorkId.Size = new System.Drawing.Size(34, 30);
            this.labelWorkId.TabIndex = 8;
            this.labelWorkId.Text = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15F);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Image = global::RouteWF.Properties.Resources.photo_2019_03_30_21_20_10;
            this.label1.Location = new System.Drawing.Point(19, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selected item:";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Gray;
            this.buttonEdit.Font = new System.Drawing.Font("Georgia", 15F);
            this.buttonEdit.Location = new System.Drawing.Point(638, 231);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(257, 65);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit row";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDeleteRow
            // 
            this.buttonDeleteRow.BackColor = System.Drawing.Color.Gray;
            this.buttonDeleteRow.Font = new System.Drawing.Font("Georgia", 15F);
            this.buttonDeleteRow.Location = new System.Drawing.Point(325, 231);
            this.buttonDeleteRow.Name = "buttonDeleteRow";
            this.buttonDeleteRow.Size = new System.Drawing.Size(257, 65);
            this.buttonDeleteRow.TabIndex = 5;
            this.buttonDeleteRow.Text = "Delete row";
            this.buttonDeleteRow.UseVisualStyleBackColor = false;
            this.buttonDeleteRow.Click += new System.EventHandler(this.buttonDeleteRow_Click);
            // 
            // buttonAddNewRoute
            // 
            this.buttonAddNewRoute.BackColor = System.Drawing.Color.Gray;
            this.buttonAddNewRoute.Font = new System.Drawing.Font("Georgia", 15F);
            this.buttonAddNewRoute.Location = new System.Drawing.Point(14, 231);
            this.buttonAddNewRoute.Name = "buttonAddNewRoute";
            this.buttonAddNewRoute.Size = new System.Drawing.Size(257, 65);
            this.buttonAddNewRoute.TabIndex = 4;
            this.buttonAddNewRoute.Text = "Add new route";
            this.buttonAddNewRoute.UseVisualStyleBackColor = false;
            this.buttonAddNewRoute.Click += new System.EventHandler(this.buttonAddNewRoute_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Georgia", 15F);
            this.textBoxSearch.Location = new System.Drawing.Point(706, 21);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(198, 36);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "route_id";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnStart
            // 
            this.ColumnStart.HeaderText = "start";
            this.ColumnStart.Name = "ColumnStart";
            // 
            // ColumnFinish
            // 
            this.ColumnFinish.HeaderText = "finish";
            this.ColumnFinish.Name = "ColumnFinish";
            // 
            // ColumnLenght
            // 
            this.ColumnLenght.HeaderText = "lenght";
            this.ColumnLenght.Name = "ColumnLenght";
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "price";
            this.ColumnPrice.Name = "ColumnPrice";
            // 
            // FormSellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 577);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSellers";
            this.Text = "Route table for sellers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelhello;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddNewRoute;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonDeleteRow;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxWorkPrice;
        private System.Windows.Forms.TextBox textBoxWorkLenght;
        private System.Windows.Forms.TextBox textBoxWorkFinish;
        private System.Windows.Forms.TextBox textBoxWorkStart;
        private System.Windows.Forms.TextBox textBoxWorkId;
        private System.Windows.Forms.Label labelWorkPrice;
        private System.Windows.Forms.Label labelWorkLenght;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelWorkStart;
        private System.Windows.Forms.Label labelWorkId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.TextBox textBoxSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
    }
}

