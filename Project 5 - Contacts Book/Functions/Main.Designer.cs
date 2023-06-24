namespace Project_5___Contacts_Book.Functions
{
    partial class Main
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
            this.TotalContactsL = new System.Windows.Forms.Label();
            this.countL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TotalContactsL
            // 
            this.TotalContactsL.AutoSize = true;
            this.TotalContactsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalContactsL.Location = new System.Drawing.Point(12, 42);
            this.TotalContactsL.Name = "TotalContactsL";
            this.TotalContactsL.Size = new System.Drawing.Size(176, 20);
            this.TotalContactsL.TabIndex = 0;
            this.TotalContactsL.Text = "Total Contacts Amount:";
            // 
            // countL
            // 
            this.countL.AutoSize = true;
            this.countL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countL.Location = new System.Drawing.Point(194, 42);
            this.countL.Name = "countL";
            this.countL.Size = new System.Drawing.Size(51, 20);
            this.countL.TabIndex = 1;
            this.countL.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(209)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(484, 359);
            this.Controls.Add(this.countL);
            this.Controls.Add(this.TotalContactsL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalContactsL;
        private System.Windows.Forms.Label countL;
    }
}