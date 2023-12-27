using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MusicApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form1.databaseConection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT u.username,u.password,u.user_id from users as u", Form1.databaseConection);
            var reader = command.ExecuteReader();
            while(reader.Read())
            {
                if (usernameBox.Text == reader[0].ToString() && passwordBox.Text == reader[1].ToString()) 
                {
                    Form1.userID = (int)reader[2];
                    Form1.Logged = true;
                    break;
                }
            }
            Form1.databaseConection.Close();

            if (Form1.Logged)
            {
                MessageBox.Show("Logged In");
                Form1.userName = usernameBox.Text;
                Form1.Instance.LoggedIn();
                Close();
            }
            else
                MessageBox.Show("Failed to logged in.");

        }
    }
}
