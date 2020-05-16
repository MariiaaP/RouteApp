using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RouteWF
{
    class Valid
    {
        public static string if_word(string var)
        {
            if (!Regex.IsMatch(var, @"^[a-z]*$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Error: ", "Wrong text", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                new RegForm().Show();
            }
            return var;
        }
        public static double if_price(string var)
        {
            if (!double.TryParse(var, out double result))
            {
                MessageBox.Show("Error: ", "Wrong price", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                new AddNewRoute().Show();
                return 0;
            }
            else return result;
        }
        public static double if_len(string var)
        {
            if (!double.TryParse(var, out double result))
            {
                MessageBox.Show("Error: ", "Wrong lenght", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //new AddNewRoute().Show();
            }
            return result;
        }
        public static string if_email(string email)
        {
            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Error: ", "Check your email", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                new RegForm().Show();
            }
            return email;
        }
        public static string if_password(string password)
        {
            if (!(password.Contains(@"^[a-z]*$") || !(password.Contains(@"^[0-9]*$") )|| password.Length <= 8))
            {
                MessageBox.Show("Error: ", "Check your password", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                new RegForm().Show();
            }
            return password;
        }
        public static string if_role(string role)
        {
            if (role != "seller" && role != "buyer")
            {
                MessageBox.Show("Error: ", "Check your role", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                new RegForm().Show();
            }
            return role;
        }

        public static Regex stringToParse { get; private set; } = new Regex(".+[ ].+[ ].+[ ].+[ ].+ ");

        public static string ValidationToParse(string strToParse)
        {
            while (!stringToParse.IsMatch(strToParse))
            {
                throw new Exception("Wrong input...");
            }
            return strToParse;
        }
    }
}
