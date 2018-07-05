﻿namespace VolControl
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
            ((System.ComponentModel.ISupportInitialize)(this.trkBarTargVol)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarCurVol)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMasterVol
            // 
            this.lblMasterVol.AutoSize = true;
            this.lblMasterVol.Location = new System.Drawing.Point(15, 513);
            this.lblMasterVol.Name = "lblMasterVol";
            this.lblMasterVol.Size = new System.Drawing.Size(80, 13);
            this.lblMasterVol.TabIndex = 0;
            this.lblMasterVol.Text = "Master Volume:";
            // 
            // btnChangeVol
            // 
            this.btnChangeVol.Location = new System.Drawing.Point(16, 478);
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
            this.comBoxApps.Location = new System.Drawing.Point(14, 37);
            this.comBoxApps.Name = "comBoxApps";
            this.comBoxApps.Size = new System.Drawing.Size(240, 21);
            this.comBoxApps.TabIndex = 3;
            this.comBoxApps.SelectedIndexChanged += new System.EventHandler(this.comBoxApps_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 9);
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
            this.panel1.Location = new System.Drawing.Point(139, 125);
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
            this.lblAppVol.Location = new System.Drawing.Point(148, 513);
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
            this.panel2.Location = new System.Drawing.Point(16, 125);
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
            this.comBoxProcesses.Location = new System.Drawing.Point(14, 89);
            this.comBoxProcesses.Name = "comBoxProcesses";
            this.comBoxProcesses.Size = new System.Drawing.Size(240, 21);
            this.comBoxProcesses.TabIndex = 11;
            this.comBoxProcesses.SelectedIndexChanged += new System.EventHandler(this.comBoxProcesses_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(11, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Target Process:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 538);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comBoxProcesses);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblAppVol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comBoxApps);
            this.Controls.Add(this.btnChangeVol);
            this.Controls.Add(this.lblMasterVol);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

