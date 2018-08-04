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
            this.btnChangeVol = new System.Windows.Forms.Button();
            this.comBoxApps = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trkBarTargVol = new System.Windows.Forms.TrackBar();
            this.lblTargVol = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAppVol = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.trkBarCurVol = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCurVol = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comBoxProcesses = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comBoxProcesses2 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.comBoxApps2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarTargVol)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarCurVol)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMasterVol
            // 
            this.lblMasterVol.AutoSize = true;
            this.lblMasterVol.Location = new System.Drawing.Point(8, 507);
            this.lblMasterVol.Name = "lblMasterVol";
            this.lblMasterVol.Size = new System.Drawing.Size(80, 13);
            this.lblMasterVol.TabIndex = 0;
            this.lblMasterVol.Text = "Master Volume:";
            // 
            // btnChangeVol
            // 
            this.btnChangeVol.Location = new System.Drawing.Point(9, 472);
            this.btnChangeVol.Name = "btnChangeVol";
            this.btnChangeVol.Size = new System.Drawing.Size(240, 23);
            this.btnChangeVol.TabIndex = 2;
            this.btnChangeVol.Text = "Change Volume";
            this.btnChangeVol.UseVisualStyleBackColor = true;
            this.btnChangeVol.Click += new System.EventHandler(this.btnLowerVol_Click);
            // 
            // comBoxApps
            // 
            this.comBoxApps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxApps.FormattingEnabled = true;
            this.comBoxApps.Location = new System.Drawing.Point(7, 31);
            this.comBoxApps.Name = "comBoxApps";
            this.comBoxApps.Size = new System.Drawing.Size(240, 21);
            this.comBoxApps.TabIndex = 3;
            this.comBoxApps.SelectedIndexChanged += new System.EventHandler(this.comBoxApps_SelectedIndexChanged);
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
            // trkBarTargVol
            // 
            this.trkBarTargVol.Location = new System.Drawing.Point(38, 49);
            this.trkBarTargVol.Maximum = 100;
            this.trkBarTargVol.Name = "trkBarTargVol";
            this.trkBarTargVol.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkBarTargVol.Size = new System.Drawing.Size(45, 295);
            this.trkBarTargVol.TabIndex = 5;
            this.trkBarTargVol.TickFrequency = 10;
            this.trkBarTargVol.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkBarTargVol.ValueChanged += new System.EventHandler(this.trkBarTargVol_ValueChanged);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trkBarTargVol);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblTargVol);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(132, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 347);
            this.panel1.TabIndex = 9;
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
            this.lblAppVol.Location = new System.Drawing.Point(141, 507);
            this.lblAppVol.Name = "lblAppVol";
            this.lblAppVol.Size = new System.Drawing.Size(67, 13);
            this.lblAppVol.TabIndex = 10;
            this.lblAppVol.Text = "App Volume:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.trkBarCurVol);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblCurVol);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(9, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 347);
            this.panel2.TabIndex = 10;
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
            // trkBarCurVol
            // 
            this.trkBarCurVol.Location = new System.Drawing.Point(38, 49);
            this.trkBarCurVol.Maximum = 100;
            this.trkBarCurVol.Name = "trkBarCurVol";
            this.trkBarCurVol.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkBarCurVol.Size = new System.Drawing.Size(45, 295);
            this.trkBarCurVol.TabIndex = 5;
            this.trkBarCurVol.TickFrequency = 10;
            this.trkBarCurVol.TickStyle = System.Windows.Forms.TickStyle.Both;
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
            // comBoxProcesses
            // 
            this.comBoxProcesses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxProcesses.FormattingEnabled = true;
            this.comBoxProcesses.Location = new System.Drawing.Point(7, 83);
            this.comBoxProcesses.Name = "comBoxProcesses";
            this.comBoxProcesses.Size = new System.Drawing.Size(240, 21);
            this.comBoxProcesses.TabIndex = 11;
            this.comBoxProcesses.SelectedIndexChanged += new System.EventHandler(this.comBoxProcesses_SelectedIndexChanged);
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
            // comBoxProcesses2
            // 
            this.comBoxProcesses2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxProcesses2.FormattingEnabled = true;
            this.comBoxProcesses2.Location = new System.Drawing.Point(7, 83);
            this.comBoxProcesses2.Name = "comBoxProcesses2";
            this.comBoxProcesses2.Size = new System.Drawing.Size(240, 21);
            this.comBoxProcesses2.TabIndex = 18;
            this.comBoxProcesses2.SelectedIndexChanged += new System.EventHandler(this.comBoxProcesses2_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(9, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 347);
            this.panel3.TabIndex = 17;
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
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(38, 49);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 295);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
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
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(22, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "0";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.trackBar2);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Location = new System.Drawing.Point(132, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(117, 347);
            this.panel4.TabIndex = 16;
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
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(38, 49);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 295);
            this.trackBar2.TabIndex = 5;
            this.trackBar2.TickFrequency = 10;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.Both;
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
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(22, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "0";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // comBoxApps2
            // 
            this.comBoxApps2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxApps2.FormattingEnabled = true;
            this.comBoxApps2.Location = new System.Drawing.Point(7, 31);
            this.comBoxApps2.Name = "comBoxApps2";
            this.comBoxApps2.Size = new System.Drawing.Size(240, 21);
            this.comBoxApps2.TabIndex = 14;
            this.comBoxApps2.SelectedIndexChanged += new System.EventHandler(this.comBoxApps2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Change Volume";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(269, 559);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblMasterVol);
            this.tabPage1.Controls.Add(this.btnChangeVol);
            this.tabPage1.Controls.Add(this.comBoxApps);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lblAppVol);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.comBoxProcesses);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(261, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "App 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.comBoxProcesses2);
            this.tabPage2.Controls.Add(this.comBoxApps2);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(261, 533);
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
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Volume Switcher";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkBarTargVol)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarCurVol)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMasterVol;
        private System.Windows.Forms.Button btnChangeVol;
        private System.Windows.Forms.ComboBox comBoxApps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trkBarTargVol;
        private System.Windows.Forms.Label lblTargVol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAppVol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trkBarCurVol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCurVol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comBoxProcesses;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBoxProcesses2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comBoxApps2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

