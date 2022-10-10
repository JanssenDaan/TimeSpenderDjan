namespace TimeSpenderDjan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblWhatDoing = new System.Windows.Forms.Label();
            this.lbxWhatDidIDo = new System.Windows.Forms.ListBox();
            this.cbxChoose = new System.Windows.Forms.ComboBox();
            this.tmrColor = new System.Windows.Forms.Timer(this.components);
            this.tmrPopup = new System.Windows.Forms.Timer(this.components);
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.ntfDjan = new System.Windows.Forms.NotifyIcon(this.components);
            this.pcbSettings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWhatDoing
            // 
            this.lblWhatDoing.AutoSize = true;
            this.lblWhatDoing.BackColor = System.Drawing.Color.White;
            this.lblWhatDoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatDoing.Location = new System.Drawing.Point(306, 9);
            this.lblWhatDoing.Name = "lblWhatDoing";
            this.lblWhatDoing.Size = new System.Drawing.Size(237, 24);
            this.lblWhatDoing.TabIndex = 0;
            this.lblWhatDoing.Text = " Phineas, Wat doeeeee je?";
            // 
            // lbxWhatDidIDo
            // 
            this.lbxWhatDidIDo.DisplayMember = "text";
            this.lbxWhatDidIDo.FormattingEnabled = true;
            this.lbxWhatDidIDo.Location = new System.Drawing.Point(321, 336);
            this.lbxWhatDidIDo.Name = "lbxWhatDidIDo";
            this.lbxWhatDidIDo.Size = new System.Drawing.Size(222, 173);
            this.lbxWhatDidIDo.TabIndex = 1;
            // 
            // cbxChoose
            // 
            this.cbxChoose.FormattingEnabled = true;
            this.cbxChoose.Location = new System.Drawing.Point(271, 45);
            this.cbxChoose.Name = "cbxChoose";
            this.cbxChoose.Size = new System.Drawing.Size(299, 21);
            this.cbxChoose.TabIndex = 2;
            this.cbxChoose.SelectedIndexChanged += new System.EventHandler(this.cbxChoose_SelectedIndexChanged);
            this.cbxChoose.Leave += new System.EventHandler(this.cbxChoose_Leave);
            // 
            // tmrColor
            // 
            this.tmrColor.Enabled = true;
            this.tmrColor.Interval = 500;
            this.tmrColor.Tick += new System.EventHandler(this.tmrColor_Tick);
            // 
            // tmrPopup
            // 
            this.tmrPopup.Tick += new System.EventHandler(this.tmrPopup_Tick);
            // 
            // pnl1
            // 
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(100, 100);
            this.pnl1.TabIndex = 3;
            // 
            // pnl2
            // 
            this.pnl2.Location = new System.Drawing.Point(737, 0);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(100, 100);
            this.pnl2.TabIndex = 4;
            // 
            // pnl4
            // 
            this.pnl4.Location = new System.Drawing.Point(0, 453);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(100, 100);
            this.pnl4.TabIndex = 4;
            // 
            // pnl3
            // 
            this.pnl3.Location = new System.Drawing.Point(737, 453);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(100, 100);
            this.pnl3.TabIndex = 5;
            // 
            // ntfDjan
            // 
            this.ntfDjan.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfDjan.Icon")));
            this.ntfDjan.Text = "ntfDjan";
            this.ntfDjan.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntfDjan_MouseDoubleClick);
            // 
            // pcbSettings
            // 
            this.pcbSettings.BackColor = System.Drawing.Color.Transparent;
            this.pcbSettings.BackgroundImage = global::TimeSpenderDjan.Properties.Resources.Windows_Settings_app_icon;
            this.pcbSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbSettings.Location = new System.Drawing.Point(678, 3);
            this.pcbSettings.Name = "pcbSettings";
            this.pcbSettings.Size = new System.Drawing.Size(53, 40);
            this.pcbSettings.TabIndex = 6;
            this.pcbSettings.TabStop = false;
            this.pcbSettings.Click += new System.EventHandler(this.pcbSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 553);
            this.Controls.Add(this.pcbSettings);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.cbxChoose);
            this.Controls.Add(this.lbxWhatDidIDo);
            this.Controls.Add(this.lblWhatDoing);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWhatDoing;
        private System.Windows.Forms.ListBox lbxWhatDidIDo;
        private System.Windows.Forms.ComboBox cbxChoose;
        private System.Windows.Forms.Timer tmrColor;
        private System.Windows.Forms.Timer tmrPopup;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.NotifyIcon ntfDjan;
        private System.Windows.Forms.PictureBox pcbSettings;
    }
}

