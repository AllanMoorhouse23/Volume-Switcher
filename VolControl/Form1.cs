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

        //Is the app volume reduced
        //bool AppChangedVol = false;
        //Orignal Volume
        //float? AppOrgVol;
        //Target Volume
        //float? AppTargVol = 0;
        //Current Volume
        //float? AppCurVol;


        //Is the app volume reduced

        bool[] AppChangedVol = new bool[2];
        float?[] AppCurVol = new float?[2];
        float?[] AppTargVol = new float?[2];
        
        
        //AppChangedVol[0] = true;

        //Target Volume 2
        //float? AppTargVol2 = 0;
        //Current Volume 2
        //float? AppCurVol2;


        ShortcutKey key = new ShortcutKey();

        private List<_App> _apps = new List<_App>();
        private List<string> _OpenedApps = new List<string>();

        public Form1()
        {
            InitializeComponent();
           
            lblMasterVol.Text = "Master Volume: " + AudioManager.GetMasterVolume().ToString();

            timer1.Start();

            toggleUI(App1trkBarCurVol, App1trkBarTarVol, App1btnChangeVol, App1TarVolpnl, App1CurVolpnl, false);
            toggleUI(App2trkBarCurVol, App2trkBarTarVol, App2btnChangeVol, App2CurVolpnl, App2TarVolpnl, false);

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
                if(checkd == false){
                       _apps.Add(new _App(p.ProcessName, p.Id));
                }
                }
              }


            }

            foreach (_App ap in _apps) {
                ap.Output();
            }

            for (int i = 0; i < _apps.Count; i++) {

                App1apps.Items.Add(_apps[i].Name);
                App2apps.Items.Add(_apps[i].Name);
                
            }


        }


 
        




        /// <summary>
        /// Change the volume of the targetted app
        /// </summary>
        private void changeVolume(Panel pnl1, Panel pnl2, int appChanged, ComboBox apps, ComboBox processes) {

            try
            {
                if (AppChangedVol[appChanged] == true)
                {
                    AudioManager.SetApplicationVolume(_apps[apps.SelectedIndex].ProID[processes.SelectedIndex], (float)AppCurVol[appChanged]);
                    AppChangedVol[appChanged] = false;
                    pnl2.BackColor = Color.FromArgb(192, 255, 192);
                    pnl1.BackColor = Color.FromArgb(255, 192, 192);
                }
                else
                {
                    AudioManager.SetApplicationVolume(_apps[apps.SelectedIndex].ProID[processes.SelectedIndex], (float)AppTargVol[appChanged]);
                    AppChangedVol[appChanged] = true;
                    pnl1.BackColor = Color.FromArgb(192, 255, 192);
                    pnl2.BackColor = Color.FromArgb(255, 192, 192);
                }

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (key.keyPressed(1) == true)
            {
                lblAppVol.Text = "Shortcut key: -";
                changeVolume(App1TarVolpnl, App1CurVolpnl, 0, App1apps, App1processes);
            }
            else if(key.keyPressed(2) == true)
            {
                lblAppVol.Text = "Shortcut key: +";
                changeVolume(App2TarVolpnl, App2CurVolpnl, 1, App2apps, App2processes);
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
        
        private void toggleUI(TrackBar currentVOL, TrackBar targetVOL, Button changeVOL, Panel currentPnlVOL, Panel targetPnlVOL, bool state) {
            if (state == true)
            {
               
                currentVOL.Enabled = true;
                targetVOL.Enabled = true;
                changeVOL.Enabled = true;

                currentPnlVOL.BackColor = Color.FromArgb(192, 255, 192);
                targetPnlVOL.BackColor = Color.FromArgb(255, 192, 192);

            }
            else {
               
                currentVOL.Enabled = false;
                targetVOL.Enabled = false;
                changeVOL.Enabled = false;

                currentPnlVOL.BackColor = Color.FromArgb(255, 192, 192);
                targetPnlVOL.BackColor = Color.FromArgb(255, 192, 192);
            }
        }









        //First app volume
        private void App1apps_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                App1processes.Items.Clear();
                for (int j = 0; j < _apps[App1apps.SelectedIndex].ProID.Count; j++)
                {
                    App1processes.Items.Add(_apps[App1apps.SelectedIndex].ProID[j].ToString());
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void App1processes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {    
                AppCurVol[0] = AudioManager.GetApplicationVolume(_apps[App1apps.SelectedIndex].ProID[App1processes.SelectedIndex]);
                App1trkBarCurVol.Value = (int)AppCurVol[0];
                toggleUI(App1trkBarCurVol, App1trkBarTarVol, App1btnChangeVol, App1CurVolpnl, App1TarVolpnl,  true);
                lblCurVol.Text = AppCurVol[0] + "%";
            }
            catch (Exception ex) {
                toggleUI(App1trkBarCurVol, App1trkBarTarVol, App1btnChangeVol, App1CurVolpnl, App1TarVolpnl,  false);
                lblCurVol.Text = "0";
                App1trkBarCurVol.Value = 0;
                Console.WriteLine(ex.Message);
            }
        }

        private void App1trkBarCurVol_ValueChanged(object sender, EventArgs e)
        {
            AppCurVol[0] = App1trkBarCurVol.Value;
            lblCurVol.Text = App1trkBarCurVol.Value.ToString() + "%";
        }

        private void App1trkBarTarVol_ValueChanged(object sender, EventArgs e)
        {
            AppTargVol[0] = App1trkBarTarVol.Value;
            lblTargVol.Text = App1trkBarTarVol.Value.ToString() + "%";
        }

        private void App1btnChangeVol_Click(object sender, EventArgs e)
        {
            changeVolume(App1TarVolpnl, App1CurVolpnl, 0, App1apps, App1processes);
        }



        //Second app volume
        private void App2apps_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                App2processes.Items.Clear();
                for (int j = 0; j < _apps[App2apps.SelectedIndex].ProID.Count; j++)
                {
                    App2processes.Items.Add(_apps[App2apps.SelectedIndex].ProID[j].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void App2processes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                AppCurVol[1] = AudioManager.GetApplicationVolume(_apps[App2apps.SelectedIndex].ProID[App2processes.SelectedIndex]);
                App2trkBarCurVol.Value = (int)AppCurVol[1];
                toggleUI(App2trkBarCurVol, App2trkBarTarVol, App2btnChangeVol, App2CurVolpnl, App2TarVolpnl, true);
                App2lblCurVol.Text = AppCurVol[1] + "%";
            }
            catch (Exception ex)
            {
                toggleUI(App2trkBarCurVol, App2trkBarTarVol, App2btnChangeVol, App2CurVolpnl, App2TarVolpnl, false);
                App2lblCurVol.Text = "0";
                App2trkBarCurVol.Value = 0;
                Console.WriteLine(ex.Message);
            }
        }

        private void App2trkBarTarVol_ValueChanged(object sender, EventArgs e)
        {
            AppTargVol[1] = App2trkBarTarVol.Value;
            App2lblTarVol.Text = App2trkBarTarVol.Value.ToString() + "%";
        }

        private void App2btnChangeVol_Click(object sender, EventArgs e)
        {
            changeVolume(App2TarVolpnl, App2CurVolpnl, 1, App2apps, App2processes);
        }

        private void App2trkBarCurVol_ValueChanged(object sender, EventArgs e)
        {
            AppCurVol[1] = App2trkBarCurVol.Value;
            App2lblCurVol.Text = App2trkBarCurVol.Value.ToString() + "%";
        }
    }
}
