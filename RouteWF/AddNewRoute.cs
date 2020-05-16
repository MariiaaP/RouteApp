using System;
using Npgsql;
using System.Windows.Forms;

namespace RouteWF
{
    public partial class AddNewRoute : Form
    {
        public AddNewRoute()
        {
            InitializeComponent();
        }
        public AddNewRoute(string mes)
        {
            this.mess = mes;
            InitializeComponent();
        }
        private string mess;
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            new FormSellers().Show();
        }

        private NpgsqlConnection conn;
        string connstring = String.Format("Host=localhost;Port=5432;Database=practic;Username=postgres;Password=1111");
        private NpgsqlCommand cmd;
        private string sql = null;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"insert into routes values(@6, @start, @finish, @lenght, @price)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@6", NpgsqlTypes.NpgsqlDbType.Integer).Value = 7;
                cmd.Parameters.AddWithValue("@start", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Valid.if_word(textBoxStart.Text);
                cmd.Parameters.AddWithValue("@finish", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Valid.if_word(textBoxFinish.Text);
                cmd.Parameters.AddWithValue("@lenght", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Valid.if_len(textBoxLenght.Text);
                cmd.Parameters.AddWithValue("@price", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Valid.if_price(textBoxPrice.Text);
                
                string result = cmd.ExecuteScalar().ToString();
                conn.Close();

                if (result != null)
                {
                    this.Hide();
                    MessageBox.Show("Success", "Successful addition", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    new FormSellers().Show();
                }
                else
                {
                    MessageBox.Show("Please check your values", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Somth wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddNewRoute_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            label1.Text = mess;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
