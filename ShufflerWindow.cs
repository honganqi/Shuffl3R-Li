using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace Shuffl3R_Li
{
    public partial class ShufflerWindow : DraggableForm
    {
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

        // shuffler variables
        private bool timerStatus;
        private bool shuffleStatus;
        private bool standbyStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer shuffleTimer;
        private System.Windows.Forms.Timer standbyTimer;
        public List<string> itemlist;
        private int randomNum;
        public int animationDuration;
        private int standbyDuration;
        public bool animationAuto;
        public bool autoNext;
        private int animationProgress;
        private int standbyProgress;

        private OptionsWindow optionsWindow = null;

        public ShufflerWindow(Form callOptionsWindow)
        {
            optionsWindow = callOptionsWindow as OptionsWindow;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void ShufflerWindow_FormLoad(object sender, EventArgs e)
        {
            /* screen/monitor settings
             * if not primary, fetch settings
             * if not maximized, fetch window settings (or probably secondary monitor, should manually fullscreened)
             */
            timer1 = new System.Windows.Forms.Timer();
            shuffleTimer = new System.Windows.Forms.Timer();
            standbyTimer = new System.Windows.Forms.Timer();

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

            timerDisplay.Font = fontPass;
            timerDisplay.ForeColor = fontColorPass;
            this.BackColor = bgColorPass;

            if (animationDuration > 0)
            {
                animationAuto = true;
                TimerInitialize();
                TimerStart();
            } else
            {
                animationAuto = false;
                ShuffleInitialize();
                ShuffleStart();
            }
        }

        private void TimerInitialize()
        {
            timer1.Tick += new EventHandler(Timer_Tick);
            timer1.Interval = 1000; // 1 second
            animationProgress = animationDuration;
            ShuffleInitialize();
        }

        private void ShuffleInitialize()
        {
            shuffleTimer.Tick += new EventHandler(Shuffle_Tick);
            shuffleTimer.Interval = 40; // 25 cycles per second
        }

        private void StandbyInitialize()
        {
            standbyTimer.Tick += new EventHandler(Standby_Tick);
            standbyTimer.Interval = 1000; // 1 second
            standbyProgress = standbyDuration;
        }

        private void TimerStart()
        {
            timer1.Start();
            timerStatus = true;
            animationProgress = animationDuration;
            ShuffleStart();
        }

        private void ShuffleStart()
        {
            shuffleTimer.Start();
            shuffleStatus = true;
        }

        private void StandbyStart()
        {
            StandbyInitialize();
            standbyTimer.Start();
            standbyStatus = true;
        }

        private void TimerStop()
        {
            timer1.Stop();
            timerStatus = false;
            ShuffleStop();
        }

        private void ShuffleStop()
        {
            shuffleTimer.Stop();
            shuffleStatus = false;
            optionsWindow.ListWindowItems = itemlist[randomNum];

            itemlist.RemoveAt(randomNum);

            if (autoNext == true)
                StandbyStart();
        }

        private void StandbyStop()
        {
            standbyTimer.Stop();
            standbyStatus = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (animationProgress > 1)
            {
                animationProgress--;
            }
            else
            {
                TimerStop();
            }
        }

        private void Shuffle_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            randomNum = rnd.Next(0, itemlist.Count);
            timerDisplay.Text = itemlist[randomNum];
        }

        private void Standby_Tick(object sender, EventArgs e)
        {
            if (standbyProgress > 1)
            {
                standbyProgress--;
            }
            else
            {
                StandbyStop();
                ProcessStartStop();
            }
        }

        private void ProcessStartStop()
        {
            if (itemlist.Count > 0)
            {
                if (animationAuto == true)
                {
                    if (timerStatus == false)
                    {
                        TimerStart();
                    }
                    else
                    {
                        TimerStop();
                    }
                }
                else
                {
                    if (shuffleStatus == false)
                    {
                        ShuffleStart();
                    }
                    else
                    {
                        ShuffleStop();
                    }
                }
            } else
            {
                MessageBox.Show("Done!");
            }
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                optionsWindow.CloseShufflers();
            }
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                ProcessStartStop();
            }
        }

        private void ShufflerDisplay_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (standbyTimer.Enabled == true)
                {
                    Console.WriteLine("standby");
                } else
                {
                    ProcessStartStop();
                }                
            }
            else
            {
                ShuffleStop();
            }
        }
    }
}
