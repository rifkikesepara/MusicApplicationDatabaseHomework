namespace MusicApplication
{
    partial class SongLists
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
            playlistView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            idBox = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // playlistView
            // 
            playlistView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            playlistView.Location = new Point(222, 78);
            playlistView.Name = "playlistView";
            playlistView.Size = new Size(296, 332);
            playlistView.TabIndex = 0;
            playlistView.UseCompatibleStateImageBehavior = false;
            playlistView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Song Name";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Artist";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Release Date";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Genre Name";
            // 
            // idBox
            // 
            idBox.Font = new Font("Segoe UI", 20F);
            idBox.Location = new Point(231, 29);
            idBox.Name = "idBox";
            idBox.PlaceholderText = "id";
            idBox.Size = new Size(58, 43);
            idBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(420, 29);
            button1.Name = "button1";
            button1.Size = new Size(108, 43);
            button1.TabIndex = 2;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 20F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ascending", "Descending" });
            comboBox1.Location = new Point(295, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 45);
            comboBox1.TabIndex = 3;
            // 
            // SongLists
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(idBox);
            Controls.Add(playlistView);
            Name = "SongLists";
            Text = "SongLists";
            Load += SongLists_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView playlistView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox idBox;
        private Button button1;
        private ComboBox comboBox1;
    }
}