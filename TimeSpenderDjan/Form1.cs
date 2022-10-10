﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSpenderDjan.Classes;

namespace TimeSpenderDjan
{
    public partial class Form1 : Form
    {
        public static Form1 form;
        public static Settings FormSettings;
        public ObservableCollection<What> DoingList = new ObservableCollection<What>();
        public new What w = new What();
        public int tmr = 3;
        public Classes.Settings settings;
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            form = this;
            try
            {
                string x = File.ReadAllText("config.txt");
                settings = Newtonsoft.Json.JsonConvert.DeserializeObject<Classes.Settings>(x);
            }
            catch (Exception)
            {
                MessageBox.Show("Can't find config file. Please make one");
            }
            FormSettings = new Settings(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrColor.Start();

            foreach (var t in settings.Tasks)
            {
                cbxChoose.Items.Add(t.TaskName);
            }

            
            tmrPopup.Interval = 1000;
            string x = File.ReadAllText(settings.FileName + ".txt");
            DoingList = Newtonsoft.Json.JsonConvert.DeserializeObject<ObservableCollection<What>>(x);
            foreach (What what in DoingList)
            {
                lbxWhatDidIDo.Items.Add(what);
            }
        }

        private void tmrColor_Tick(object sender, EventArgs e)
        {
            if (pnl1.BackColor == settings.Color1)
            {
                pnl1.BackColor = settings.Color2;
                pnl2.BackColor = settings.Color2;
                pnl3.BackColor = settings.Color2;
                pnl4.BackColor = settings.Color2;
            }
            else
            {
                pnl1.BackColor = settings.Color1;
                pnl2.BackColor = settings.Color1;
                pnl3.BackColor = settings.Color1;
                pnl4.BackColor = settings.Color1;
            }
        }

        private void cbxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            PutListbox();
        }

        private void cbxChoose_Leave(object sender, EventArgs e)
        {
           // PutListbox();
        }

        public async void PutListbox()
        {
            w = new What { WhatDoing = cbxChoose.Text , text = cbxChoose.Text + " " + w.Time};

            DoingList.Add(w);
            lbxWhatDidIDo.Items.Add(w);
            this.Hide();
            //this.WindowState = FormWindowState.Minimized;
            ntfDjan.Visible = true;
            tmr = 3;
            tmrPopup.Start();
            string Json = Newtonsoft.Json.JsonConvert.SerializeObject(DoingList);
            File.WriteAllText(settings.FileName + ".txt", Json);
        }

        private void ntfDjan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void tmrPopup_Tick(object sender, EventArgs e)
        {
            if (tmr == 0)
            {
                this.Show();
                tmrPopup.Stop();
                tmr = 3;
            }
            tmr--;
             
        }

        public void ReloadSettings()
        {
            string x = File.ReadAllText("config.txt");
            settings = Newtonsoft.Json.JsonConvert.DeserializeObject<Classes.Settings>(x);

            cbxChoose.Items.Clear();
            foreach (var t in settings.Tasks)
            {
                cbxChoose.Items.Add(t.TaskName);
            }
        }

        private void pcbSettings_Click(object sender, EventArgs e)
        {
            FormSettings.Show();
        }

        public void CloseForm()
        {
            FormSettings.Hide();
        }
    }
}
