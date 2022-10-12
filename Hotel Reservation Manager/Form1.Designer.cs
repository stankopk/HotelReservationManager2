namespace Hotel_Reservation_Manager
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.LoginLogo = new System.Windows.Forms.PictureBox();
            this.LogInSignInLabel = new System.Windows.Forms.Label();
            this.loginusericon = new System.Windows.Forms.PictureBox();
            this.loginwhitepanel = new System.Windows.Forms.Panel();
            this.loginpasswordicon = new System.Windows.Forms.PictureBox();
            this.loginwhitepannel2 = new System.Windows.Forms.Panel();
            this.LogInSignInButton = new System.Windows.Forms.Button();
            this.LogInDontHaveAnAccLabel = new System.Windows.Forms.Label();
            this.LogInRegisterButton = new System.Windows.Forms.Button();
            this.LogInExitButton = new System.Windows.Forms.Button();
            this.LoginUserTextBox = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.LogInPswrdTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginusericon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginpasswordicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginLogo
            // 
            this.LoginLogo.BackColor = System.Drawing.Color.Transparent;
            this.LoginLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginLogo.BackgroundImage")));
            this.LoginLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoginLogo.Location = new System.Drawing.Point(27, -37);
            this.LoginLogo.Name = "LoginLogo";
            this.LoginLogo.Size = new System.Drawing.Size(310, 215);
            this.LoginLogo.TabIndex = 0;
            this.LoginLogo.TabStop = false;
            // 
            // LogInSignInLabel
            // 
            this.LogInSignInLabel.AutoSize = true;
            this.LogInSignInLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogInSignInLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogInSignInLabel.ForeColor = System.Drawing.Color.White;
            this.LogInSignInLabel.Location = new System.Drawing.Point(126, 123);
            this.LogInSignInLabel.Name = "LogInSignInLabel";
            this.LogInSignInLabel.Size = new System.Drawing.Size(97, 33);
            this.LogInSignInLabel.TabIndex = 1;
            this.LogInSignInLabel.Text = "Sign In";
            this.LogInSignInLabel.Click += new System.EventHandler(this.SignInLabel_Click);
            // 
            // loginusericon
            // 
            this.loginusericon.BackColor = System.Drawing.Color.Transparent;
            this.loginusericon.BackgroundImage = global::Hotel_Reservation_Manager.Properties.Resources.profile_user_round_white_icon_symbol_png_11639594348fn8rlcxrqo_removebg_preview;
            this.loginusericon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginusericon.Location = new System.Drawing.Point(73, 177);
            this.loginusericon.Name = "loginusericon";
            this.loginusericon.Size = new System.Drawing.Size(47, 43);
            this.loginusericon.TabIndex = 2;
            this.loginusericon.TabStop = false;
            // 
            // loginwhitepanel
            // 
            this.loginwhitepanel.BackColor = System.Drawing.Color.White;
            this.loginwhitepanel.Location = new System.Drawing.Point(62, 226);
            this.loginwhitepanel.Name = "loginwhitepanel";
            this.loginwhitepanel.Size = new System.Drawing.Size(240, 3);
            this.loginwhitepanel.TabIndex = 3;
            // 
            // loginpasswordicon
            // 
            this.loginpasswordicon.BackColor = System.Drawing.Color.Transparent;
            this.loginpasswordicon.BackgroundImage = global::Hotel_Reservation_Manager.Properties.Resources.lock_icon_black_white_black_background_illustration_lock_icon_black_white_black_background_vector_illustration_170336738_removebg_preview;
            this.loginpasswordicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginpasswordicon.Location = new System.Drawing.Point(47, 254);
            this.loginpasswordicon.Name = "loginpasswordicon";
            this.loginpasswordicon.Size = new System.Drawing.Size(98, 57);
            this.loginpasswordicon.TabIndex = 2;
            this.loginpasswordicon.TabStop = false;
            // 
            // loginwhitepannel2
            // 
            this.loginwhitepannel2.BackColor = System.Drawing.Color.White;
            this.loginwhitepannel2.Location = new System.Drawing.Point(62, 308);
            this.loginwhitepannel2.Name = "loginwhitepannel2";
            this.loginwhitepannel2.Size = new System.Drawing.Size(240, 3);
            this.loginwhitepannel2.TabIndex = 3;
            // 
            // LogInSignInButton
            // 
            this.LogInSignInButton.BackColor = System.Drawing.Color.Transparent;
            this.LogInSignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInSignInButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogInSignInButton.FlatAppearance.BorderSize = 2;
            this.LogInSignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInSignInButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogInSignInButton.ForeColor = System.Drawing.Color.White;
            this.LogInSignInButton.Location = new System.Drawing.Point(93, 331);
            this.LogInSignInButton.Name = "LogInSignInButton";
            this.LogInSignInButton.Size = new System.Drawing.Size(188, 44);
            this.LogInSignInButton.TabIndex = 4;
            this.LogInSignInButton.Text = "Sign In";
            this.LogInSignInButton.UseVisualStyleBackColor = false;
            this.LogInSignInButton.Click += new System.EventHandler(this.LogInSignInButton_Click);
            // 
            // LogInDontHaveAnAccLabel
            // 
            this.LogInDontHaveAnAccLabel.AutoSize = true;
            this.LogInDontHaveAnAccLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogInDontHaveAnAccLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogInDontHaveAnAccLabel.ForeColor = System.Drawing.Color.Transparent;
            this.LogInDontHaveAnAccLabel.Location = new System.Drawing.Point(197, 410);
            this.LogInDontHaveAnAccLabel.Name = "LogInDontHaveAnAccLabel";
            this.LogInDontHaveAnAccLabel.Size = new System.Drawing.Size(170, 17);
            this.LogInDontHaveAnAccLabel.TabIndex = 5;
            this.LogInDontHaveAnAccLabel.Text = "Don\'t Have An Account?";
            // 
            // LogInRegisterButton
            // 
            this.LogInRegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.LogInRegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInRegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogInRegisterButton.FlatAppearance.BorderSize = 2;
            this.LogInRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInRegisterButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogInRegisterButton.ForeColor = System.Drawing.Color.White;
            this.LogInRegisterButton.Location = new System.Drawing.Point(197, 430);
            this.LogInRegisterButton.Name = "LogInRegisterButton";
            this.LogInRegisterButton.Size = new System.Drawing.Size(170, 44);
            this.LogInRegisterButton.TabIndex = 6;
            this.LogInRegisterButton.Text = "Register";
            this.LogInRegisterButton.UseVisualStyleBackColor = false;
            // 
            // LogInExitButton
            // 
            this.LogInExitButton.BackColor = System.Drawing.Color.Transparent;
            this.LogInExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInExitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogInExitButton.FlatAppearance.BorderSize = 2;
            this.LogInExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInExitButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogInExitButton.ForeColor = System.Drawing.Color.White;
            this.LogInExitButton.Location = new System.Drawing.Point(3, 430);
            this.LogInExitButton.Name = "LogInExitButton";
            this.LogInExitButton.Size = new System.Drawing.Size(170, 44);
            this.LogInExitButton.TabIndex = 6;
            this.LogInExitButton.Text = "Exit";
            this.LogInExitButton.UseVisualStyleBackColor = false;
            this.LogInExitButton.Click += new System.EventHandler(this.LogInExitButton_Click);
            // 
            // LoginUserTextBox
            // 
            this.LoginUserTextBox.BackColor = System.Drawing.Color.White;
            this.LoginUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginUserTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginUserTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginUserTextBox.ForeColor = System.Drawing.Color.Black;
            this.LoginUserTextBox.Location = new System.Drawing.Point(126, 184);
            this.LoginUserTextBox.Multiline = true;
            this.LoginUserTextBox.Name = "LoginUserTextBox";
            this.LoginUserTextBox.Size = new System.Drawing.Size(169, 36);
            this.LoginUserTextBox.TabIndex = 7;
            this.LoginUserTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // LogInPswrdTextBox
            // 
            this.LogInPswrdTextBox.BackColor = System.Drawing.Color.White;
            this.LogInPswrdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogInPswrdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LogInPswrdTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogInPswrdTextBox.ForeColor = System.Drawing.Color.Black;
            this.LogInPswrdTextBox.Location = new System.Drawing.Point(126, 266);
            this.LogInPswrdTextBox.Multiline = true;
            this.LogInPswrdTextBox.Name = "LogInPswrdTextBox";
            this.LogInPswrdTextBox.Size = new System.Drawing.Size(169, 36);
            this.LogInPswrdTextBox.TabIndex = 7;
            this.LogInPswrdTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Reservation_Manager.Properties.Resources.loginscreenbackground1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(370, 517);
            this.Controls.Add(this.LogInPswrdTextBox);
            this.Controls.Add(this.LoginUserTextBox);
            this.Controls.Add(this.LogInExitButton);
            this.Controls.Add(this.LogInRegisterButton);
            this.Controls.Add(this.LogInDontHaveAnAccLabel);
            this.Controls.Add(this.LogInSignInButton);
            this.Controls.Add(this.loginwhitepannel2);
            this.Controls.Add(this.loginwhitepanel);
            this.Controls.Add(this.loginpasswordicon);
            this.Controls.Add(this.loginusericon);
            this.Controls.Add(this.LogInSignInLabel);
            this.Controls.Add(this.LoginLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginScreen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginusericon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginpasswordicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox LoginLogo;
        private Label LogInSignInLabel;
        private PictureBox loginusericon;
        private Panel loginwhitepanel;
        private PictureBox loginpasswordicon;
        private Panel loginwhitepannel2;
        private Button LogInSignInButton;
        private Label LogInDontHaveAnAccLabel;
        private Button LogInRegisterButton;
        private Button LogInExitButton;
        private TextBox LoginUserTextBox;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox LogInPswrdTextBox;
    }
}