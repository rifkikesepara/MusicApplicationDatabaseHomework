using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApplication
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            Form1.databaseConection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT countryname from countries", Form1.databaseConection);
            var reader = command.ExecuteReader();

            while(reader.Read())
            {
                countryComboBox.Items.Add(reader[0]);
            }

            Form1.databaseConection.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Form1.databaseConection.Open();
            var date = datePicker.Value;

            int selectedCountry = countryComboBox.SelectedIndex + 1;

            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO users(username,email,password,birthday,country_id) VALUES('"+usernameBox.Text+"','"+emailBox.Text+"','"+passwordBox.Text+"','"+date.Year.ToString()+"-"+date.Month.ToString()+"-"+date.Day.ToString()+"',"+selectedCountry+")", Form1.databaseConection);
            command.ExecuteNonQuery();
            Form1.databaseConection.Close();
            MessageBox.Show("Successfully signed up!");
            this.Close();
        }
    }
}
