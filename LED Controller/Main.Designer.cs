namespace LED_Controller
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.ssMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPorts = new System.Windows.Forms.ToolStripMenuItem();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tbsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpHover = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHovSave = new System.Windows.Forms.Button();
            this.htbHover = new LED_Controller.HexTextBox();
            this.pnlHBlue = new System.Windows.Forms.Panel();
            this.pnlHGreen = new System.Windows.Forms.Panel();
            this.pnlHRed = new System.Windows.Forms.Panel();
            this.rgbHBlue = new LED_Controller.rgbNUD();
            this.rgbHGreen = new LED_Controller.rgbNUD();
            this.rgbHRed = new LED_Controller.rgbNUD();
            this.lblHBlue = new System.Windows.Forms.Label();
            this.lblHGreen = new System.Windows.Forms.Label();
            this.lblHRed = new System.Windows.Forms.Label();
            this.grpSaved = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.htbSaved = new LED_Controller.HexTextBox();
            this.pnlSBlue = new System.Windows.Forms.Panel();
            this.pnlSGreen = new System.Windows.Forms.Panel();
            this.pnlSRed = new System.Windows.Forms.Panel();
            this.rgbSBlue = new LED_Controller.rgbNUD();
            this.rgbSGreen = new LED_Controller.rgbNUD();
            this.rgbSRed = new LED_Controller.rgbNUD();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlSavedColor = new System.Windows.Forms.Panel();
            this.pnlHoverColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.ArduinoPort = new System.IO.Ports.SerialPort(this.components);
            this.tpTips = new System.Windows.Forms.ToolTip(this.components);
            this.cpcColors = new LED_Controller.ColorPickerControl();
            this.ssMenu.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.grpHover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbHBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbHGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbHRed)).BeginInit();
            this.grpSaved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbSBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbSGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbSRed)).BeginInit();
            this.SuspendLayout();
            // 
            // ssMenu
            // 
            this.ssMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiSettings});
            this.ssMenu.Location = new System.Drawing.Point(0, 0);
            this.ssMenu.Name = "ssMenu";
            this.ssMenu.Size = new System.Drawing.Size(384, 24);
            this.ssMenu.TabIndex = 0;
            this.ssMenu.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.tsmiOpen,
            this.tsmiAbout,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(107, 22);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(107, 22);
            this.tsmiOpen.Text = "Open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(107, 22);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(107, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRefresh,
            this.tsmiPorts});
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(61, 20);
            this.tsmiSettings.Text = "Settings";
            // 
            // tsmiRefresh
            // 
            this.tsmiRefresh.Name = "tsmiRefresh";
            this.tsmiRefresh.Size = new System.Drawing.Size(113, 22);
            this.tsmiRefresh.Text = "Refresh";
            this.tsmiRefresh.Click += new System.EventHandler(this.tsmiRefresh_Click);
            // 
            // tsmiPorts
            // 
            this.tsmiPorts.Name = "tsmiPorts";
            this.tsmiPorts.Size = new System.Drawing.Size(113, 22);
            this.tsmiPorts.Text = "Ports";
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsStatus});
            this.ssStatus.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ssStatus.Location = new System.Drawing.Point(0, 324);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(384, 20);
            this.ssStatus.TabIndex = 1;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tbsStatus
            // 
            this.tbsStatus.Name = "tbsStatus";
            this.tbsStatus.Size = new System.Drawing.Size(88, 15);
            this.tbsStatus.Text = "Not Connected";
            // 
            // grpHover
            // 
            this.grpHover.Controls.Add(this.label6);
            this.grpHover.Controls.Add(this.btnHovSave);
            this.grpHover.Controls.Add(this.htbHover);
            this.grpHover.Controls.Add(this.pnlHBlue);
            this.grpHover.Controls.Add(this.pnlHGreen);
            this.grpHover.Controls.Add(this.pnlHRed);
            this.grpHover.Controls.Add(this.rgbHBlue);
            this.grpHover.Controls.Add(this.rgbHGreen);
            this.grpHover.Controls.Add(this.rgbHRed);
            this.grpHover.Controls.Add(this.lblHBlue);
            this.grpHover.Controls.Add(this.lblHGreen);
            this.grpHover.Controls.Add(this.lblHRed);
            this.grpHover.Location = new System.Drawing.Point(249, 27);
            this.grpHover.Name = "grpHover";
            this.grpHover.Size = new System.Drawing.Size(127, 122);
            this.grpHover.TabIndex = 2;
            this.grpHover.TabStop = false;
            this.grpHover.Text = "Hover Color";
            this.grpHover.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "HEX";
            // 
            // btnHovSave
            // 
            this.btnHovSave.Location = new System.Drawing.Point(107, 98);
            this.btnHovSave.Name = "btnHovSave";
            this.btnHovSave.Size = new System.Drawing.Size(18, 21);
            this.btnHovSave.TabIndex = 9;
            this.btnHovSave.Text = "S";
            this.tpTips.SetToolTip(this.btnHovSave, "Make current hover color Saved Color");
            this.btnHovSave.UseVisualStyleBackColor = true;
            this.btnHovSave.Click += new System.EventHandler(this.btnHovSave_Click);
            // 
            // htbHover
            // 
            this.htbHover.Location = new System.Drawing.Point(41, 98);
            this.htbHover.MaxLength = 6;
            this.htbHover.Name = "htbHover";
            this.htbHover.Size = new System.Drawing.Size(65, 20);
            this.htbHover.TabIndex = 8;
            this.htbHover.Text = "";
            this.htbHover.TextChanged += new System.EventHandler(this.htbHover_TextChanged);
            // 
            // pnlHBlue
            // 
            this.pnlHBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHBlue.Location = new System.Drawing.Point(87, 72);
            this.pnlHBlue.Name = "pnlHBlue";
            this.pnlHBlue.Size = new System.Drawing.Size(34, 20);
            this.pnlHBlue.TabIndex = 7;
            // 
            // pnlHGreen
            // 
            this.pnlHGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHGreen.Location = new System.Drawing.Point(87, 46);
            this.pnlHGreen.Name = "pnlHGreen";
            this.pnlHGreen.Size = new System.Drawing.Size(34, 20);
            this.pnlHGreen.TabIndex = 7;
            // 
            // pnlHRed
            // 
            this.pnlHRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHRed.Location = new System.Drawing.Point(87, 19);
            this.pnlHRed.Name = "pnlHRed";
            this.pnlHRed.Size = new System.Drawing.Size(34, 20);
            this.pnlHRed.TabIndex = 6;
            // 
            // rgbHBlue
            // 
            this.rgbHBlue.iValue = 0;
            this.rgbHBlue.Location = new System.Drawing.Point(41, 72);
            this.rgbHBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.rgbHBlue.Name = "rgbHBlue";
            this.rgbHBlue.Size = new System.Drawing.Size(41, 20);
            this.rgbHBlue.TabIndex = 5;
            this.rgbHBlue.ValueChanged += new System.EventHandler(this.rgbHBlue_ValueChanged);
            // 
            // rgbHGreen
            // 
            this.rgbHGreen.iValue = 0;
            this.rgbHGreen.Location = new System.Drawing.Point(41, 46);
            this.rgbHGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.rgbHGreen.Name = "rgbHGreen";
            this.rgbHGreen.Size = new System.Drawing.Size(40, 20);
            this.rgbHGreen.TabIndex = 4;
            this.rgbHGreen.ValueChanged += new System.EventHandler(this.rgbHGreen_ValueChanged);
            // 
            // rgbHRed
            // 
            this.rgbHRed.iValue = 0;
            this.rgbHRed.Location = new System.Drawing.Point(41, 19);
            this.rgbHRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.rgbHRed.Name = "rgbHRed";
            this.rgbHRed.Size = new System.Drawing.Size(40, 20);
            this.rgbHRed.TabIndex = 3;
            this.rgbHRed.ValueChanged += new System.EventHandler(this.rgbHRed_ValueChanged);
            // 
            // lblHBlue
            // 
            this.lblHBlue.AutoSize = true;
            this.lblHBlue.Location = new System.Drawing.Point(11, 76);
            this.lblHBlue.Name = "lblHBlue";
            this.lblHBlue.Size = new System.Drawing.Size(28, 13);
            this.lblHBlue.TabIndex = 2;
            this.lblHBlue.Text = "Blue";
            // 
            // lblHGreen
            // 
            this.lblHGreen.AutoSize = true;
            this.lblHGreen.Location = new System.Drawing.Point(3, 50);
            this.lblHGreen.Name = "lblHGreen";
            this.lblHGreen.Size = new System.Drawing.Size(36, 13);
            this.lblHGreen.TabIndex = 1;
            this.lblHGreen.Text = "Green";
            // 
            // lblHRed
            // 
            this.lblHRed.AutoSize = true;
            this.lblHRed.Location = new System.Drawing.Point(12, 23);
            this.lblHRed.Name = "lblHRed";
            this.lblHRed.Size = new System.Drawing.Size(27, 13);
            this.lblHRed.TabIndex = 0;
            this.lblHRed.Text = "Red";
            // 
            // grpSaved
            // 
            this.grpSaved.Controls.Add(this.label7);
            this.grpSaved.Controls.Add(this.htbSaved);
            this.grpSaved.Controls.Add(this.pnlSBlue);
            this.grpSaved.Controls.Add(this.pnlSGreen);
            this.grpSaved.Controls.Add(this.pnlSRed);
            this.grpSaved.Controls.Add(this.rgbSBlue);
            this.grpSaved.Controls.Add(this.rgbSGreen);
            this.grpSaved.Controls.Add(this.rgbSRed);
            this.grpSaved.Controls.Add(this.label3);
            this.grpSaved.Controls.Add(this.label4);
            this.grpSaved.Controls.Add(this.label5);
            this.grpSaved.Location = new System.Drawing.Point(249, 155);
            this.grpSaved.Name = "grpSaved";
            this.grpSaved.Size = new System.Drawing.Size(127, 123);
            this.grpSaved.TabIndex = 3;
            this.grpSaved.TabStop = false;
            this.grpSaved.Text = "Saved Color";
            this.grpSaved.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "HEX";
            // 
            // htbSaved
            // 
            this.htbSaved.Location = new System.Drawing.Point(41, 98);
            this.htbSaved.MaxLength = 6;
            this.htbSaved.Name = "htbSaved";
            this.htbSaved.Size = new System.Drawing.Size(65, 20);
            this.htbSaved.TabIndex = 17;
            this.htbSaved.Text = "";
            this.htbSaved.TextChanged += new System.EventHandler(this.htbSaved_TextChanged);
            // 
            // pnlSBlue
            // 
            this.pnlSBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSBlue.Location = new System.Drawing.Point(87, 72);
            this.pnlSBlue.Name = "pnlSBlue";
            this.pnlSBlue.Size = new System.Drawing.Size(34, 20);
            this.pnlSBlue.TabIndex = 15;
            // 
            // pnlSGreen
            // 
            this.pnlSGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSGreen.Location = new System.Drawing.Point(87, 46);
            this.pnlSGreen.Name = "pnlSGreen";
            this.pnlSGreen.Size = new System.Drawing.Size(34, 20);
            this.pnlSGreen.TabIndex = 16;
            // 
            // pnlSRed
            // 
            this.pnlSRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSRed.Location = new System.Drawing.Point(87, 19);
            this.pnlSRed.Name = "pnlSRed";
            this.pnlSRed.Size = new System.Drawing.Size(34, 20);
            this.pnlSRed.TabIndex = 14;
            // 
            // rgbSBlue
            // 
            this.rgbSBlue.iValue = 0;
            this.rgbSBlue.Location = new System.Drawing.Point(41, 72);
            this.rgbSBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.rgbSBlue.Name = "rgbSBlue";
            this.rgbSBlue.Size = new System.Drawing.Size(41, 20);
            this.rgbSBlue.TabIndex = 13;
            this.rgbSBlue.ValueChanged += new System.EventHandler(this.rgbSBlue_ValueChanged);
            // 
            // rgbSGreen
            // 
            this.rgbSGreen.iValue = 0;
            this.rgbSGreen.Location = new System.Drawing.Point(41, 46);
            this.rgbSGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.rgbSGreen.Name = "rgbSGreen";
            this.rgbSGreen.Size = new System.Drawing.Size(40, 20);
            this.rgbSGreen.TabIndex = 12;
            this.rgbSGreen.ValueChanged += new System.EventHandler(this.rgbSGreen_ValueChanged);
            // 
            // rgbSRed
            // 
            this.rgbSRed.iValue = 0;
            this.rgbSRed.Location = new System.Drawing.Point(41, 19);
            this.rgbSRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.rgbSRed.Name = "rgbSRed";
            this.rgbSRed.Size = new System.Drawing.Size(40, 20);
            this.rgbSRed.TabIndex = 11;
            this.rgbSRed.ValueChanged += new System.EventHandler(this.rgbSRed_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Blue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Green";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Red";
            // 
            // pnlSavedColor
            // 
            this.pnlSavedColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSavedColor.Location = new System.Drawing.Point(6, 194);
            this.pnlSavedColor.Name = "pnlSavedColor";
            this.pnlSavedColor.Size = new System.Drawing.Size(102, 96);
            this.pnlSavedColor.TabIndex = 5;
            this.tpTips.SetToolTip(this.pnlSavedColor, "Current saved color");
            // 
            // pnlHoverColor
            // 
            this.pnlHoverColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHoverColor.Location = new System.Drawing.Point(134, 197);
            this.pnlHoverColor.Name = "pnlHoverColor";
            this.pnlHoverColor.Size = new System.Drawing.Size(107, 96);
            this.pnlHoverColor.TabIndex = 6;
            this.tpTips.SetToolTip(this.pnlHoverColor, "Current hover color");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Saved";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hover";
            // 
            // btnAdvance
            // 
            this.btnAdvance.Location = new System.Drawing.Point(186, 298);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(54, 23);
            this.btnAdvance.TabIndex = 9;
            this.btnAdvance.Text = "More ->";
            this.tpTips.SetToolTip(this.btnAdvance, "Show more color info");
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(6, 298);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 10;
            this.btnSet.Text = "Set";
            this.tpTips.SetToolTip(this.btnSet, "Set LEDs as current Saved color");
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // ArduinoPort
            // 
            this.ArduinoPort.BaudRate = 115200;
            // 
            // cpcColors
            // 
            this.cpcColors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpcColors.HoverColor = System.Drawing.Color.Empty;
            this.cpcColors.Location = new System.Drawing.Point(9, 27);
            this.cpcColors.Name = "cpcColors";
            this.cpcColors.SelectedColor = System.Drawing.Color.Empty;
            this.cpcColors.Size = new System.Drawing.Size(231, 144);
            this.cpcColors.TabIndex = 4;
            this.cpcColors.Text = "colorPickerControl1";
            this.cpcColors.ColorPicked += new System.EventHandler(this.cpcColors_ColorPicked);
            this.cpcColors.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cpcColors_MouseMove);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 344);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnAdvance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlHoverColor);
            this.Controls.Add(this.pnlSavedColor);
            this.Controls.Add(this.cpcColors);
            this.Controls.Add(this.grpSaved);
            this.Controls.Add(this.grpHover);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.ssMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.ssMenu;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(265, 382);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "LED Controller";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ssMenu.ResumeLayout(false);
            this.ssMenu.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.grpHover.ResumeLayout(false);
            this.grpHover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbHBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbHGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbHRed)).EndInit();
            this.grpSaved.ResumeLayout(false);
            this.grpSaved.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbSBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbSGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbSRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ssMenu;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tbsStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
        private System.Windows.Forms.ToolStripMenuItem tsmiPorts;
        private System.Windows.Forms.GroupBox grpHover;
        private System.Windows.Forms.GroupBox grpSaved;
        private System.Windows.Forms.Label lblHBlue;
        private System.Windows.Forms.Label lblHGreen;
        private System.Windows.Forms.Label lblHRed;
        private ColorPickerControl cpcColors;
        private rgbNUD rgbHBlue;
        private rgbNUD rgbHGreen;
        private rgbNUD rgbHRed;
        private System.Windows.Forms.Panel pnlSavedColor;
        private System.Windows.Forms.Panel pnlHoverColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.Button btnSet;
        private System.IO.Ports.SerialPort ArduinoPort;
        private System.Windows.Forms.ToolTip tpTips;
        private System.Windows.Forms.Panel pnlHBlue;
        private System.Windows.Forms.Panel pnlHGreen;
        private System.Windows.Forms.Panel pnlHRed;
        private System.Windows.Forms.Panel pnlSBlue;
        private System.Windows.Forms.Panel pnlSGreen;
        private System.Windows.Forms.Panel pnlSRed;
        private rgbNUD rgbSBlue;
        private rgbNUD rgbSGreen;
        private rgbNUD rgbSRed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private HexTextBox htbHover;
        private System.Windows.Forms.Button btnHovSave;
        private HexTextBox htbSaved;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

