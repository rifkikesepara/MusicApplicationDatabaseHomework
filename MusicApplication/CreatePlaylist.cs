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
    public partial class CreatePlaylist : Form
    {
        public static string? selectedPlaylist;
        private int playlistID;
        public CreatePlaylist()
        {
            InitializeComponent();
        }

        private void CreatePlaylist_Load(object sender, EventArgs e)
        {
            Form1.databaseConection.Open();
            if (Form1.state == PlaylistState.Create)
            {
                Text = "Create Playlist";
                NpgsqlCommand command = new NpgsqlCommand("SELECT s.song_name,s.release_date from songs as s", Form1.databaseConection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = reader.GetString(0);
                    listViewItem.SubItems.Add(reader[1].ToString());
                    songListView.Items.Add(listViewItem);
                }
            }
            else if (Form1.state == PlaylistState.Edit)
            {
                Text = "Edit Playlist";
                NpgsqlCommand command = new NpgsqlCommand("SELECT playlist_id FROM playlists WHERE name='"+selectedPlaylist+"'", Form1.databaseConection);
                var reader = command.ExecuteReader();
                reader.Read();
                playlistID = (int)reader[0];
                Form1.databaseConection.Close();


                Form1.databaseConection.Open();
                playlistNameBox.Text = selectedPlaylist;
                command = new NpgsqlCommand("SELECT s.song_name,s.release_date FROM playlist_song as ps INNER JOIN songs as s ON ps.song_id = s.song_id WHERE ps.playlist_id = "+playlistID, Form1.databaseConection);
                reader=command.ExecuteReader();
                while(reader.Read())
                {
                     ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text=reader.GetString(0);
                    listViewItem.SubItems.Add(reader[1].ToString());
                    playlistView.Items.Add(listViewItem);
                }
                Form1.databaseConection.Close();

                Form1.databaseConection.Open();
                command = new NpgsqlCommand("SELECT * FROM songs AS s WHERE s.song_id not IN (select ps.song_id FROM playlist_song as ps WHERE ps.playlist_id="+playlistID+")", Form1.databaseConection);
                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = reader.GetString(1);
                    listViewItem.SubItems.Add(reader[2].ToString());
                    songListView.Items.Add(listViewItem);
                }
            }

            Form1.databaseConection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem items in songListView.SelectedItems)
            {
                songListView.Items.Remove(items);
                playlistView.Items.Add(items);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem items in playlistView.SelectedItems)
            {
                playlistView.Items.Remove(items);
                songListView.Items.Add(items);
            }
        }

        private void savePlaylistButton_Click(object sender, EventArgs e)
        {
            if(Form1.state== PlaylistState.Create) 
            {
                InitPlaylist();
            }
            else if(Form1.state== PlaylistState.Edit)
            {
                EditPlaylist();
            }
            Form1.Instance.RefreshPlaylists();

        }

        private void songListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = songListView.SelectedItems[0];
            songListView.Items.Remove(item);
            playlistView.Items.Add(item);
        }

        private void playlistView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = playlistView.SelectedItems[0];
            playlistView.Items.Remove(item);
            songListView.Items.Add(item);
        }

        private void InitPlaylist()
        {
            Form1.databaseConection.Open();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO playlists(name,created_by) VALUES('" + playlistNameBox.Text + "'," + Form1.userID + ")", Form1.databaseConection);
            command.ExecuteNonQuery();
            Form1.databaseConection.Close();


            Form1.databaseConection.Open();

            command = new NpgsqlCommand("SELECT playlist_id FROM playlists WHERE name='"+playlistNameBox.Text+"'", Form1.databaseConection);
            var reader = command.ExecuteReader();
            reader.Read();
            int playlistID = (int)reader[0];//getting id of the playlist
            Form1.databaseConection.Close();


            foreach (ListViewItem items in playlistView.Items)
            {
                Form1.databaseConection.Open();
                command = new NpgsqlCommand("SELECT song_id FROM songs WHERE song_name='" + items.Text+"'", Form1.databaseConection);
                reader = command.ExecuteReader();
                reader.Read();
                int songID= (int)reader[0];
                Form1.databaseConection.Close();
                Form1.databaseConection.Open();

                command = new NpgsqlCommand("INSERT INTO playlist_song VALUES(" + songID + "," + playlistID+ ")", Form1.databaseConection);
                command.ExecuteNonQuery();
                Form1.databaseConection.Close();
            }


            MessageBox.Show("Playlist " + playlistNameBox.Text + " has been created");

            Close();
        }

        private void EditPlaylist()
        {
            Form1.databaseConection.Open();
            NpgsqlCommand command = new NpgsqlCommand("UPDATE playlists SET name='" + playlistNameBox.Text + "' WHERE name='"+selectedPlaylist+"'", Form1.databaseConection);
            command.ExecuteNonQuery();
            Form1.databaseConection.Close();

            Form1.databaseConection.Open();
            command = new NpgsqlCommand("DELETE FROM playlist_song WHERE playlist_id=" + playlistID, Form1.databaseConection);
            command.ExecuteNonQuery();
            Form1.databaseConection.Close();

            foreach (ListViewItem items in playlistView.Items)
            { 
                Form1.databaseConection.Open();
                command = new NpgsqlCommand("SELECT song_id FROM songs WHERE song_name='" + items.Text+"'", Form1.databaseConection);
                var reader = command.ExecuteReader();
                reader.Read();
                int songID= (int)reader[0];

                Form1.databaseConection.Close();
                Form1.databaseConection.Open();
                command = new NpgsqlCommand("INSERT INTO playlist_song VALUES(" + songID+ "," + playlistID+ ")", Form1.databaseConection);
                command.ExecuteNonQuery();
                Form1.databaseConection.Close();
            }

            MessageBox.Show("Playlist " + playlistNameBox.Text + " updated!");
            Close();
        }
    }
}
