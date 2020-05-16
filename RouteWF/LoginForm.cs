using System;
using Npgsql;
using System.Windows.Forms;
using System.Threading;

namespace RouteWF
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        private void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        private NpgsqlConnection conn;
        string connstring = String.Format("Host=localhost;Port=5432;Database=practic;Username=postgres;Password=1111");
        private NpgsqlCommand cmd;
        private string sql = null;
        
        private void buttonexit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from u_login(:_email, :_password)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_email", Valid.if_email(textBox1.Text));
                cmd.Parameters.AddWithValue("_password", Valid.if_password(textBox2.Text));
                int result = (int)cmd.ExecuteScalar();

                conn.Close();

                if (result == 1) 
                {
                    this.Hide();
                    new FormSellers(textBox1.Text).Show();
                    //sql = @"select * from users where email="
                }
                else
                {
                    //MessageBox.Show("Please check your email and password", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Somth wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void RegLog_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegForm().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
