namespace VolControl
{
    partial class Form1
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
            this.lblMasterVol = new System.Windows.Forms.Label();
            this.App1btnChangeVol = new System.Windows.Forms.Button();
            this.App1apps = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.App1trkBarTarVol = new System.Windows.Forms.TrackBar();
            this.lblTargVol = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.App1TarVolpnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAppVol = new System.Windows.Forms.Label();
            this.App1CurVolpnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.App1trkBarCurVol = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCurVol = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.App1processes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.App2processes = new System.Windows.Forms.ComboBox();
            this.App2CurVolpnl = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.App2trkBarCurVol = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.App2lblCurVol = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.App2TarVolpnl = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.App2trkBarTarVol = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.App2lblTarVol = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.App2apps = new System.Windows.Forms.ComboBox();
            this.App2btnChangeVol = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.App1trkBarTarVol)).BeginInit();
            this.App1TarVolpnl.SuspendLayout();
            this.App1CurVolpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.App1trkBarCurVol)).BeginInit();
            this.App2CurVolpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.App2trkBarCurVol)).BeginInit();
            this.App2TarVolpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.App2trkBarTarVol)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMasterVol
            // 
            this.lblMasterVol.AutoSize = true;
            this.lblMasterVol.Location = new System.Drawing.Point(35, 542);
            this.lblMasterVol.Name = "lblMasterVol";
            this.lblMasterVol.Size = new System.Drawing.Size(80, 13);
            this.lblMasterVol.TabIndex = 0;
            this.lblMasterVol.Text = "Master Volume:";
            // 
            // App1btnChangeVol
            // 
            this.App1btnChangeVol.Location = new System.Drawing.Point(9, 472);
            this.App1btnChangeVol.Name = "App1btnChangeVol";
            this.App1btnChangeVol.Size = new System.Drawing.Size(240, 23);
            this.App1btnChangeVol.TabIndex = 2;
            this.App1btnChangeVol.Text = "Change Volume";
            this.App1btnChangeVol.UseVisualStyleBackColor = true;
            this.App1btnChangeVol.Click += new System.EventHandler(this.App1btnChangeVol_Click);
            // 
            // App1apps
            // 
            this.App1apps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.App1apps.FormattingEnabled = true;
            this.App1apps.Location = new System.Drawing.Point(7, 31);
            this.App1apps.Name = "App1apps";
            this.App1apps.Size = new System.Drawing.Size(240, 21);
            this.App1apps.TabIndex = 3;
            this.App1apps.SelectedIndexChanged += new System.EventHandler(this.App1apps_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Target App:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // App1trkBarTarVol
            // 
            this.App1trkBarTarVol.Location = new System.Drawing.Point(38, 49);
            this.App1trkBarTarVol.Maximum = 100;
            this.App1trkBarTarVol.Name = "App1trkBarTarVol";
            this.App1trkBarTarVol.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.App1trkBarTarVol.Size = new System.Drawing.Size(45, 295);
            this.App1trkBarTarVol.TabIndex = 5;
            this.App1trkBarTarVol.TickFrequency = 10;
            this.App1trkBarTarVol.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.App1trkBarTarVol.ValueChanged += new System.EventHandler(this.App1trkBarTarVol_ValueChanged);
            // 
            // lblTargVol
            // 
            this.lblTargVol.Location = new System.Drawing.Point(22, 33);
            this.lblTargVol.Name = "lblTargVol";
            this.lblTargVol.Size = new System.Drawing.Size(76, 13);
            this.lblTargVol.TabIndex = 6;
            this.lblTargVol.Text = "0";
            this.lblTargVol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "0%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "100%";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // App1TarVolpnl
            // 
            this.App1TarVolpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.App1TarVolpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.App1TarVolpnl.Controls.Add(this.label1);
            this.App1TarVolpnl.Controls.Add(this.App1trkBarTarVol);
            this.App1TarVolpnl.Controls.Add(this.label6);
            this.App1TarVolpnl.Controls.Add(this.lblTargVol);
            this.App1TarVolpnl.Controls.Add(this.label5);
            this.App1TarVolpnl.Location = new System.Drawing.Point(132, 119);
            this.App1TarVolpnl.Name = "App1TarVolpnl";
            this.App1TarVolpnl.Size = new System.Drawing.Size(117, 347);
            this.App1TarVolpnl.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "2nd Volume:";
            // 
            // lblAppVol
            // 
            this.lblAppVol.AutoSize = true;
            this.lblAppVol.Location = new System.Drawing.Point(156, 542);
            this.lblAppVol.Name = "lblAppVol";
            this.lblAppVol.Size = new System.Drawing.Size(67, 13);
            this.lblAppVol.TabIndex = 10;
            this.lblAppVol.Text = "App Volume:";
            // 
            // App1CurVolpnl
            // 
            this.App1CurVolpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.App1CurVolpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.App1CurVolpnl.Controls.Add(this.label4);
            this.App1CurVolpnl.Controls.Add(this.App1trkBarCurVol);
            this.App1CurVolpnl.Controls.Add(this.label7);
            this.App1CurVolpnl.Controls.Add(this.lblCurVol);
            this.App1CurVolpnl.Controls.Add(this.label9);
            this.App1CurVolpnl.Location = new System.Drawing.Point(9, 119);
            this.App1CurVolpnl.Name = "App1CurVolpnl";
            this.App1CurVolpnl.Size = new System.Drawing.Size(117, 347);
            this.App1CurVolpnl.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "1st Volume:";
            // 
            // App1trkBarCurVol
            // 
            this.App1trkBarCurVol.Location = new System.Drawing.Point(38, 49);
            this.App1trkBarCurVol.Maximum = 100;
            this.App1trkBarCurVol.Name = "App1trkBarCurVol";
            this.App1trkBarCurVol.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.App1trkBarCurVol.Size = new System.Drawing.Size(45, 295);
            this.App1trkBarCurVol.TabIndex = 5;
            this.App1trkBarCurVol.TickFrequency = 10;
            this.App1trkBarCurVol.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.App1trkBarCurVol.ValueChanged += new System.EventHandler(this.App1trkBarCurVol_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "100%";
            // 
            // lblCurVol
            // 
            this.lblCurVol.Location = new System.Drawing.Point(22, 33);
            this.lblCurVol.Name = "lblCurVol";
            this.lblCurVol.Size = new System.Drawing.Size(76, 13);
            this.lblCurVol.TabIndex = 6;
            this.lblCurVol.Text = "0";
            this.lblCurVol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "0%";
            // 
            // App1processes
            // 
            this.App1processes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.App1processes.FormattingEnabled = true;
            this.App1processes.Location = new System.Drawing.Point(7, 83);
            this.App1processes.Name = "App1processes";
            this.App1processes.Size = new System.Drawing.Size(240, 21);
            this.App1processes.TabIndex = 11;
            this.App1processes.SelectedIndexChanged += new System.EventHandler(this.App1processes_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(4, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Target Process:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Target Process:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // App2processes
            // 
            this.App2processes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.App2processes.FormattingEnabled = true;
            this.App2processes.Location = new System.Drawing.Point(7, 83);
            this.App2processes.Name = "App2processes";
            this.App2processes.Size = new System.Drawing.Size(240, 21);
            this.App2processes.TabIndex = 18;
            this.App2processes.SelectedIndexChanged += new System.EventHandler(this.App2processes_SelectedIndexChanged);
            // 
            // App2CurVolpnl
            // 
            this.App2CurVolpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.App2CurVolpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.App2CurVolpnl.Controls.Add(this.label10);
            this.App2CurVolpnl.Controls.Add(this.App2trkBarCurVol);
            this.App2CurVolpnl.Controls.Add(this.label11);
            this.App2CurVolpnl.Controls.Add(this.App2lblCurVol);
            this.App2CurVolpnl.Controls.Add(this.label13);
            this.App2CurVolpnl.Location = new System.Drawing.Point(9, 119);
            this.App2CurVolpnl.Name = "App2CurVolpnl";
            this.App2CurVolpnl.Size = new System.Drawing.Size(117, 347);
            this.App2CurVolpnl.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "1st Volume:";
            // 
            // App2trkBarCurVol
            // 
            this.App2trkBarCurVol.Location = new System.Drawing.Point(38, 49);
            this.App2trkBarCurVol.Maximum = 100;
            this.App2trkBarCurVol.Name = "App2trkBarCurVol";
            this.App2trkBarCurVol.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.App2trkBarCurVol.Size = new System.Drawing.Size(45, 295);
            this.App2trkBarCurVol.TabIndex = 5;
            this.App2trkBarCurVol.TickFrequency = 10;
            this.App2trkBarCurVol.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.App2trkBarCurVol.ValueChanged += new System.EventHandler(this.App2trkBarCurVol_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "100%";
            // 
            // App2lblCurVol
            // 
            this.App2lblCurVol.Location = new System.Drawing.Point(22, 33);
            this.App2lblCurVol.Name = "App2lblCurVol";
            this.App2lblCurVol.Size = new System.Drawing.Size(76, 13);
            this.App2lblCurVol.TabIndex = 6;
            this.App2lblCurVol.Text = "0";
            this.App2lblCurVol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "0%";
            // 
            // App2TarVolpnl
            // 
            this.App2TarVolpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.App2TarVolpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.App2TarVolpnl.Controls.Add(this.label14);
            this.App2TarVolpnl.Controls.Add(this.App2trkBarTarVol);
            this.App2TarVolpnl.Controls.Add(this.label15);
            this.App2TarVolpnl.Controls.Add(this.App2lblTarVol);
            this.App2TarVolpnl.Controls.Add(this.label17);
            this.App2TarVolpnl.Location = new System.Drawing.Point(132, 119);
            this.App2TarVolpnl.Name = "App2TarVolpnl";
            this.App2TarVolpnl.Size = new System.Drawing.Size(117, 347);
            this.App2TarVolpnl.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "2nd Volume:";
            // 
            // App2trkBarTarVol
            // 
            this.App2trkBarTarVol.Location = new System.Drawing.Point(38, 49);
            this.App2trkBarTarVol.Maximum = 100;
            this.App2trkBarTarVol.Name = "App2trkBarTarVol";
            this.App2trkBarTarVol.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.App2trkBarTarVol.Size = new System.Drawing.Size(45, 295);
            this.App2trkBarTarVol.TabIndex = 5;
            this.App2trkBarTarVol.TickFrequency = 10;
            this.App2trkBarTarVol.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.App2trkBarTarVol.ValueChanged += new System.EventHandler(this.App2trkBarTarVol_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "100%";
            // 
            // App2lblTarVol
            // 
            this.App2lblTarVol.Location = new System.Drawing.Point(22, 33);
            this.App2lblTarVol.Name = "App2lblTarVol";
            this.App2lblTarVol.Size = new System.Drawing.Size(76, 13);
            this.App2lblTarVol.TabIndex = 6;
            this.App2lblTarVol.Text = "0";
            this.App2lblTarVol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 323);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "0%";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(6, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(241, 25);
            this.label18.TabIndex = 15;
            this.label18.Text = "Target App:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // App2apps
            // 
            this.App2apps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.App2apps.FormattingEnabled = true;
            this.App2apps.Location = new System.Drawing.Point(7, 31);
            this.App2apps.Name = "App2apps";
            this.App2apps.Size = new System.Drawing.Size(240, 21);
            this.App2apps.TabIndex = 14;
            this.App2apps.SelectedIndexChanged += new System.EventHandler(this.App2apps_SelectedIndexChanged);
            // 
            // App2btnChangeVol
            // 
            this.App2btnChangeVol.Location = new System.Drawing.Point(9, 472);
            this.App2btnChangeVol.Name = "App2btnChangeVol";
            this.App2btnChangeVol.Size = new System.Drawing.Size(240, 23);
            this.App2btnChangeVol.TabIndex = 13;
            this.App2btnChangeVol.Text = "Change Volume";
            this.App2btnChangeVol.UseVisualStyleBackColor = true;
            this.App2btnChangeVol.Click += new System.EventHandler(this.App2btnChangeVol_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(269, 529);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.App1btnChangeVol);
            this.tabPage1.Controls.Add(this.App1apps);
            this.tabPage1.Controls.Add(this.App1TarVolpnl);
            this.tabPage1.Controls.Add(this.App1CurVolpnl);
            this.tabPage1.Controls.Add(this.App1processes);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(261, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "App 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.App2btnChangeVol);
            this.tabPage2.Controls.Add(this.App2processes);
            this.tabPage2.Controls.Add(this.App2apps);
            this.tabPage2.Controls.Add(this.App2CurVolpnl);
            this.tabPage2.Controls.Add(this.App2TarVolpnl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(261, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "App 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 564);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblMasterVol);
            this.Controls.Add(this.lblAppVol);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Volume Switcher";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.App1trkBarTarVol)).EndInit();
            this.App1TarVolpnl.ResumeLayout(false);
            this.App1TarVolpnl.PerformLayout();
            this.App1CurVolpnl.ResumeLayout(false);
            this.App1CurVolpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.App1trkBarCurVol)).EndInit();
            this.App2CurVolpnl.ResumeLayout(false);
            this.App2CurVolpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.App2trkBarCurVol)).EndInit();
            this.App2TarVolpnl.ResumeLayout(false);
            this.App2TarVolpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.App2trkBarTarVol)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMasterVol;
        private System.Windows.Forms.Button App1btnChangeVol;
        private System.Windows.Forms.ComboBox App1apps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar App1trkBarTarVol;
        private System.Windows.Forms.Label lblTargVol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel App1TarVolpnl;
        private System.Windows.Forms.Label lblAppVol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel App1CurVolpnl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar App1trkBarCurVol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCurVol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox App1processes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox App2processes;
        private System.Windows.Forms.Panel App2CurVolpnl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar App2trkBarCurVol;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label App2lblCurVol;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel App2TarVolpnl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar App2trkBarTarVol;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label App2lblTarVol;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox App2apps;
        private System.Windows.Forms.Button App2btnChangeVol;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

