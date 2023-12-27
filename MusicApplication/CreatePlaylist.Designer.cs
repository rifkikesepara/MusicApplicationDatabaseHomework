namespace MusicApplication
{
    partial class CreatePlaylist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePlaylist));
            songListView = new ListView();
            SongName = new ColumnHeader();
            ReleaseDate = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            playlistView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            playlistNameBox = new TextBox();
            savePlaylistButton = new Button();
            SuspendLayout();
            // 
            // songListView
            // 
            songListView.Columns.AddRange(new ColumnHeader[] { SongName, ReleaseDate });
            songListView.Location = new Point(41, 39);
            songListView.Name = "songListView";
            songListView.Size = new Size(272, 370);
            songListView.TabIndex = 0;
            songListView.UseCompatibleStateImageBehavior = false;
            songListView.View = View.Details;
            songListView.MouseDoubleClick += songListView_MouseDoubleClick;
            // 
            // SongName
            // 
            SongName.Text = "Name";
            SongName.Width = 90;
            // 
            // ReleaseDate
            // 
            ReleaseDate.Text = "ReleaseDate";
            ReleaseDate.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 21);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Songs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(631, 21);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Playlist";
            // 
            // playlistView
            // 
            playlistView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            playlistView.Location = new Point(516, 39);
            playlistView.Name = "playlistView";
            playlistView.Size = new Size(272, 370);
            playlistView.TabIndex = 3;
            playlistView.UseCompatibleStateImageBehavior = false;
            playlistView.View = View.Details;
            playlistView.MouseDoubleClick += playlistView_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ReleaseDate";
            columnHeader2.Width = 100;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(380, 147);
            button1.Name = "button1";
            button1.Size = new Size(75, 54);
            button1.TabIndex = 4;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(380, 230);
            button2.Name = "button2";
            button2.Size = new Size(75, 54);
            button2.TabIndex = 4;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // playlistNameBox
            // 
            playlistNameBox.Font = new Font("Segoe UI", 20F);
            playlistNameBox.Location = new Point(332, 21);
            playlistNameBox.Name = "playlistNameBox";
            playlistNameBox.PlaceholderText = "Playlist Name";
            playlistNameBox.Size = new Size(168, 43);
            playlistNameBox.TabIndex = 5;
            // 
            // savePlaylistButton
            // 
            savePlaylistButton.Font = new Font("Segoe UI", 10F);
            savePlaylistButton.Location = new Point(354, 350);
            savePlaylistButton.Name = "savePlaylistButton";
            savePlaylistButton.Size = new Size(128, 59);
            savePlaylistButton.TabIndex = 6;
            savePlaylistButton.Text = "Save Playlist";
            savePlaylistButton.UseVisualStyleBackColor = true;
            savePlaylistButton.Click += savePlaylistButton_Click;
            // 
            // CreatePlaylist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(savePlaylistButton);
            Controls.Add(playlistNameBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(playlistView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(songListView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CreatePlaylist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreatePlaylist";
            Load += CreatePlaylist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView songListView;
        private ColumnHeader SongName;
        private ColumnHeader ReleaseDate;
        private Label label1;
        private Label label2;
        private ListView playlistView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button1;
        private Button button2;
        private TextBox playlistNameBox;
        private Button savePlaylistButton;
    }
}