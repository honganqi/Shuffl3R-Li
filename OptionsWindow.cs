using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Shuffl3R_Li
{
    public partial class OptionsWindow : Form
    {
        Font selectedFont;
        Font listFont;
        bool firstopen;
        bool fromshuffle = false;
        public ShufflerWindow timerWindow;
        public ListWindow listWindow;

        public OptionsWindow()
        {
            InitializeComponent();
            firstopen = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if ((Properties.Settings.Default.shufflerLocation.X.ToString() != null) || (fromshuffle == true))
                firstopen = false;

            if (firstopen == true)
            {
                txtAnimation.Text = "60";
                chkOnTop.Checked = false;
                chkFullscreen.Checked = false;
                txtXPos.Text = "0";
                txtYPos.Text = "0";
                txtWidth.Text = "400";
                txtHeight.Text = "300";
                txtListXPos.Text = "400";
                txtListYPos.Text = "0";
                txtListWidth.Text = "400";
                txtListHeight.Text = "300";

                TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
                Font startFont = (Font)converter.ConvertFromString("Microsoft Sans Serif");
                fontDialog.Font = startFont;
                listFontDialog.Font = startFont;
                btnFont.Text = string.Format("Font: {0}", startFont.Name);
                btnFont.Font = new Font(startFont.FontFamily, 8);
                btnFont.ForeColor = System.Drawing.Color.White;
                fontDialog.Color = System.Drawing.Color.White;
                bgColorDialog.Color = System.Drawing.Color.Black;
                btnFont.BackColor = System.Drawing.Color.Black;
                btnListFont.Text = string.Format("Font: {0}", startFont.Name);
                btnListFont.Font = new Font(startFont.FontFamily, 8);
                btnListFont.ForeColor = System.Drawing.Color.White;
                listFontDialog.Color = System.Drawing.Color.White;
                listBgColorDialog.Color = System.Drawing.Color.Black;
                btnListFont.BackColor = System.Drawing.Color.Black;
                slctSource.SelectedIndex = 0;
                txtAutoNext.Text = "3";
                cboxAuto.Text = "manually";
                txtAnimation.Text = "00";

                ListScreens();
            }
            else
            {
                this.Location = Properties.Settings.Default.optionsLocation;
                this.Size = Properties.Settings.Default.optionsSize;

                txtAnimation.Text = Properties.Settings.Default.animation.ToString("00");
                chkOnTop.Checked = Properties.Settings.Default.alwaysOnTop;
                chkFullscreen.Checked = Properties.Settings.Default.fullscreen;

                // Set window location
                txtXPos.Text = Properties.Settings.Default.shufflerLocation.X.ToString();
                txtYPos.Text = Properties.Settings.Default.shufflerLocation.Y.ToString();
                txtListXPos.Text = Properties.Settings.Default.listLocation.X.ToString();
                txtListYPos.Text = Properties.Settings.Default.listLocation.Y.ToString();
                // Set window size
                txtWidth.Text = Properties.Settings.Default.shufflerSize.Width.ToString();
                txtHeight.Text = Properties.Settings.Default.shufflerSize.Height.ToString();
                txtListWidth.Text = Properties.Settings.Default.listSize.Width.ToString();
                txtListHeight.Text = Properties.Settings.Default.listSize.Height.ToString();

                TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
                Font startFont = (Font)converter.ConvertFromString(Properties.Settings.Default.font);
                Font listStartFont = (Font)converter.ConvertFromString(Properties.Settings.Default.listFont);
                fontDialog.Font = startFont;
                listFontDialog.Font = listStartFont;
                btnFont.Text = string.Format("Font: {0}", startFont.Name);
                btnFont.Font = new Font(startFont.FontFamily, 8);
                btnFont.ForeColor = Properties.Settings.Default.fontColor;
                fontDialog.Color = Properties.Settings.Default.fontColor;
                bgColorDialog.Color = Properties.Settings.Default.bgColor;
                btnFont.BackColor = bgColorDialog.Color;
                btnListFont.Text = string.Format("Font: {0}", listStartFont.Name);
                btnListFont.Font = new Font(listStartFont.FontFamily, 8);
                btnListFont.ForeColor = Properties.Settings.Default.listFontColor;
                listFontDialog.Color = Properties.Settings.Default.listFontColor;
                listBgColorDialog.Color = Properties.Settings.Default.listBgColor;
                btnListFont.BackColor = listBgColorDialog.Color;
                slctSource.SelectedIndex = Properties.Settings.Default.source;
                txtAutoNext.Text = Properties.Settings.Default.autoProceedStall.ToString();
                cboxAuto.Checked = Properties.Settings.Default.autoProceedCheck;
                txtItemList.Text = Properties.Settings.Default.itemlist;
                txtAnimation.Text = Properties.Settings.Default.animation.ToString();

                ListScreens();

                if (chkFullscreen.Checked == true)
                    slctScreenList.Visible = true;

                if (File.Exists(Properties.Settings.Default.sourcePath))
                {
                    lblSourcePath.Text = Properties.Settings.Default.sourcePath;
                    lblSourcePath.Visible = true;
                    txtItemListFromFile.Text = System.IO.File.ReadAllText(Properties.Settings.Default.sourcePath);
                    txtItemListFromFile.Visible = true;
                }

                if (slctSource.SelectedIndex == 1)
                {
                    txtItemList.Visible = false;
                    btnFile.Visible = true;
                }

                if (Properties.Settings.Default.autoProceedCheck == true)
                {
                    cboxAuto.Text = "automatically after";
                    txtAutoNext.Visible = true;
                    labelAutoProceed.Visible = true;
                }
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
            Application.Exit();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            SaveSettings();
            //Hide();

            int parsedValue;
            if (
                !int.TryParse(txtXPos.Text, out parsedValue)
                || !int.TryParse(txtYPos.Text, out parsedValue)
                || !int.TryParse(txtWidth.Text, out parsedValue)
                || !int.TryParse(txtHeight.Text, out parsedValue)
                || !int.TryParse(txtListXPos.Text, out parsedValue)
                || !int.TryParse(txtListYPos.Text, out parsedValue)
                || !int.TryParse(txtListWidth.Text, out parsedValue)
                || !int.TryParse(txtListHeight.Text, out parsedValue)
                )
            {
                MessageBox.Show("Only numbers are accepted in the Size and Location fields.");
            } else
            {
                timerWindow = new ShufflerWindow(this)
                {
                    Location = new Point(int.Parse(txtXPos.Text), int.Parse(txtYPos.Text)),
                    Size = new Size(int.Parse(txtWidth.Text), int.Parse(txtHeight.Text)),
                    locationXPass = txtXPos.Text,
                    locationYPass = txtYPos.Text,
                    sizeWidthPass = txtWidth.Text,
                    sizeHeightPass = txtHeight.Text,
                    fontPass = fontDialog.Font,
                    TopMost = chkOnTop.Checked,
                    fontColorPass = fontDialog.Color,
                    bgColorPass = bgColorDialog.Color,
                    autoNext = cboxAuto.Checked,
                    animationDuration = int.Parse(txtAnimation.Text)
                };

                if (slctSource.SelectedIndex == 1 && lblSourcePath.Text != "")
                {
                    timerWindow.itemlist = new List<string>(txtItemListFromFile.Lines);
                }
                else
                {
                    timerWindow.itemlist = new List<string>(txtItemList.Lines);
                }

                // remove blank lines from text entry
                List<string> tempitemlist = timerWindow.itemlist;
                tempitemlist.RemoveAll(p => string.IsNullOrEmpty(p));
                timerWindow.itemlist = tempitemlist;

                // change fullscreen monitor
                timerWindow.selectedScreen = Screen.PrimaryScreen;
                timerWindow.Bounds = Screen.PrimaryScreen.Bounds;
                if ((Screen.AllScreens.Length > 1) && (slctScreenList.SelectedIndex != 0))
                {
                    timerWindow.selectedScreen = Screen.AllScreens[slctScreenList.SelectedIndex];
                    timerWindow.Bounds = Screen.AllScreens[slctScreenList.SelectedIndex].Bounds;
                }

                if (chkFullscreen.Checked == true)
                {
                    timerWindow.WindowState = FormWindowState.Maximized;
                    timerWindow.fullscreen = true;
                }
                else
                {
                    timerWindow.WindowState = FormWindowState.Normal;
                }

                timerWindow.Show();


                // list window initialization
                if (chkDisableList.Checked == false)
                {
                    listWindow = new ListWindow(this)
                    {
                        Location = new Point(int.Parse(txtListXPos.Text), int.Parse(txtListYPos.Text)),
                        Size = new Size(int.Parse(txtListWidth.Text), int.Parse(txtListHeight.Text)),
                        locationXPass = txtListXPos.Text,
                        locationYPass = txtListYPos.Text,
                        sizeWidthPass = txtListWidth.Text,
                        sizeHeightPass = txtListHeight.Text,
                        fontPass = listFontDialog.Font,
                        TopMost = chkListOnTop.Checked,
                        fontColorPass = listFontDialog.Color,
                        bgColorPass = listBgColorDialog.Color,
                        fullscreen = chkListFullscreen.Checked,
                    };

                    if (chkListFullscreen.Checked == true)
                    {
                        listWindow.WindowState = FormWindowState.Maximized;
                        listWindow.fullscreen = true;
                    }
                    else
                    {
                        listWindow.WindowState = FormWindowState.Normal;
                    }

                    listWindow.selectedScreen = Screen.PrimaryScreen;
                    listWindow.Bounds = Screen.PrimaryScreen.Bounds;
                    if ((Screen.AllScreens.Length > 1) && (slctListScreenList.SelectedIndex != 0))
                    {
                        listWindow.selectedScreen = Screen.AllScreens[slctListScreenList.SelectedIndex];
                        listWindow.Bounds = Screen.AllScreens[slctListScreenList.SelectedIndex].Bounds;
                    }
                    listWindow.Show();
                }
            }
        }

        public void UpdateValues(List<string> options)
        {
            if (chkFullscreen.Checked == false)
            {
                txtWidth.Text = options[0];
                txtHeight.Text = options[1];
                txtXPos.Text = options[2];
                txtYPos.Text = options[3];
                if (options.Count > 4)
                {
                    txtListWidth.Text = options[4];
                    txtListHeight.Text = options[5];
                    txtListXPos.Text = options[6];
                    txtListYPos.Text = options[7];
                }
            } else if ((chkDisableList.Checked == false) && (chkListFullscreen.Checked == false)) {
                txtListWidth.Text = options[0];
                txtListHeight.Text = options[1];
                txtListXPos.Text = options[2];
                txtListYPos.Text = options[3];

            }
        }

        private void CheckListWindowSetting(bool disable)
        {
            if (disable == true)
            {
                chkDisableList.Text = "Create list window";
                txtListWidth.Enabled = false;
                txtListHeight.Enabled = false;
                txtListXPos.Enabled = false;
                txtListYPos.Enabled = false;
                chkListFullscreen.Enabled = false;
                chkListOnTop.Enabled = false;
                btnListFont.Enabled = false;
                btnListBgColor.Enabled = false;
            } else
            {
                chkDisableList.Text = "Do not create list window";
                txtListWidth.Enabled = true;
                txtListHeight.Enabled = true;
                txtListXPos.Enabled = true;
                txtListYPos.Enabled = true;
                chkListFullscreen.Enabled = true;
                chkListOnTop.Enabled = true;
                btnListFont.Enabled = true;
                btnListBgColor.Enabled = true;
            }
        }

        private void ChkFullscreen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFullscreen.Checked == true)
            {
                txtWidth.Enabled = false;
                txtHeight.Enabled = false;
                txtXPos.Enabled = false;
                txtYPos.Enabled = false;
                slctScreenList.Visible = true;
            }
            else
            {
                txtWidth.Enabled = true;
                txtHeight.Enabled = true;
                txtXPos.Enabled = true;
                txtYPos.Enabled = true;
                slctScreenList.Visible = false;
            }
        }

        private void Font_Click(object sender, EventArgs e)
        {
            // Show the dialog.
            fontDialog.ShowColor = true;
            if (Properties.Settings.Default.fontColor != null)
            {
                fontDialog.Color = Properties.Settings.Default.fontColor;
            }
            else
            {
                fontDialog.Color = Color.FromName("White");
            }

            DialogResult result = fontDialog.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                selectedFont = fontDialog.Font;
                // Set TextBox properties.
                btnFont.Text = string.Format("Font: {0}", selectedFont.Name);
                btnFont.Font = new Font(selectedFont.FontFamily, 8);
                btnFont.ForeColor = fontDialog.Color;
            }
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.shufflerLocation = new Point(int.Parse(txtXPos.Text), int.Parse(txtYPos.Text));
            Properties.Settings.Default.shufflerSize = new Size(int.Parse(txtWidth.Text), int.Parse(txtHeight.Text));
            Properties.Settings.Default.optionsLocation = this.Location;
            Properties.Settings.Default.optionsSize = this.Size;
            Properties.Settings.Default.listLocation = new Point(int.Parse(txtListXPos.Text), int.Parse(txtListYPos.Text));
            Properties.Settings.Default.listSize = new Size(int.Parse(txtListWidth.Text), int.Parse(txtListHeight.Text));
            Properties.Settings.Default.animation = int.Parse(txtAnimation.Text);
            Properties.Settings.Default.alwaysOnTop = chkOnTop.Checked;
            Properties.Settings.Default.fullscreen = chkFullscreen.Checked;
            Properties.Settings.Default.fontColor = fontDialog.Color;
            Properties.Settings.Default.bgColor = bgColorDialog.Color;
            Properties.Settings.Default.source = slctSource.SelectedIndex;
            Properties.Settings.Default.autoProceedCheck = cboxAuto.Checked;
            Properties.Settings.Default.autoProceedStall = int.Parse(txtAutoNext.Text);
            Properties.Settings.Default.itemlist = txtItemList.Text;
            Properties.Settings.Default.listFontColor = listFontDialog.Color;

            if(File.Exists(lblSourcePath.Text))
            {
                Properties.Settings.Default.sourcePath = lblSourcePath.Text;
            } else
            {
                Properties.Settings.Default.sourcePath = "";
            }
            

            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
            selectedFont = fontDialog.Font;
            listFont = listFontDialog.Font;
            string fontString = converter.ConvertToString(selectedFont);
            string listFontString = converter.ConvertToString(listFont);
            Properties.Settings.Default.font = fontString;
            Properties.Settings.Default.listFont = listFontString;


            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();

        }

        private void BtnBgColor_Click(object sender, EventArgs e)
        {
            DialogResult bgColorResult = bgColorDialog.ShowDialog();
            if (bgColorResult == DialogResult.OK)
            {
                Color bgColor = bgColorDialog.Color;
                btnFont.BackColor = bgColor;
            }
        }

        private void CboxAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxAuto.Checked == true)
            {
                cboxAuto.Text = "automatically after";
                txtAutoNext.Visible = true;
                labelAutoProceed.Visible = true;
            } else
            {
                cboxAuto.Text = "manually";
                txtAutoNext.Visible = false;
                labelAutoProceed.Visible = false;
            }
        }

        private void SlctSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (slctSource.SelectedIndex == 1)
            {
                txtItemList.Visible = false;
                btnFile.Visible = true;
                lblSourcePath.Visible = true;
            }
            else
            {
                txtItemList.Visible = true;
                btnFile.Visible = false;
                lblSourcePath.Visible = false;
            }

        }

        private void ListScreens()
        {
            int screenID = 0;
            foreach (Screen screen in Screen.AllScreens)
            {
                /*
                // For each screen, add the screen properties to a list box.
                listBox1.Items.Add("Device Name: " + screen.DeviceName);
                listBox1.Items.Add("Bounds: " + screen.Bounds.ToString());
                listBox1.Items.Add("Type: " + screen.GetType().ToString());
                listBox1.Items.Add("Working Area: " + screen.WorkingArea.ToString());
                listBox1.Items.Add("Primary Screen: " + screen.Primary.ToString());
                */

                string screenName = screen.DeviceName.Replace(@"\\.\", "");
                slctScreenList.Items.Add(screenName + ": " + screen.Bounds.Width.ToString() + "x" + screen.Bounds.Height.ToString());
                slctListScreenList.Items.Add(screenName + ": " + screen.Bounds.Width.ToString() + "x" + screen.Bounds.Height.ToString());

                if (screen.Primary == true)
                {
                    slctScreenList.SelectedIndex = screenID;
                    slctListScreenList.SelectedIndex = screenID;
                }

                screenID++;
            }
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt";
            ofd.Title = "Select a text file";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                lblSourcePath.Text = ofd.FileName;
        }

        public List<string> ShufflerWindowSettings
        {
            get
            {
                return new List<string>
                {
                    txtWidth.Text,
                    txtHeight.Text,
                    txtXPos.Text,
                    txtYPos.Text,
                    txtListWidth.Text,
                    txtListHeight.Text,
                    txtListXPos.Text,
                    txtListYPos.Text
                };
            }
            set { UpdateValues(value); }
        }

        public string ListWindowItems
        {
            get { return null; }
            set { listWindow.AddItem(value); }
        }

        private void ChkDisableList_CheckedChanged(object sender, EventArgs e)
        {
            CheckListWindowSetting(chkDisableList.Checked);
        }

        private void BtnListFont_Click(object sender, EventArgs e)
        {
            // Show the dialog.
            listFontDialog.ShowColor = true;
            if (Properties.Settings.Default.listFontColor != null)
            {
                listFontDialog.Color = Properties.Settings.Default.listFontColor;
            }
            else
            {
                listFontDialog.Color = Color.FromName("White");
            }

            DialogResult result = listFontDialog.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                listFont = listFontDialog.Font;
                // Set TextBox properties.
                btnListFont.Text = string.Format("Font: {0}", listFont.Name);
                btnListFont.Font = new Font(listFont.FontFamily, 8);
                btnListFont.ForeColor = listFontDialog.Color;
            }
        }

        private void BtnListBgColor_Click(object sender, EventArgs e)
        {
            DialogResult listBgColorResult = listBgColorDialog.ShowDialog();
            if (listBgColorResult == DialogResult.OK)
            {
                Color listBgColor = listBgColorDialog.Color;
                btnListFont.BackColor = listBgColor;
            }

        }

        private void ChkListFullscreen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkListFullscreen.Checked == true)
            {
                txtListWidth.Enabled = false;
                txtListHeight.Enabled = false;
                txtListXPos.Enabled = false;
                txtListYPos.Enabled = false;
                slctListScreenList.Visible = true;
            }
            else
            {
                txtListWidth.Enabled = true;
                txtListHeight.Enabled = true;
                txtListXPos.Enabled = true;
                txtListYPos.Enabled = true;
                slctListScreenList.Visible = false;
            }
        }

        public void CloseShufflers()
        {
            if ((chkFullscreen.Checked == false) && (chkDisableList.Checked == true) || ((chkDisableList.Checked == false) && (chkListFullscreen.Checked == true)))
            {
                ShufflerWindowSettings = new List<string>
                    {
                        timerWindow.Size.Width.ToString(),
                        timerWindow.Size.Height.ToString(),
                        timerWindow.Location.X.ToString(),
                        timerWindow.Location.Y.ToString()
                    };
            }
            else if ((chkFullscreen.Checked == false) && (chkDisableList.Checked == false) && (chkListFullscreen.Checked == false))
            {
                ShufflerWindowSettings = new List<string>
                    {
                        timerWindow.Size.Width.ToString(),
                        timerWindow.Size.Height.ToString(),
                        timerWindow.Location.X.ToString(),
                        timerWindow.Location.Y.ToString(),
                        listWindow.Size.Width.ToString(),
                        listWindow.Size.Height.ToString(),
                        listWindow.Location.X.ToString(),
                        listWindow.Location.Y.ToString(),
                    };

            }
            else if ((chkFullscreen.Checked == true) && (chkDisableList.Checked == false) && (chkListFullscreen.Checked == false))
            {
                ShufflerWindowSettings = new List<string>
                    {
                        listWindow.Size.Width.ToString(),
                        listWindow.Size.Height.ToString(),
                        listWindow.Location.X.ToString(),
                        listWindow.Location.Y.ToString(),
                    };

            }

            if (chkDisableList.Checked == false)
                listWindow.Close();
            timerWindow.Close();
        }
    }
}
