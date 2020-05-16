using System;
using Npgsql;
using System.Windows.Forms;
using System.Collections.Generic;

namespace RouteWF
{
    public partial class FormBuyers : Form
    {
        private NpgsqlConnection conn;
        string connstring = String.Format("Host=localhost;Port=5432;Database=practic;Username=postgres;Password=1111");
        private NpgsqlCommand cmd;
        private string sql = null;
        private string username;

        public FormBuyers(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        public FormBuyers()
        {
            InitializeComponent();
        }

        private void FormSeller_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            labelHello.Text = labelHello.Text + username;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelHello_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
