namespace C20_EX01_Shiraz_206093189_Chen_312608417
{
    public partial class FormCorona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCorona));
            this.labelCorona = new System.Windows.Forms.Label();
            this.textBoxCorona = new System.Windows.Forms.TextBox();
            this.pictureBoxPost = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCorona
            // 
            this.labelCorona.AutoSize = true;
            this.labelCorona.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCorona.Location = new System.Drawing.Point(37, 18);
            this.labelCorona.Name = "labelCorona";
            this.labelCorona.Size = new System.Drawing.Size(624, 58);
            this.labelCorona.TabIndex = 0;
            this.labelCorona.Text = "Covid-19 Post will tag all of your friends and places\r\n that you were with in the" +
    " last month";
            this.labelCorona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCorona
            // 
            this.textBoxCorona.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxCorona.Location = new System.Drawing.Point(51, 92);
            this.textBoxCorona.Multiline = true;
            this.textBoxCorona.Name = "textBoxCorona";
            this.textBoxCorona.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCorona.Size = new System.Drawing.Size(619, 299);
            this.textBoxCorona.TabIndex = 1;
            this.textBoxCorona.Text = resources.GetString("textBoxCorona.Text");
            // 
            // pictureBoxPost
            // 
            this.pictureBoxPost.Image = global::C20_EX01_Shiraz_206093189_Chen_312608417.Properties.Resources.post;
            this.pictureBoxPost.Location = new System.Drawing.Point(475, 326);
            this.pictureBoxPost.Name = "pictureBoxPost";
            this.pictureBoxPost.Size = new System.Drawing.Size(195, 65);
            this.pictureBoxPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPost.TabIndex = 2;
            this.pictureBoxPost.TabStop = false;
            this.pictureBoxPost.Click += new System.EventHandler(this.pictureBoxPost_Click);
            // 
            // FormCorona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(717, 436);
            this.Controls.Add(this.pictureBoxPost);
            this.Controls.Add(this.textBoxCorona);
            this.Controls.Add(this.labelCorona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCorona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCorona";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCorona;
        private System.Windows.Forms.TextBox textBoxCorona;
        private System.Windows.Forms.PictureBox pictureBoxPost;
    }
}