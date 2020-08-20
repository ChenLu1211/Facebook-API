namespace C20_EX01_Shiraz_206093189_Chen_312608417
{
    public partial class FormEvents
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
            this.labelEventsList = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelEventsList
            // 
            this.labelEventsList.AutoSize = true;
            this.labelEventsList.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventsList.Location = new System.Drawing.Point(28, 27);
            this.labelEventsList.Name = "labelEventsList";
            this.labelEventsList.Size = new System.Drawing.Size(401, 40);
            this.labelEventsList.TabIndex = 5;
            this.labelEventsList.Text = "Your future events list:";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.HorizontalScrollbar = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(53, 94);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(356, 420);
            this.listBoxEvents.TabIndex = 4;
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(471, 553);
            this.Controls.Add(this.labelEventsList);
            this.Controls.Add(this.listBoxEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEvents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEventsList;
        private System.Windows.Forms.ListBox listBoxEvents;
    }
}