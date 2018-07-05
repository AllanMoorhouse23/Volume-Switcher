using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolControl
{
    public partial class Form1 : Form
    {
        //TEST
        //Is the app volume reduced
        bool AppChangedVol = false;
        //Orignal Volume
        float? AppOrgVol;
        //Target Volume
        float? AppTargVol = 0;
        //Current Volume
        float? AppCurVol;

        ShortcutKey key = new ShortcutKey();

        private List<_App> _apps = new List<_App>();
        private List<string> _OpenedApps = new List<string>();

        public Form1()
        {
            InitializeComponent();

            lblMasterVol.Text = "Master Volume: " + AudioManager.GetMasterVolume().ToString();

            timer1.Start();
            toggleUI(false);
            Process[] processes = Process.GetProcesses();

            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    Console.WriteLine("Adding to list: " + p.ProcessName);
                    _OpenedApps.Add(p.ProcessName);

                    //_apps.Add(new _App(p.ProcessName, p.Id));
                    // Console.WriteLine("Main Window: " + p.MainWindowTitle + " Process Name: " + p.ProcessName);

                }
            }

            bool checkd = false;

            foreach (string s in _OpenedApps) {
                processes = Process.GetProcessesByName(s);
                foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.ProcessName))
                {
                   foreach (_App ap in _apps) {
                      if (p.ProcessName == ap.Name)
                     {
          //Add the ID to the existing list
                          ap.AddId(p.Id);
                         checkd = true;
                        break;
                   }
                    checkd = false;
                }
                 if(checkd == false)
                      {
                       _apps.Add(new _App(p.ProcessName, p.Id));
                    }
                 }
              }


            }

            foreach (_App ap in _apps) {
                ap.Output();
            }

            for (int i = 0; i < _apps.Count; i++) {

                comBoxApps.Items.Add(_apps[i].Name);

                
            }


        }


        /// <summary>
        /// Change volume button pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLowerVol_Click(object sender, EventArgs e)
        {
            changeVolume();
            //AudioManager.SetApplicationVolume(14812, 20);
        }

        /// <summary>
        /// Change the volume of the targetted app
        /// </summary>
        private void changeVolume() {

            try
            {
                if (AppChangedVol == true)
                {
                    AudioManager.SetApplicationVolume(_apps[comBoxApps.SelectedIndex].ProID[comBoxProcesses.SelectedIndex], (float)AppCurVol);
                    AppChangedVol = false;
                    panel2.BackColor = Color.FromArgb(192, 255, 192);
                    panel1.BackColor = Color.FromArgb(255, 192, 192);
                }
                else
                {
                    AudioManager.SetApplicationVolume(_apps[comBoxApps.SelectedIndex].ProID[comBoxProcesses.SelectedIndex], (float)AppTargVol);
                    AppChangedVol = true;
                    panel1.BackColor = Color.FromArgb(192, 255, 192);
                    panel2.BackColor = Color.FromArgb(255, 192, 192);
                }

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (key.keyPressed() == true)
            {
                lblMasterVol.Text = "Shortcut key pressed";
                changeVolume();
            }
            else {

            }
        }


        /// <summary>
        /// Make sure the timer stops before closing the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void toggleUI(bool state) {
            if (state == true)
            {
                trkBarCurVol.Enabled = true;
                trkBarTargVol.Enabled = true;
                btnChangeVol.Enabled = true;
                panel2.BackColor = Color.FromArgb(192, 255, 192);
                panel1.BackColor = Color.FromArgb(255, 192, 192);
            }
            else {
                trkBarCurVol.Enabled = false;
                trkBarTargVol.Enabled = false;
                btnChangeVol.Enabled = false;
                panel1.BackColor = Color.FromArgb(255, 192, 192);
                panel2.BackColor = Color.FromArgb(255, 192, 192);
            }
        }


        /// <summary>
        /// Set the target volume and display it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trkBarTargVol_ValueChanged(object sender, EventArgs e)
        {
            AppTargVol = trkBarTargVol.Value ;
            lblTargVol.Text = trkBarTargVol.Value.ToString() + "%";
        }

        private void comBoxApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comBoxProcesses.Items.Clear();
                for (int j = 0; j < _apps[comBoxApps.SelectedIndex].ProID.Count; j++)
                {
                    comBoxProcesses.Items.Add(_apps[comBoxApps.SelectedIndex].ProID[j].ToString());
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void comBoxProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                AppCurVol = AudioManager.GetApplicationVolume(_apps[comBoxApps.SelectedIndex].ProID[comBoxProcesses.SelectedIndex]);
                trkBarCurVol.Value = (int)AppCurVol;
                toggleUI(true);
                lblCurVol.Text = AppCurVol + "%";
            }
            catch (Exception ex) {
                toggleUI(false);
                lblCurVol.Text = "0";
               trkBarCurVol.Value = 0;
                Console.WriteLine(ex.Message);
            }
        }
    }
}
