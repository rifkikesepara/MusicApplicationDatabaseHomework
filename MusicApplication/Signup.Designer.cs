namespace MusicApplication
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            emailBox = new TextBox();
            datePicker = new DateTimePicker();
            submitButton = new Button();
            countryComboBox = new ComboBox();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameBox.Font = new Font("Segoe UI", 20F);
            usernameBox.Location = new Point(276, 41);
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "Username";
            usernameBox.Size = new Size(262, 43);
            usernameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordBox.Font = new Font("Segoe UI", 20F);
            passwordBox.Location = new Point(276, 90);
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Password";
            passwordBox.Size = new Size(262, 43);
            passwordBox.TabIndex = 0;
            // 
            // emailBox
            // 
            emailBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            emailBox.Font = new Font("Segoe UI", 20F);
            emailBox.Location = new Point(276, 139);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "E-mail";
            emailBox.Size = new Size(262, 43);
            emailBox.TabIndex = 2;
            // 
            // datePicker
            // 
            datePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datePicker.Font = new Font("Segoe UI", 20F);
            datePicker.Location = new Point(214, 188);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(370, 43);
            datePicker.TabIndex = 3;
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            submitButton.Location = new Point(276, 308);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(262, 130);
            submitButton.TabIndex = 5;
            submitButton.Text = "Signup";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // countryComboBox
            // 
            countryComboBox.Font = new Font("Segoe UI", 20F);
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(276, 246);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(262, 45);
            countryComboBox.TabIndex = 4;
            countryComboBox.Text = "Select A Country";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(countryComboBox);
            Controls.Add(usernameBox);
            Controls.Add(submitButton);
            Controls.Add(datePicker);
            Controls.Add(emailBox);
            Controls.Add(passwordBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            Load += Signup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameBox;
        private TextBox passwordBox;
        private TextBox emailBox;
        private DateTimePicker datePicker;
        private Button submitButton;
        private ComboBox countryComboBox;
    }
}