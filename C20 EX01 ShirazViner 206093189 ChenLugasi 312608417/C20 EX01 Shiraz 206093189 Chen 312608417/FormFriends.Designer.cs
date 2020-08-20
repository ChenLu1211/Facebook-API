namespace C20_EX01_Shiraz_206093189_Chen_312608417
{
    public partial class FormFriends
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
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelFriendsList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.HorizontalScrollbar = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(39, 102);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(320, 404);
            this.listBoxFriends.TabIndex = 0;
            // 
            // labelFriendsList
            // 
            this.labelFriendsList.AutoSize = true;
            this.labelFriendsList.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsList.Location = new System.Drawing.Point(52, 26);
            this.labelFriendsList.Name = "labelFriendsList";
            this.labelFriendsList.Size = new System.Drawing.Size(290, 52);
            this.labelFriendsList.TabIndex = 1;
            this.labelFriendsList.Text = "Friends List:";
            // 
            // FormFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(396, 543);
            this.Controls.Add(this.labelFriendsList);
            this.Controls.Add(this.listBoxFriends);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormFriends";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormFriends";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelFriendsList;
    }
}