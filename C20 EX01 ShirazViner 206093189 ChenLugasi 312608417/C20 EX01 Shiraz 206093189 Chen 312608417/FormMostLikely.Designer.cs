﻿namespace C20_EX01_Shiraz_206093189_Chen_312608417
{
    public partial class FormMostLikely
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLikelyPicture = new System.Windows.Forms.Label();
            this.labelLikelyPost = new System.Windows.Forms.Label();
            this.textBoxLikelyPost = new System.Windows.Forms.TextBox();
            this.labelLikelyFriend = new System.Windows.Forms.Label();
            this.textBoxFriendLike = new System.Windows.Forms.TextBox();
            this.labelCommentFriend = new System.Windows.Forms.Label();
            this.textBoxCommentFriend = new System.Windows.Forms.TextBox();
            this.labelMustComment = new System.Windows.Forms.Label();
            this.textBoxCommentedPost = new System.Windows.Forms.TextBox();
            this.pictureBoxLikely = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikely)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTitle.Location = new System.Drawing.Point(120, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(541, 46);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Your most likely items are :";
            // 
            // labelLikelyPicture
            // 
            this.labelLikelyPicture.AutoSize = true;
            this.labelLikelyPicture.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikelyPicture.Location = new System.Drawing.Point(63, 120);
            this.labelLikelyPicture.Name = "labelLikelyPicture";
            this.labelLikelyPicture.Size = new System.Drawing.Size(187, 23);
            this.labelLikelyPicture.TabIndex = 1;
            this.labelLikelyPicture.Text = "Most likely picture";
            // 
            // labelLikelyPost
            // 
            this.labelLikelyPost.AutoSize = true;
            this.labelLikelyPost.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikelyPost.Location = new System.Drawing.Point(350, 120);
            this.labelLikelyPost.Name = "labelLikelyPost";
            this.labelLikelyPost.Size = new System.Drawing.Size(162, 23);
            this.labelLikelyPost.TabIndex = 3;
            this.labelLikelyPost.Text = "Most likely post";
            // 
            // textBoxLikelyPost
            // 
            this.textBoxLikelyPost.Location = new System.Drawing.Point(322, 160);
            this.textBoxLikelyPost.Multiline = true;
            this.textBoxLikelyPost.Name = "textBoxLikelyPost";
            this.textBoxLikelyPost.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLikelyPost.Size = new System.Drawing.Size(395, 130);
            this.textBoxLikelyPost.TabIndex = 4;
            // 
            // labelLikelyFriend
            // 
            this.labelLikelyFriend.AutoSize = true;
            this.labelLikelyFriend.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikelyFriend.Location = new System.Drawing.Point(40, 308);
            this.labelLikelyFriend.Name = "labelLikelyFriend";
            this.labelLikelyFriend.Size = new System.Drawing.Size(326, 23);
            this.labelLikelyFriend.TabIndex = 5;
            this.labelLikelyFriend.Text = "The friend who like you the most";
            // 
            // textBoxFriendLike
            // 
            this.textBoxFriendLike.Location = new System.Drawing.Point(37, 333);
            this.textBoxFriendLike.Multiline = true;
            this.textBoxFriendLike.Name = "textBoxFriendLike";
            this.textBoxFriendLike.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxFriendLike.Size = new System.Drawing.Size(349, 44);
            this.textBoxFriendLike.TabIndex = 6;
            // 
            // labelCommentFriend
            // 
            this.labelCommentFriend.AutoSize = true;
            this.labelCommentFriend.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCommentFriend.Location = new System.Drawing.Point(38, 393);
            this.labelCommentFriend.Name = "labelCommentFriend";
            this.labelCommentFriend.Size = new System.Drawing.Size(340, 23);
            this.labelCommentFriend.TabIndex = 7;
            this.labelCommentFriend.Text = "The friend who comment the most";
            // 
            // textBoxCommentFriend
            // 
            this.textBoxCommentFriend.Location = new System.Drawing.Point(37, 426);
            this.textBoxCommentFriend.Multiline = true;
            this.textBoxCommentFriend.Name = "textBoxCommentFriend";
            this.textBoxCommentFriend.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxCommentFriend.Size = new System.Drawing.Size(349, 42);
            this.textBoxCommentFriend.TabIndex = 8;
            // 
            // labelMustComment
            // 
            this.labelMustComment.AutoSize = true;
            this.labelMustComment.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMustComment.Location = new System.Drawing.Point(446, 308);
            this.labelMustComment.Name = "labelMustComment";
            this.labelMustComment.Size = new System.Drawing.Size(223, 23);
            this.labelMustComment.TabIndex = 9;
            this.labelMustComment.Text = "Most commented post";
            // 
            // textBoxCommentedPost
            // 
            this.textBoxCommentedPost.Location = new System.Drawing.Point(422, 333);
            this.textBoxCommentedPost.Multiline = true;
            this.textBoxCommentedPost.Name = "textBoxCommentedPost";
            this.textBoxCommentedPost.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCommentedPost.Size = new System.Drawing.Size(295, 135);
            this.textBoxCommentedPost.TabIndex = 10;
            // 
            // pictureBoxLikely
            // 
            this.pictureBoxLikely.Location = new System.Drawing.Point(43, 160);
            this.pictureBoxLikely.Name = "pictureBoxLikely";
            this.pictureBoxLikely.Size = new System.Drawing.Size(226, 130);
            this.pictureBoxLikely.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikely.TabIndex = 2;
            this.pictureBoxLikely.TabStop = false;
            // 
            // FormMostLikely
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(755, 509);
            this.Controls.Add(this.textBoxCommentedPost);
            this.Controls.Add(this.labelMustComment);
            this.Controls.Add(this.textBoxCommentFriend);
            this.Controls.Add(this.labelCommentFriend);
            this.Controls.Add(this.textBoxFriendLike);
            this.Controls.Add(this.labelLikelyFriend);
            this.Controls.Add(this.textBoxLikelyPost);
            this.Controls.Add(this.labelLikelyPost);
            this.Controls.Add(this.pictureBoxLikely);
            this.Controls.Add(this.labelLikelyPicture);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMostLikely";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMostLikely";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikely)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLikelyPicture;
        private System.Windows.Forms.PictureBox pictureBoxLikely;
        private System.Windows.Forms.Label labelLikelyPost;
        private System.Windows.Forms.TextBox textBoxLikelyPost;
        private System.Windows.Forms.Label labelLikelyFriend;
        private System.Windows.Forms.TextBox textBoxFriendLike;
        private System.Windows.Forms.Label labelCommentFriend;
        private System.Windows.Forms.TextBox textBoxCommentFriend;
        private System.Windows.Forms.Label labelMustComment;
        private System.Windows.Forms.TextBox textBoxCommentedPost;
    }
}