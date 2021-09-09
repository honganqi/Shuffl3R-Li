namespace Shuffl3R_Li
{
    partial class OptionsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsWindow));
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.btnBgColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.txtYPos = new System.Windows.Forms.TextBox();
            this.txtXPos = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtAnimation = new System.Windows.Forms.TextBox();
            this.chkFullscreen = new System.Windows.Forms.CheckBox();
            this.chkOnTop = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.bgColorDialog = new System.Windows.Forms.ColorDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSourcePath = new System.Windows.Forms.Label();
            this.slctSource = new System.Windows.Forms.ComboBox();
            this.cboxAuto = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAutoNext = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.labelAutoProceed = new System.Windows.Forms.Label();
            this.txtItemList = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtItemListFromFile = new System.Windows.Forms.RichTextBox();
            this.slctScreenList = new System.Windows.Forms.ComboBox();
            this.slctListScreenList = new System.Windows.Forms.ComboBox();
            this.btnListBgColor = new System.Windows.Forms.Button();
            this.btnListFont = new System.Windows.Forms.Button();
            this.txtListYPos = new System.Windows.Forms.TextBox();
            this.txtListXPos = new System.Windows.Forms.TextBox();
            this.txtListHeight = new System.Windows.Forms.TextBox();
            this.txtListWidth = new System.Windows.Forms.TextBox();
            this.chkListFullscreen = new System.Windows.Forms.CheckBox();
            this.chkListOnTop = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.chkDisableList = new System.Windows.Forms.CheckBox();
            this.listFontDialog = new System.Windows.Forms.FontDialog();
            this.listBgColorDialog = new System.Windows.Forms.ColorDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label9.Location = new System.Drawing.Point(505, 632);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(339, 19);
            this.label9.TabIndex = 50;
            this.label9.Text = "Left-click:      Stop, Continue (also Spacebar and Enter)";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(484, 578);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(426, 2);
            this.label8.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label7.Location = new System.Drawing.Point(480, 601);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 32);
            this.label7.TabIndex = 48;
            this.label7.Text = "Shortcuts";
            // 
            // labelSeparator
            // 
            this.labelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeparator.Location = new System.Drawing.Point(486, 275);
            this.labelSeparator.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(426, 2);
            this.labelSeparator.TabIndex = 47;
            // 
            // btnBgColor
            // 
            this.btnBgColor.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnBgColor.Location = new System.Drawing.Point(585, 210);
            this.btnBgColor.Name = "btnBgColor";
            this.btnBgColor.Size = new System.Drawing.Size(205, 34);
            this.btnBgColor.TabIndex = 46;
            this.btnBgColor.Text = "Background Color";
            this.btnBgColor.UseVisualStyleBackColor = true;
            this.btnBgColor.Click += new System.EventHandler(this.BtnBgColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnFont.Location = new System.Drawing.Point(585, 171);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(205, 34);
            this.btnFont.TabIndex = 43;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.Font_Click);
            // 
            // txtYPos
            // 
            this.txtYPos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtYPos.Location = new System.Drawing.Point(657, 120);
            this.txtYPos.Name = "txtYPos";
            this.txtYPos.Size = new System.Drawing.Size(63, 30);
            this.txtYPos.TabIndex = 37;
            this.txtYPos.Text = "Y";
            this.txtYPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYPos.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtXPos
            // 
            this.txtXPos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtXPos.Location = new System.Drawing.Point(585, 120);
            this.txtXPos.Name = "txtXPos";
            this.txtXPos.Size = new System.Drawing.Size(63, 30);
            this.txtXPos.TabIndex = 36;
            this.txtXPos.Text = "X";
            this.txtXPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtXPos.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHeight.Location = new System.Drawing.Point(657, 80);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(63, 30);
            this.txtHeight.TabIndex = 35;
            this.txtHeight.Text = "height";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeight.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtWidth.Location = new System.Drawing.Point(585, 80);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(63, 30);
            this.txtWidth.TabIndex = 34;
            this.txtWidth.Text = "width";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWidth.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtAnimation
            // 
            this.txtAnimation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAnimation.Location = new System.Drawing.Point(165, 550);
            this.txtAnimation.MaxLength = 2;
            this.txtAnimation.Name = "txtAnimation";
            this.txtAnimation.Size = new System.Drawing.Size(37, 30);
            this.txtAnimation.TabIndex = 33;
            this.txtAnimation.Text = "00";
            this.txtAnimation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnimation.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // chkFullscreen
            // 
            this.chkFullscreen.AutoSize = true;
            this.chkFullscreen.BackColor = System.Drawing.SystemColors.Control;
            this.chkFullscreen.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.chkFullscreen.Location = new System.Drawing.Point(731, 85);
            this.chkFullscreen.Name = "chkFullscreen";
            this.chkFullscreen.Size = new System.Drawing.Size(91, 23);
            this.chkFullscreen.TabIndex = 42;
            this.chkFullscreen.Text = "Fullscreen";
            this.chkFullscreen.UseVisualStyleBackColor = false;
            this.chkFullscreen.CheckedChanged += new System.EventHandler(this.ChkFullscreen_CheckedChanged);
            // 
            // chkOnTop
            // 
            this.chkOnTop.AutoSize = true;
            this.chkOnTop.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.chkOnTop.Location = new System.Drawing.Point(731, 124);
            this.chkOnTop.Name = "chkOnTop";
            this.chkOnTop.Size = new System.Drawing.Size(122, 23);
            this.chkOnTop.TabIndex = 41;
            this.chkOnTop.Text = "Always On Top";
            this.chkOnTop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStart.Location = new System.Drawing.Point(165, 628);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(151, 41);
            this.btnStart.TabIndex = 38;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(483, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(483, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(63, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(461, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 32);
            this.label5.TabIndex = 56;
            this.label5.Text = "Shuffl3R Window";
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFile.Location = new System.Drawing.Point(283, 74);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(146, 37);
            this.btnFile.TabIndex = 61;
            this.btnFile.Text = "Browse";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Visible = false;
            this.btnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(461, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 32);
            this.label12.TabIndex = 62;
            this.label12.Text = "List Window";
            // 
            // lblSourcePath
            // 
            this.lblSourcePath.AutoSize = true;
            this.lblSourcePath.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSourcePath.Location = new System.Drawing.Point(63, 114);
            this.lblSourcePath.Name = "lblSourcePath";
            this.lblSourcePath.Size = new System.Drawing.Size(33, 19);
            this.lblSourcePath.TabIndex = 63;
            this.lblSourcePath.Text = "Text";
            this.lblSourcePath.Visible = false;
            // 
            // slctSource
            // 
            this.slctSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.slctSource.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.slctSource.FormattingEnabled = true;
            this.slctSource.Items.AddRange(new object[] {
            "Item List",
            "File"});
            this.slctSource.Location = new System.Drawing.Point(67, 75);
            this.slctSource.Name = "slctSource";
            this.slctSource.Size = new System.Drawing.Size(203, 36);
            this.slctSource.TabIndex = 64;
            this.slctSource.SelectedIndexChanged += new System.EventHandler(this.SlctSource_SelectedIndexChanged);
            // 
            // cboxAuto
            // 
            this.cboxAuto.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboxAuto.AutoSize = true;
            this.cboxAuto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxAuto.Location = new System.Drawing.Point(165, 586);
            this.cboxAuto.Margin = new System.Windows.Forms.Padding(2);
            this.cboxAuto.Name = "cboxAuto";
            this.cboxAuto.Size = new System.Drawing.Size(89, 33);
            this.cboxAuto.TabIndex = 65;
            this.cboxAuto.Text = "manually";
            this.cboxAuto.UseVisualStyleBackColor = true;
            this.cboxAuto.CheckedChanged += new System.EventHandler(this.CboxAuto_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(63, 591);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 66;
            this.label4.Text = "Proceed";
            // 
            // txtAutoNext
            // 
            this.txtAutoNext.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAutoNext.Location = new System.Drawing.Point(332, 587);
            this.txtAutoNext.Name = "txtAutoNext";
            this.txtAutoNext.Size = new System.Drawing.Size(37, 30);
            this.txtAutoNext.TabIndex = 67;
            this.txtAutoNext.Text = "0";
            this.txtAutoNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAutoNext.Visible = false;
            this.txtAutoNext.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label13.Location = new System.Drawing.Point(205, 556);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 19);
            this.label13.TabIndex = 68;
            this.label13.Text = "seconds";
            // 
            // labelAutoProceed
            // 
            this.labelAutoProceed.AutoSize = true;
            this.labelAutoProceed.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelAutoProceed.Location = new System.Drawing.Point(371, 594);
            this.labelAutoProceed.Name = "labelAutoProceed";
            this.labelAutoProceed.Size = new System.Drawing.Size(58, 19);
            this.labelAutoProceed.TabIndex = 69;
            this.labelAutoProceed.Text = "seconds";
            this.labelAutoProceed.Visible = false;
            // 
            // txtItemList
            // 
            this.txtItemList.Location = new System.Drawing.Point(67, 145);
            this.txtItemList.Name = "txtItemList";
            this.txtItemList.Size = new System.Drawing.Size(362, 391);
            this.txtItemList.TabIndex = 70;
            this.txtItemList.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(61, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(209, 32);
            this.label14.TabIndex = 73;
            this.label14.Text = "Shuffl3R Options";
            // 
            // txtItemListFromFile
            // 
            this.txtItemListFromFile.Enabled = false;
            this.txtItemListFromFile.Location = new System.Drawing.Point(67, 145);
            this.txtItemListFromFile.Name = "txtItemListFromFile";
            this.txtItemListFromFile.ReadOnly = true;
            this.txtItemListFromFile.Size = new System.Drawing.Size(362, 391);
            this.txtItemListFromFile.TabIndex = 74;
            this.txtItemListFromFile.TabStop = false;
            this.txtItemListFromFile.Text = "";
            this.txtItemListFromFile.Visible = false;
            // 
            // slctScreenList
            // 
            this.slctScreenList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.slctScreenList.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.slctScreenList.FormattingEnabled = true;
            this.slctScreenList.Location = new System.Drawing.Point(731, 123);
            this.slctScreenList.Name = "slctScreenList";
            this.slctScreenList.Size = new System.Drawing.Size(179, 25);
            this.slctScreenList.TabIndex = 75;
            this.slctScreenList.Visible = false;
            // 
            // slctListScreenList
            // 
            this.slctListScreenList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.slctListScreenList.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.slctListScreenList.FormattingEnabled = true;
            this.slctListScreenList.Location = new System.Drawing.Point(731, 418);
            this.slctListScreenList.Name = "slctListScreenList";
            this.slctListScreenList.Size = new System.Drawing.Size(179, 25);
            this.slctListScreenList.TabIndex = 86;
            this.slctListScreenList.Visible = false;
            // 
            // btnListBgColor
            // 
            this.btnListBgColor.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnListBgColor.Location = new System.Drawing.Point(585, 505);
            this.btnListBgColor.Name = "btnListBgColor";
            this.btnListBgColor.Size = new System.Drawing.Size(205, 34);
            this.btnListBgColor.TabIndex = 85;
            this.btnListBgColor.Text = "Background Color";
            this.btnListBgColor.UseVisualStyleBackColor = true;
            this.btnListBgColor.Click += new System.EventHandler(this.BtnListBgColor_Click);
            // 
            // btnListFont
            // 
            this.btnListFont.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnListFont.Location = new System.Drawing.Point(585, 466);
            this.btnListFont.Name = "btnListFont";
            this.btnListFont.Size = new System.Drawing.Size(205, 34);
            this.btnListFont.TabIndex = 84;
            this.btnListFont.Text = "Font";
            this.btnListFont.UseVisualStyleBackColor = true;
            this.btnListFont.Click += new System.EventHandler(this.BtnListFont_Click);
            // 
            // txtListYPos
            // 
            this.txtListYPos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtListYPos.Location = new System.Drawing.Point(657, 415);
            this.txtListYPos.Name = "txtListYPos";
            this.txtListYPos.Size = new System.Drawing.Size(63, 30);
            this.txtListYPos.TabIndex = 81;
            this.txtListYPos.Text = "Y";
            this.txtListYPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtListXPos
            // 
            this.txtListXPos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtListXPos.Location = new System.Drawing.Point(585, 415);
            this.txtListXPos.Name = "txtListXPos";
            this.txtListXPos.Size = new System.Drawing.Size(63, 30);
            this.txtListXPos.TabIndex = 80;
            this.txtListXPos.Text = "X";
            this.txtListXPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtListHeight
            // 
            this.txtListHeight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtListHeight.Location = new System.Drawing.Point(657, 375);
            this.txtListHeight.Name = "txtListHeight";
            this.txtListHeight.Size = new System.Drawing.Size(63, 30);
            this.txtListHeight.TabIndex = 79;
            this.txtListHeight.Text = "height";
            this.txtListHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtListWidth
            // 
            this.txtListWidth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtListWidth.Location = new System.Drawing.Point(585, 375);
            this.txtListWidth.Name = "txtListWidth";
            this.txtListWidth.Size = new System.Drawing.Size(63, 30);
            this.txtListWidth.TabIndex = 78;
            this.txtListWidth.Text = "width";
            this.txtListWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkListFullscreen
            // 
            this.chkListFullscreen.AutoSize = true;
            this.chkListFullscreen.BackColor = System.Drawing.SystemColors.Control;
            this.chkListFullscreen.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.chkListFullscreen.Location = new System.Drawing.Point(731, 380);
            this.chkListFullscreen.Name = "chkListFullscreen";
            this.chkListFullscreen.Size = new System.Drawing.Size(91, 23);
            this.chkListFullscreen.TabIndex = 83;
            this.chkListFullscreen.Text = "Fullscreen";
            this.chkListFullscreen.UseVisualStyleBackColor = false;
            this.chkListFullscreen.CheckedChanged += new System.EventHandler(this.ChkListFullscreen_CheckedChanged);
            // 
            // chkListOnTop
            // 
            this.chkListOnTop.AutoSize = true;
            this.chkListOnTop.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.chkListOnTop.Location = new System.Drawing.Point(731, 419);
            this.chkListOnTop.Name = "chkListOnTop";
            this.chkListOnTop.Size = new System.Drawing.Size(122, 23);
            this.chkListOnTop.TabIndex = 82;
            this.chkListOnTop.Text = "Always On Top";
            this.chkListOnTop.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(483, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 77;
            this.label6.Text = "Location";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label15.Location = new System.Drawing.Point(483, 378);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 23);
            this.label15.TabIndex = 76;
            this.label15.Text = "Size";
            // 
            // chkDisableList
            // 
            this.chkDisableList.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDisableList.AutoSize = true;
            this.chkDisableList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkDisableList.Location = new System.Drawing.Point(585, 330);
            this.chkDisableList.Name = "chkDisableList";
            this.chkDisableList.Size = new System.Drawing.Size(214, 33);
            this.chkDisableList.TabIndex = 87;
            this.chkDisableList.Text = "Do not create list window";
            this.chkDisableList.UseVisualStyleBackColor = true;
            this.chkDisableList.CheckedChanged += new System.EventHandler(this.ChkDisableList_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label10.Location = new System.Drawing.Point(505, 653);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(278, 19);
            this.label10.TabIndex = 88;
            this.label10.Text = "Esc:               Close shuffler and list windows";
            // 
            // OptionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 696);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkDisableList);
            this.Controls.Add(this.slctListScreenList);
            this.Controls.Add(this.btnListBgColor);
            this.Controls.Add(this.btnListFont);
            this.Controls.Add(this.txtListYPos);
            this.Controls.Add(this.txtListXPos);
            this.Controls.Add(this.txtListHeight);
            this.Controls.Add(this.txtListWidth);
            this.Controls.Add(this.chkListFullscreen);
            this.Controls.Add(this.chkListOnTop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.slctScreenList);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelAutoProceed);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAutoNext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxAuto);
            this.Controls.Add(this.slctSource);
            this.Controls.Add(this.lblSourcePath);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelSeparator);
            this.Controls.Add(this.btnBgColor);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.txtYPos);
            this.Controls.Add(this.txtXPos);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtAnimation);
            this.Controls.Add(this.chkFullscreen);
            this.Controls.Add(this.chkOnTop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemList);
            this.Controls.Add(this.txtItemListFromFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsWindow";
            this.Text = "Shuffl3R Li";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.Button btnBgColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.TextBox txtYPos;
        private System.Windows.Forms.TextBox txtXPos;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtAnimation;
        private System.Windows.Forms.CheckBox chkFullscreen;
        private System.Windows.Forms.CheckBox chkOnTop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog bgColorDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSourcePath;
        private System.Windows.Forms.ComboBox slctSource;
        private System.Windows.Forms.CheckBox cboxAuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAutoNext;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelAutoProceed;
        private System.Windows.Forms.RichTextBox txtItemList;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox txtItemListFromFile;
        private System.Windows.Forms.ComboBox slctScreenList;
        private System.Windows.Forms.ComboBox slctListScreenList;
        private System.Windows.Forms.Button btnListBgColor;
        private System.Windows.Forms.Button btnListFont;
        private System.Windows.Forms.TextBox txtListYPos;
        private System.Windows.Forms.TextBox txtListXPos;
        private System.Windows.Forms.TextBox txtListHeight;
        private System.Windows.Forms.TextBox txtListWidth;
        private System.Windows.Forms.CheckBox chkListFullscreen;
        private System.Windows.Forms.CheckBox chkListOnTop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkDisableList;
        private System.Windows.Forms.FontDialog listFontDialog;
        private System.Windows.Forms.ColorDialog listBgColorDialog;
        private System.Windows.Forms.Label label10;
    }
}

