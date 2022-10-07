using System;
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
        public ObservableCollection<What> DoingList = new ObservableCollection<What>();
        public new What w = new What();
        public int tmr = 3;
        public Form1()
        {
            InitializeComponent();
            form = this;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrColor.Start();

            cbxChoose.Items.Add("Aan het slapen");
            cbxChoose.Items.Add("Op de WC");
            cbxChoose.Items.Add("Programmeren in C#");
            cbxChoose.Items.Add("Capri sun drinken");
            tmrPopup.Interval = 1000;
            string x = File.ReadAllText("x.txt");
            DoingList = Newtonsoft.Json.JsonConvert.DeserializeObject<ObservableCollection<What>>(x);
            foreach (What what in DoingList)
            {
                lbxWhatDidIDo.Items.Add(what);
            }
        }

        private void tmrColor_Tick(object sender, EventArgs e)
        {
            if (pnl1.BackColor == Color.Red)
            {
                pnl1.BackColor = Color.Blue;
                pnl2.BackColor = Color.Blue;
                pnl3.BackColor = Color.Blue;
                pnl4.BackColor = Color.Blue;
            }
            else
            {
                pnl1.BackColor = Color.Red;
                pnl2.BackColor = Color.Red;
                pnl3.BackColor = Color.Red;
                pnl4.BackColor = Color.Red;
            }
        }

        private void cbxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            PutListbox();
        }

        private void cbxChoose_Leave(object sender, EventArgs e)
        {
            PutListbox();
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
            File.WriteAllText("x.txt", Json);
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
    }
}
