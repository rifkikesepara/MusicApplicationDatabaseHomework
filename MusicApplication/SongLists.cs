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

namespace MusicApplication
{
    public partial class SongLists : Form
    {
        public SongLists()
        {
            InitializeComponent();
        }

        private void SongLists_Load(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            playlistView.Items.Clear();
            Form1.databaseConection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM select_song_by_playlist_fn(" + idBox.Text + ")", Form1.databaseConection);
            var reader = command.ExecuteReader();

            while(reader.Read())
            {
                ListViewItem item=new ListViewItem();
                item.Text = reader.GetString(0);
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader.GetString(3));

                playlistView.Items.Add(item);
            }

            Form1.databaseConection.Close();
        }
    }
}
