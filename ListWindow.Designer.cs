namespace Shuffl3R_Li
{
    partial class ListWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListWindow));
            this.listDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listDisplay
            // 
            this.listDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.listDisplay.ForeColor = System.Drawing.Color.White;
            this.listDisplay.Location = new System.Drawing.Point(0, 0);
            this.listDisplay.Name = "listDisplay";
            this.listDisplay.Size = new System.Drawing.Size(369, 182);
            this.listDisplay.TabIndex = 2;
            this.listDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(369, 182);
            this.Controls.Add(this.listDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListWindow";
            this.Text = "Shuffl3R List";
            this.Load += new System.EventHandler(this.ListWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label listDisplay;
    }
}