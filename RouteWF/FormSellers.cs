using Npgsql;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace RouteWF
{
    public partial class FormSellers : Form
    {
        private NpgsqlConnection conn;
        string connstring = String.Format("Host=localhost;Port=5432;Database=practic;Username=postgres;Password=1111");
        private NpgsqlCommand cmd;
        private string sql = null;

        public FormSellers(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        public FormSellers()
        {
            InitializeComponent();
        }

        private void labelhello_Click(object sender, EventArgs e)
        {

        }

        private string username;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            labelhello.Text = labelhello.Text + username;
            try
            {
                conn.Open();
                sql = @"select * from routes";
                cmd = new NpgsqlCommand(sql, conn);
                int result = (int)cmd.ExecuteScalar();
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (result == 1)
                {
                    List<string[]> data = new List<string[]>();

                    while (reader.Read())
                    {
                        data.Add(new string[5]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                    }
                    reader.Close();
                    conn.Close();

                    foreach (string[] s in data)
                    {
                        dataGridView1.Rows.Add(s);
                    }
                }
                else
                {
                    MessageBox.Show("Error", "Check code", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Somth wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void buttonAddNewRoute_Click(object sender, EventArgs e)
        {
            new AddNewRoute("Input new route:").Show();
        }

        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            var res = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res==DialogResult.No)
            {
                new FormSellers().Show();
            }
            else dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRow = dataGridView1.Rows[selectedRow];
            newRow.Cells[0].Value = textBoxWorkId.Text;
            newRow.Cells[1].Value = Valid.if_word(textBoxWorkStart.Text);
            newRow.Cells[2].Value = Valid.if_word(textBoxWorkFinish.Text);
            newRow.Cells[3].Value = Valid.if_len(textBoxWorkLenght.Text);
            newRow.Cells[4].Value = Valid.if_price(textBoxWorkPrice.Text);
        }

        int selectedRow;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            textBoxWorkId.Text = row.Cells[0].Value.ToString();
            textBoxWorkStart.Text = row.Cells[1].Value.ToString();
            textBoxWorkFinish.Text = row.Cells[2].Value.ToString();
            textBoxWorkLenght.Text = row.Cells[3].Value.ToString();
            textBoxWorkPrice.Text = row.Cells[4].Value.ToString();
        }

        //DataTable dbdataset;
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //DataView dv = new DataView(dbdataset);
            //dv.RowFilter = string.Format("start LIKE '%{0}%'", textBoxSearch.Text);
            //dataGridView1.DataSource = dv;
        }

        public void searchR(string val)
        {
            string c = "SELECT * FROM routes WHERE concat(route_id,start,finish,lenght,price) like'%" + val + "%'";
            cmd = new NpgsqlCommand(c, conn);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string val = textBoxSearch.Text.ToString();
                searchR(val);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Can`t search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void buttonSearch_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxSort.Text);
            dataGridView1.Sort(dataGridView1.Columns[n], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void textBoxSort_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxSort.Text = "input index of column";
        }

        private void textBoxSort_MouseHover(object sender, EventArgs e)
        {
            textBoxSort.Text = "input index of column";
        }

        private void textBoxSort_MouseLeave(object sender, EventArgs e)
        {
            textBoxSort.Text = "";
        }
    }
}
