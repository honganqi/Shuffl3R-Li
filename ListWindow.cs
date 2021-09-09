using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shuffl3R_Li
{
    public partial class ListWindow : DraggableForm
    {
        public string listedItems;

        // window variables
        public string locationXPass;
        public string locationYPass;
        public string sizeWidthPass;
        public string sizeHeightPass;
        public Font fontPass;
        public Color fontColorPass;
        public Color bgColorPass;
        public Screen selectedScreen;
        public bool fullscreen = false;
        public bool displaylist = true;

        private OptionsWindow optionsWindow = null;

        public ListWindow(Form callOptionsWindow)
        {
            optionsWindow = callOptionsWindow as OptionsWindow;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            listedItems = "";
        }

        public void AddItem(string newItem)
        {
            if (listedItems != "")
            {
                listedItems += Environment.NewLine + newItem;
            } else
            {
                listedItems = newItem;
            }
            listDisplay.Text = listedItems;
        }

        private void ListWindow_Load(object sender, EventArgs e)
        {
            /* screen/monitor settings
            * if not primary, fetch settings
            * if not maximized, fetch window settings (or probably secondary monitor, should manually fullscreened)
            */
            if (selectedScreen != Screen.PrimaryScreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.Bounds = selectedScreen.Bounds;
            }

            if (this.WindowState != FormWindowState.Maximized)
            {
                this.Location = new Point(int.Parse(locationXPass), int.Parse(locationYPass));
                this.Size = new Size(int.Parse(sizeWidthPass), int.Parse(sizeHeightPass));
            }
            listDisplay.Font = fontPass;
            listDisplay.ForeColor = fontColorPass;
            this.BackColor = bgColorPass;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                optionsWindow.CloseShufflers();
            }
        }
    }
}
