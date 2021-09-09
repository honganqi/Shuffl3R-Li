namespace Shuffl3R_Li
{
    partial class ShufflerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShufflerWindow));
            this.timerDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerDisplay
            // 
            this.timerDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.timerDisplay.ForeColor = System.Drawing.Color.White;
            this.timerDisplay.Location = new System.Drawing.Point(0, 0);
            this.timerDisplay.Name = "timerDisplay";
            this.timerDisplay.Size = new System.Drawing.Size(369, 182);
            this.timerDisplay.TabIndex = 1;
            this.timerDisplay.Text = "timer here";
            this.timerDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timerDisplay.Click += new System.EventHandler(this.ShufflerDisplay_Click);
            // 
            // ShufflerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(369, 182);
            this.Controls.Add(this.timerDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShufflerWindow";
            this.Text = "Shuffl3R";
            this.Load += new System.EventHandler(this.ShufflerWindow_FormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timerDisplay;
    }
}