namespace C20_EX01_Shiraz_206093189_Chen_312608417
{
    public partial class FormAlbums
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
            this.labelAlbumList = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelAlbumList
            // 
            this.labelAlbumList.AutoSize = true;
            this.labelAlbumList.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumList.Location = new System.Drawing.Point(46, 28);
            this.labelAlbumList.Name = "labelAlbumList";
            this.labelAlbumList.Size = new System.Drawing.Size(290, 52);
            this.labelAlbumList.TabIndex = 3;
            this.labelAlbumList.Text = "Albums List:";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.HorizontalScrollbar = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(33, 108);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(320, 404);
            this.listBoxAlbums.TabIndex = 2;
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(386, 553);
            this.Controls.Add(this.labelAlbumList);
            this.Controls.Add(this.listBoxAlbums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAlbums";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAlbums";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlbumList;
        private System.Windows.Forms.ListBox listBoxAlbums;
    }
}