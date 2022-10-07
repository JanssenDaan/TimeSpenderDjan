namespace TimeSpenderDjan
{
    partial class Settings
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cdlColor = new System.Windows.Forms.ColorDialog();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.btnPickColor2 = new System.Windows.Forms.Button();
            this.tbxTextFileName = new System.Windows.Forms.TextBox();
            this.lbltextfile = new System.Windows.Forms.Label();
            this.lbxTasksSettings = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.tbxSelectedTask = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Can Save";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltextfile);
            this.groupBox1.Controls.Add(this.tbxTextFileName);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SaveAndDelete";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 51);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(79, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Can Delete";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPickColor2);
            this.groupBox2.Controls.Add(this.btnPickColor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(144, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 83);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color 2";
            // 
            // btnPickColor
            // 
            this.btnPickColor.Location = new System.Drawing.Point(104, 13);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(75, 23);
            this.btnPickColor.TabIndex = 2;
            this.btnPickColor.Text = "Set Color";
            this.btnPickColor.UseVisualStyleBackColor = true;
            // 
            // btnPickColor2
            // 
            this.btnPickColor2.Location = new System.Drawing.Point(104, 47);
            this.btnPickColor2.Name = "btnPickColor2";
            this.btnPickColor2.Size = new System.Drawing.Size(75, 23);
            this.btnPickColor2.TabIndex = 3;
            this.btnPickColor2.Text = "Set Color";
            this.btnPickColor2.UseVisualStyleBackColor = true;
            // 
            // tbxTextFileName
            // 
            this.tbxTextFileName.Location = new System.Drawing.Point(7, 110);
            this.tbxTextFileName.Name = "tbxTextFileName";
            this.tbxTextFileName.Size = new System.Drawing.Size(112, 20);
            this.tbxTextFileName.TabIndex = 3;
            // 
            // lbltextfile
            // 
            this.lbltextfile.AutoSize = true;
            this.lbltextfile.Location = new System.Drawing.Point(28, 94);
            this.lbltextfile.Name = "lbltextfile";
            this.lbltextfile.Size = new System.Drawing.Size(70, 13);
            this.lbltextfile.TabIndex = 4;
            this.lbltextfile.Text = "Textfile name";
            // 
            // lbxTasksSettings
            // 
            this.lbxTasksSettings.FormattingEnabled = true;
            this.lbxTasksSettings.Location = new System.Drawing.Point(6, 93);
            this.lbxTasksSettings.Name = "lbxTasksSettings";
            this.lbxTasksSettings.Size = new System.Drawing.Size(188, 147);
            this.lbxTasksSettings.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxSelectedTask);
            this.groupBox3.Controls.Add(this.btnAddTask);
            this.groupBox3.Controls.Add(this.btnDeleteTask);
            this.groupBox3.Controls.Add(this.lbxTasksSettings);
            this.groupBox3.Location = new System.Drawing.Point(349, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 249);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tasks";
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(7, 59);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTask.TabIndex = 5;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(119, 59);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 6;
            this.btnAddTask.Text = "Add task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            // 
            // tbxSelectedTask
            // 
            this.tbxSelectedTask.Location = new System.Drawing.Point(7, 33);
            this.tbxSelectedTask.Name = "tbxSelectedTask";
            this.tbxSelectedTask.Size = new System.Drawing.Size(187, 20);
            this.tbxSelectedTask.TabIndex = 7;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPickColor2;
        private System.Windows.Forms.Button btnPickColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog cdlColor;
        private System.Windows.Forms.Label lbltextfile;
        private System.Windows.Forms.TextBox tbxTextFileName;
        private System.Windows.Forms.ListBox lbxTasksSettings;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxSelectedTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
    }
}