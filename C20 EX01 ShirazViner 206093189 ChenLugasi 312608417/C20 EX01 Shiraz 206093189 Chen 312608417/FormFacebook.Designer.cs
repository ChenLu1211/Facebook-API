namespace C20_EX01_Shiraz_206093189_Chen_312608417
{
    public partial class FormFacebook
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
            System.Windows.Forms.PictureBox pictureBoxGroups;
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.labelLogInName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.openFileUploadPicture = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxEvents = new System.Windows.Forms.PictureBox();
            this.pictureBoxMyPosts = new System.Windows.Forms.PictureBox();
            this.pictureBoxUpload = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfilePic = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlbums = new System.Windows.Forms.PictureBox();
            this.pictureBoxBirthday = new System.Windows.Forms.PictureBox();
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheckin = new System.Windows.Forms.PictureBox();
            this.pictureBoxCorona = new System.Windows.Forms.PictureBox();
            this.pictureBoxLikely = new System.Windows.Forms.PictureBox();
            this.pictureBoxPost = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            pictureBoxGroups = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBoxGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikely)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGroups
            // 
            pictureBoxGroups.BackColor = System.Drawing.Color.MidnightBlue;
            pictureBoxGroups.Image = global::C20_EX01_Shiraz_206093189_Chen_312608417.Properties.Resources.groupNew;
            pictureBoxGroups.Location = new System.Drawing.Point(472, 333);
            pictureBoxGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBoxGroups.Name = "pictureBoxGroups";
            pictureBoxGroups.Size = new System.Drawing.Size(190, 175);
            pictureBoxGroups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBoxGroups.TabIndex = 23;
            pictureBoxGroups.TabStop = false;
            pictureBoxGroups.Click += new System.EventHandler(this.pictureBoxGroups_Click);
            // 
            // textBoxPost
            // 
            this.textBoxPost.BackColor = System.Drawing.Color.White;
            this.textBoxPost.Location = new System.Drawing.Point(20, 288);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPost.Size = new System.Drawing.Size(342, 274);
            this.textBoxPost.TabIndex = 14;
            // 
            // labelLogInName
            // 
            this.labelLogInName.AutoSize = true;
            this.labelLogInName.BackColor = System.Drawing.Color.Transparent;
            this.labelLogInName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogInName.Location = new System.Drawing.Point(456, 50);
            this.labelLogInName.Name = "labelLogInName";
            this.labelLogInName.Size = new System.Drawing.Size(159, 25);
            this.labelLogInName.TabIndex = 1;
            this.labelLogInName.Text = "Hello, UserName";
            this.labelLogInName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(166, 132);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(127, 23);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "User Name: ";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.Location = new System.Drawing.Point(166, 179);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(98, 23);
            this.labelBirthday.TabIndex = 17;
            this.labelBirthday.Text = "Birthday:";
            this.labelBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(166, 227);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(91, 23);
            this.labelGender.TabIndex = 18;
            this.labelGender.Text = "Gender: ";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogOut.Location = new System.Drawing.Point(1006, 22);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(96, 90);
            this.buttonLogOut.TabIndex = 20;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // openFileUploadPicture
            // 
            this.openFileUploadPicture.FileName = "openFileUploadPicture";
            // 
            // pictureBoxEvents
            // 
            this.pictureBoxEvents.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBoxEvents.Image = global::C20_EX01_Shiraz_206093189_Chen_312608417.Properties.Resources.eventsNew;
            this.pictureBoxEvents.Location = new System.Drawing.Point(912, 333);
            this.pictureBoxEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEvents.Name = "pictureBoxEvents";
            this.pictureBoxEvents.Size = new System.Drawing.Size(190, 175);
            this.pictureBoxEvents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEvents.TabIndex = 22;
            this.pictureBoxEvents.TabStop = false;
            this.pictureBoxEvents.Click += new System.EventHandler(this.pictureBoxEvents_Click);
            // 
            // pictureBoxMyPosts
            // 
            this.pictureBoxMyPosts.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBoxMyPosts.Image = global::C20_EX01_Shiraz_206093189_Chen_312608417.Properties.Resources.postsNew;
            this.pictureBoxMyPosts.Location = new System.Drawing.Point(691, 144);
            this.pictureBoxMyPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMyPosts.Name = "pictureBoxMyPosts";
            this.pictureBoxMyPosts.Size = new System.Drawing.Size(190, 175);
            this.pictureBoxMyPosts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMyPosts.TabIndex = 21;
            this.pictureBoxMyPosts.TabStop = false;
            this.pictureBoxMyPosts.Click += new System.EventHandler(this.pictureBoxMyPosts_Click);
            // 
            // pictureBoxUpload
            // 
            this.pictureBoxUpload.Image = global::C20_EX01_Shiraz_206093189_Chen_312608417.Properties.Resources.upload;
            this.pictureBoxUpload.Location = new System.Drawing.Point(20, 567);
            this.pictureBoxUpload.Name = "pictureBoxUpload";
            this.pictureBoxUpload.Size = new System.Drawing.Size(113, 67);
            this.pictureBoxUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUpload.TabIndex = 15;
            this.pictureBoxUpload.TabStop = false;
            this.pictureBoxUpload.Click += new System.EventHandler(this.pictureBoxUpload_Click);
            // 
            // pictureBoxProfilePic
            // 
            this.pictureBoxProfilePic.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBoxProfilePic.Location = new System.Drawing.Point(20, 128);
            this.pictureBoxProfilePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfilePic.Name = "pictureBoxProfilePic";
            this.pictureBoxProfilePic.Size = new System.Drawing.Size(140, 130);
            this.pictureBoxProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxProfilePic.TabIndex = 10;
            this.pictureBoxProfilePic.TabStop = false;
            // 
            // pictureBoxAlbums
            // 
            this.pictureBoxAlbums.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBoxAlbums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxAlbums.Image = global::C20_EX01_Shiraz_206093189_Chen_312608417.Properties.Resources.albumsNew;
            this.pictureBoxAlbums.Location = new System.Drawing.Point(472, 144);
            this.pictureBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxAlbums.Name = "pictureBoxAlbums";
            this.pictureBoxAlbums.Size = new System.Drawing.Size(190, 175);
            this.pictureBoxAlbums.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAlbums.TabIndex = 8;
            this.pictureBoxAlbums.TabStop = false;
            this.pictureBoxAlbums.Click += new System.EventHandler(this.pictureBoxAlbums_Click);
            // 
            // pictureBoxBirthday
            // 
            this.pictureBoxBirthday.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBoxBirthday.Image = global::C20_EX01_Shiraz_206093189_Chen_312608417.Properties.Resources.birthdayNew;
            this.pictureBoxBirthday.Location = new System.Drawing.Point(691, 523);
            this.pictureBoxBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxBirthday.Name = "pictureBoxBirthday";
            this.pictureBoxBirthday.Size = new System.Drawing.Size(190, 175);
            this.pictureBoxBirthday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxBirthday.TabIndex = 7;
            this.pictureBoxBirthday.TabStop = false;
            this.pictureBoxBirthday.Click += new System.EventHandler(this.pictureBoxBirthday_Click);
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBoxFriends.Image = global::C20_EX01_Shiraz_206093189_Chen_312608417.Properties.Resources.frinedsNew;
            this.pictureBoxFriends.Location = new System.Drawing.Point(912, 144);
            this.pictureBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(190, 175);
            this.pictureBoxFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFriends.TabIndex = 6;
            this.pictureBoxFriends.TabStop = false;
            this.pictureBoxFriends.Click += new System.EventHandler(this.pictureBoxFriends_Click);
            // 
            // pictureBoxCheckin
            // 
            this.pictureBoxCheckin.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBoxCheckin.Image = global::C20_EX01_Shiraz_206093189_Chen_312608417.Properties.Resources.checkinNew;
            this.pictureBoxCheckin.Location = new System.Drawing.Point(691, 333);
            this.pictureBoxCheckin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCheckin.Name = "pictureBoxCheckin";
            this.pictureBoxCheckin.Size = new System.Drawing.Size(190, 175);
            this.pictureBoxCheckin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCheckin.TabIndex = 5;
            this.pictureBoxCheckin.TabStop = false;
            this.pictureBoxCheckin.Click += new System.EventHandler(this.pictureBoxCheckin_Click);
            // 
            // pictureBoxCorona
            // 
            this.pictureBoxCorona.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBoxCorona.Image = global::C20_EX01_Shiraz_206093189_Chen_312608417.Properties.Resources.coronaNew;
            this.pictureBoxCorona.Location = new System.Drawing.Point(472, 523);
            this.pictureBoxCorona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCorona.Name = "pictureBoxCorona";
            this.pictureBoxCorona.Size = new System.Drawing.Size(190, 175);
            this.pictureBoxCorona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCorona.TabIndex = 4;
            this.pictureBoxCorona.TabStop = false;
            this.pictureBoxCorona.Click += new System.EventHandler(this.pictureBoxCorona_Click);
            // 
            // pictureBoxLikely
            // 
            this.pictureBoxLikely.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBoxLikely.Image = global::C20_EX01_Shiraz_206093189_Chen_312608417.Properties.Resources.MostLikelyNew;
            this.pictureBoxLikely.Location = new System.Drawing.Point(912, 523);
            this.pictureBoxLikely.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLikely.Name = "pictureBoxLikely";
            this.pictureBoxLikely.Size = new System.Drawing.Size(190, 175);
            this.pictureBoxLikely.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLikely.TabIndex = 3;
            this.pictureBoxLikely.TabStop = false;
            this.pictureBoxLikely.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // pictureBoxPost
            // 
            this.pictureBoxPost.Image = global::C20_EX01_Shiraz_206093189_Chen_312608417.Properties.Resources.post;
            this.pictureBoxPost.Location = new System.Drawing.Point(139, 566);
            this.pictureBoxPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPost.Name = "pictureBoxPost";
            this.pictureBoxPost.Size = new System.Drawing.Size(223, 68);
            this.pictureBoxPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPost.TabIndex = 2;
            this.pictureBoxPost.TabStop = false;
            this.pictureBoxPost.Click += new System.EventHandler(this.pictureBoxPost_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::C20_EX01_Shiraz_206093189_Chen_312608417.Properties.Resources.logoNew;
            this.pictureBoxLogo.Location = new System.Drawing.Point(341, 22);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(322, 80);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.Location = new System.Drawing.Point(904, 22);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(96, 90);
            this.buttonExit.TabIndex = 24;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Azure;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1130, 726);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelLogInName);
            this.Controls.Add(pictureBoxGroups);
            this.Controls.Add(this.pictureBoxEvents);
            this.Controls.Add(this.pictureBoxMyPosts);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxUpload);
            this.Controls.Add(this.pictureBoxProfilePic);
            this.Controls.Add(this.pictureBoxAlbums);
            this.Controls.Add(this.pictureBoxBirthday);
            this.Controls.Add(this.pictureBoxFriends);
            this.Controls.Add(this.pictureBoxCheckin);
            this.Controls.Add(this.pictureBoxCorona);
            this.Controls.Add(this.pictureBoxLikely);
            this.Controls.Add(this.pictureBoxPost);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.textBoxPost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormFacebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFacebook";
            ((System.ComponentModel.ISupportInitialize)(pictureBoxGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikely)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxPost;
        private System.Windows.Forms.PictureBox pictureBoxLikely;
        private System.Windows.Forms.PictureBox pictureBoxCorona;
        private System.Windows.Forms.PictureBox pictureBoxCheckin;
        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxBirthday;
        private System.Windows.Forms.PictureBox pictureBoxAlbums;
        private System.Windows.Forms.PictureBox pictureBoxProfilePic;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.PictureBox pictureBoxUpload;
        private System.Windows.Forms.Label labelLogInName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.OpenFileDialog openFileUploadPicture;
        private System.Windows.Forms.PictureBox pictureBoxMyPosts;
        private System.Windows.Forms.PictureBox pictureBoxEvents;
        private System.Windows.Forms.Button buttonExit;
    }
}