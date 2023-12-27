using Npgsql;

namespace MusicApplication
{
    public enum PlaylistState
    {
        Create,Edit
    }
    public partial class Form1 : Form
    {
        public static Form1 Instance;

        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        public static NpgsqlConnection? databaseConection;
        public static bool Logged = false;
        public static string? userName;
        public static int? userID;
        public static PlaylistState? state;

        private void Form1_Load(object sender, EventArgs e)
        {
            logOutButton.Visible = false;
            ViewSongsbutton.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = false;
            playlistViewList.Visible = false;
            createPlaylistButton.Visible = false;
            usernameLabel.Text = userName;

            string strConnString = "Server=25.60.243.104;Port=5432;User Id=postgres;Password=password;Database=leetcode";
            try
            {
                databaseConection = new NpgsqlConnection(strConnString);
                //databaseConection.Open();
                //string strSelectCmd = "select * from users";
                ////NpgsqlDataAdapter objDataAdapter = new NpgsqlDataAdapter(strSelectCmd, databaseConnection);
                //// Define a query
                //NpgsqlCommand command = new NpgsqlCommand(strSelectCmd, databaseConection);

                //// Execute the query and obtain a result set
                //NpgsqlDataReader dr = command.ExecuteReader();

                //// Output rows
                //while (dr.Read())
                //{
                //    Console.Write("{0}\t{1} \n", dr[0], dr[1]);
                //}
                //databaseConection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoggedOut()
        {
            pictureBox1.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            label1.Visible = false;
            createPlaylistButton.Visible = false;
            playlistViewList.Visible = false;
            logOutButton.Visible = false;
            usernameLabel.Visible = false;
             ViewSongsbutton.Visible = false;

            Logged = false;
        }

        public void LoggedIn()
        {
            usernameLabel.Visible = true;
            ViewSongsbutton.Visible = true;
            logOutButton.Visible = true;
            pictureBox1.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = true;
            createPlaylistButton.Visible = true;
            playlistViewList.Visible = true;
            usernameLabel.Text = userName;

            RefreshPlaylists();

        }

        public void RefreshPlaylists()
        {
            playlistViewList.Items.Clear();
            databaseConection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT name FROM playlists WHERE created_by=" + userID, databaseConection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                playlistViewList.Items.Add(reader.GetString(0));
            }
            databaseConection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup signupFrom = new Signup();
            signupFrom.ShowDialog();
        }

        private void createPlaylistButton_Click(object sender, EventArgs e)
        {
            state = PlaylistState.Create;
            CreatePlaylist playlistForm = new CreatePlaylist();
            playlistForm.ShowDialog();
        }

        private void playlistViewList_DoubleClick(object sender, EventArgs e)
        {
            CreatePlaylist.selectedPlaylist = playlistViewList.SelectedItems[0].Text;
            state = PlaylistState.Edit;
            CreatePlaylist playlistForm = new CreatePlaylist();
            playlistForm.ShowDialog();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoggedOut();
        }

        private void ViewSongsbutton_Click(object sender, EventArgs e)
        {
            SongLists newForm=new SongLists();
            newForm.ShowDialog();
        }
    }
}
