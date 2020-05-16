using Npgsql;
using System;
using System.Windows.Forms;

namespace RouteWF
{
    public partial class RegForm : Form
    {
        private NpgsqlConnection conne;
        string connstring = String.Format("Host=localhost;Port=5432;Database=practic;Username=postgres;Password=1111");
        private NpgsqlCommand cmd;
        private string sql = null;

        public RegForm()
        {
            InitializeComponent();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSingIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                conne.Open();
                sql = @"select * from regist_u(@surname, @name, @email, @password, @role)";
                
                cmd = new NpgsqlCommand(sql, conne);

                cmd.Parameters.AddWithValue("@surname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Valid.if_word(textBoxSurname.Text);
                cmd.Parameters.AddWithValue("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Valid.if_word(textBoxName.Text);
                cmd.Parameters.AddWithValue("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Valid.if_email(textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@password", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Valid.if_password(textBoxPassword.Text);
                cmd.Parameters.AddWithValue("@role", NpgsqlTypes.NpgsqlDbType.Integer).Value = Valid.if_role(comboBoxRole.Text);

                int result = (int)cmd.ExecuteScalar();

                conne.Close();

                if (result == 1)
                {
                    this.Hide();
                    MessageBox.Show("Welcome", "Successful registration", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (comboBoxRole.Text == "buyer")
                    {
                        new FormBuyers(textBoxName.Text).Show();
                    }
                    else if (comboBoxRole.Text=="seller")
                    {
                        new FormSellers(textBoxName.Text).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please check your email and password", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Somth wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conne.Close();
            }
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            conne = new NpgsqlConnection(connstring);
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelsurname_Click(object sender, EventArgs e)
        {

        }
    }
}
