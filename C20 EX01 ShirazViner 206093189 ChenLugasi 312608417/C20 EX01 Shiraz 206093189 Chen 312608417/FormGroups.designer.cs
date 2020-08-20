namespace C20_EX01_Shiraz_206093189_Chen_312608417
{
    public partial class FormGroups
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
            this.labelGroupList = new System.Windows.Forms.Label();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelGroupList
            // 
            this.labelGroupList.AutoSize = true;
            this.labelGroupList.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroupList.Location = new System.Drawing.Point(51, 32);
            this.labelGroupList.Name = "labelGroupList";
            this.labelGroupList.Size = new System.Drawing.Size(285, 52);
            this.labelGroupList.TabIndex = 5;
            this.labelGroupList.Text = "Groups List:";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.HorizontalScrollbar = true;
            this.listBoxGroups.ItemHeight = 16;
            this.listBoxGroups.Location = new System.Drawing.Point(30, 109);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(320, 404);
            this.listBoxGroups.TabIndex = 4;
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(383, 553);
            this.Controls.Add(this.labelGroupList);
            this.Controls.Add(this.listBoxGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormGroups";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGroupList;
        private System.Windows.Forms.ListBox listBoxGroups;
    }
}