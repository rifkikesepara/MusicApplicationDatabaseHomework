namespace MusicApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            usernameLabel = new Label();
            createPlaylistButton = new Button();
            playlistViewList = new ListView();
            label1 = new Label();
            logOutButton = new Button();
            pictureBox1 = new PictureBox();
            ViewSongsbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(423, 189);
            button1.Name = "button1";
            button1.Size = new Size(136, 73);
            button1.TabIndex = 0;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(247, 189);
            button2.Name = "button2";
            button2.Size = new Size(136, 73);
            button2.TabIndex = 0;
            button2.Text = "SIGNUP";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 20F);
            usernameLabel.Location = new Point(698, 9);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(90, 37);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "label1";
            // 
            // createPlaylistButton
            // 
            createPlaylistButton.Location = new Point(330, 9);
            createPlaylistButton.Name = "createPlaylistButton";
            createPlaylistButton.Size = new Size(136, 73);
            createPlaylistButton.TabIndex = 6;
            createPlaylistButton.Text = "Create Playlist";
            createPlaylistButton.UseVisualStyleBackColor = true;
            createPlaylistButton.Click += createPlaylistButton_Click;
            // 
            // playlistViewList
            // 
            playlistViewList.Location = new Point(312, 158);
            playlistViewList.Name = "playlistViewList";
            playlistViewList.Size = new Size(189, 207);
            playlistViewList.TabIndex = 8;
            playlistViewList.UseCompatibleStateImageBehavior = false;
            playlistViewList.View = View.List;
            playlistViewList.DoubleClick += playlistViewList_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(339, 118);
            label1.Name = "label1";
            label1.Size = new Size(137, 37);
            label1.TabIndex = 9;
            label1.Text = "PLAYLISTS";
            // 
            // logOutButton
            // 
            logOutButton.Location = new Point(698, 49);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(90, 36);
            logOutButton.TabIndex = 11;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Görsel_2023_12_24_saat_16_12_47_2bf76529;
            pictureBox1.Location = new Point(618, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // ViewSongsbutton
            // 
            ViewSongsbutton.Location = new Point(12, 16);
            ViewSongsbutton.Name = "ViewSongsbutton";
            ViewSongsbutton.Size = new Size(105, 59);
            ViewSongsbutton.TabIndex = 13;
            ViewSongsbutton.Text = "View Songs";
            ViewSongsbutton.UseVisualStyleBackColor = true;
            ViewSongsbutton.Click += ViewSongsbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ViewSongsbutton);
            Controls.Add(playlistViewList);
            Controls.Add(pictureBox1);
            Controls.Add(logOutButton);
            Controls.Add(label1);
            Controls.Add(createPlaylistButton);
            Controls.Add(usernameLabel);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "MusicApplication";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label usernameLabel;
        private Button createPlaylistButton;
        private ListView playlistViewList;
        private Label label1;
        private Button logOutButton;
        private PictureBox pictureBox1;
        private Button ViewSongsbutton;
    }
}
