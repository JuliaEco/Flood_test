namespace Flood_test
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
            this.ComputeBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SelectRootFolderBtn = new System.Windows.Forms.Button();
            this.OpenDEM = new System.Windows.Forms.Button();
            this.BdyPath = new System.Windows.Forms.TextBox();
            this.BciPath = new System.Windows.Forms.TextBox();
            this.BdyOpen = new System.Windows.Forms.Button();
            this.BciOpen = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.max_Froude = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fpfric = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saveint = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.massint = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.init_tstep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sim_time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rootFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resroot = new System.Windows.Forms.TextBox();
            this.DEMpath = new System.Windows.Forms.TextBox();
            this.elevoff = new System.Windows.Forms.CheckBox();
            this.sgc_enable = new System.Windows.Forms.CheckBox();
            this.drycheckon = new System.Windows.Forms.CheckBox();
            this.adaptoff = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bciFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.bdyFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.DEMfileOpen = new System.Windows.Forms.OpenFileDialog();
            this.RootFolderOpen = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComputeBtn
            // 
            this.ComputeBtn.Location = new System.Drawing.Point(672, 415);
            this.ComputeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComputeBtn.Name = "ComputeBtn";
            this.ComputeBtn.Size = new System.Drawing.Size(107, 23);
            this.ComputeBtn.TabIndex = 0;
            this.ComputeBtn.Text = "Compute";
            this.ComputeBtn.UseVisualStyleBackColor = true;
            this.ComputeBtn.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SelectRootFolderBtn);
            this.tabPage2.Controls.Add(this.OpenDEM);
            this.tabPage2.Controls.Add(this.BdyPath);
            this.tabPage2.Controls.Add(this.BciPath);
            this.tabPage2.Controls.Add(this.BdyOpen);
            this.tabPage2.Controls.Add(this.BciOpen);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.max_Froude);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.fpfric);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.saveint);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.massint);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.init_tstep);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.sim_time);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.rootFolder);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.resroot);
            this.tabPage2.Controls.Add(this.DEMpath);
            this.tabPage2.Controls.Add(this.elevoff);
            this.tabPage2.Controls.Add(this.sgc_enable);
            this.tabPage2.Controls.Add(this.drycheckon);
            this.tabPage2.Controls.Add(this.adaptoff);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(767, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parameters";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SelectRootFolderBtn
            // 
            this.SelectRootFolderBtn.Location = new System.Drawing.Point(130, 220);
            this.SelectRootFolderBtn.Name = "SelectRootFolderBtn";
            this.SelectRootFolderBtn.Size = new System.Drawing.Size(103, 23);
            this.SelectRootFolderBtn.TabIndex = 39;
            this.SelectRootFolderBtn.Text = "Root Folder";
            this.SelectRootFolderBtn.UseVisualStyleBackColor = true;
            this.SelectRootFolderBtn.Click += new System.EventHandler(this.SelectRootFolderBtn_Click);
            // 
            // OpenDEM
            // 
            this.OpenDEM.Location = new System.Drawing.Point(655, 196);
            this.OpenDEM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenDEM.Name = "OpenDEM";
            this.OpenDEM.Size = new System.Drawing.Size(100, 30);
            this.OpenDEM.TabIndex = 38;
            this.OpenDEM.Text = "Open DEM .asc";
            this.OpenDEM.UseVisualStyleBackColor = true;
            this.OpenDEM.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BdyPath
            // 
            this.BdyPath.Enabled = false;
            this.BdyPath.Location = new System.Drawing.Point(513, 149);
            this.BdyPath.Margin = new System.Windows.Forms.Padding(4);
            this.BdyPath.Name = "BdyPath";
            this.BdyPath.Size = new System.Drawing.Size(132, 22);
            this.BdyPath.TabIndex = 37;
            // 
            // BciPath
            // 
            this.BciPath.Enabled = false;
            this.BciPath.Location = new System.Drawing.Point(513, 101);
            this.BciPath.Margin = new System.Windows.Forms.Padding(4);
            this.BciPath.Name = "BciPath";
            this.BciPath.Size = new System.Drawing.Size(132, 22);
            this.BciPath.TabIndex = 36;
            // 
            // BdyOpen
            // 
            this.BdyOpen.Location = new System.Drawing.Point(655, 146);
            this.BdyOpen.Margin = new System.Windows.Forms.Padding(4);
            this.BdyOpen.Name = "BdyOpen";
            this.BdyOpen.Size = new System.Drawing.Size(100, 28);
            this.BdyOpen.TabIndex = 35;
            this.BdyOpen.Text = "Open .bdy";
            this.BdyOpen.UseVisualStyleBackColor = true;
            this.BdyOpen.Click += new System.EventHandler(this.BdiOpen_Click);
            // 
            // BciOpen
            // 
            this.BciOpen.Location = new System.Drawing.Point(655, 98);
            this.BciOpen.Margin = new System.Windows.Forms.Padding(4);
            this.BciOpen.Name = "BciOpen";
            this.BciOpen.Size = new System.Drawing.Size(100, 28);
            this.BciOpen.TabIndex = 34;
            this.BciOpen.Text = "Open .bci";
            this.BciOpen.UseVisualStyleBackColor = true;
            this.BciOpen.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(509, 74);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(12, 17);
            this.label19.TabIndex = 33;
            this.label19.Text = " ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(147, 300);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 17);
            this.label17.TabIndex = 32;
            this.label17.Text = "max_Froude";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(147, 300);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 17);
            this.label18.TabIndex = 31;
            // 
            // max_Froude
            // 
            this.max_Froude.Location = new System.Drawing.Point(24, 295);
            this.max_Froude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.max_Froude.Name = "max_Froude";
            this.max_Froude.Size = new System.Drawing.Size(100, 22);
            this.max_Froude.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(711, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 17);
            this.label16.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(711, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 17);
            this.label14.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "fpfric";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 22;
            // 
            // fpfric
            // 
            this.fpfric.Location = new System.Drawing.Point(276, 294);
            this.fpfric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fpfric.Name = "fpfric";
            this.fpfric.Size = new System.Drawing.Size(100, 22);
            this.fpfric.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "saveint";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 19;
            // 
            // saveint
            // 
            this.saveint.Location = new System.Drawing.Point(276, 258);
            this.saveint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveint.Name = "saveint";
            this.saveint.Size = new System.Drawing.Size(100, 22);
            this.saveint.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(399, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "massint";
            // 
            // massint
            // 
            this.massint.Location = new System.Drawing.Point(276, 217);
            this.massint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.massint.Name = "massint";
            this.massint.Size = new System.Drawing.Size(100, 22);
            this.massint.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(399, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "initial_tstep";
            // 
            // init_tstep
            // 
            this.init_tstep.Location = new System.Drawing.Point(276, 178);
            this.init_tstep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.init_tstep.Name = "init_tstep";
            this.init_tstep.Size = new System.Drawing.Size(100, 22);
            this.init_tstep.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "sim_time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 12;
            // 
            // sim_time
            // 
            this.sim_time.Location = new System.Drawing.Point(24, 257);
            this.sim_time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sim_time.Name = "sim_time";
            this.sim_time.Size = new System.Drawing.Size(100, 22);
            this.sim_time.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 9;
            // 
            // rootFolder
            // 
            this.rootFolder.Location = new System.Drawing.Point(24, 220);
            this.rootFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rootFolder.Name = "rootFolder";
            this.rootFolder.Size = new System.Drawing.Size(100, 22);
            this.rootFolder.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "resroot";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // resroot
            // 
            this.resroot.Location = new System.Drawing.Point(24, 178);
            this.resroot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resroot.Name = "resroot";
            this.resroot.Size = new System.Drawing.Size(100, 22);
            this.resroot.TabIndex = 6;
            // 
            // DEMpath
            // 
            this.DEMpath.Enabled = false;
            this.DEMpath.Location = new System.Drawing.Point(513, 201);
            this.DEMpath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DEMpath.Name = "DEMpath";
            this.DEMpath.Size = new System.Drawing.Size(132, 22);
            this.DEMpath.TabIndex = 4;
            // 
            // elevoff
            // 
            this.elevoff.AutoSize = true;
            this.elevoff.Location = new System.Drawing.Point(24, 101);
            this.elevoff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elevoff.Name = "elevoff";
            this.elevoff.Size = new System.Drawing.Size(72, 21);
            this.elevoff.TabIndex = 3;
            this.elevoff.Text = "elevoff";
            this.elevoff.UseVisualStyleBackColor = true;
            // 
            // sgc_enable
            // 
            this.sgc_enable.AutoSize = true;
            this.sgc_enable.Location = new System.Drawing.Point(24, 47);
            this.sgc_enable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sgc_enable.Name = "sgc_enable";
            this.sgc_enable.Size = new System.Drawing.Size(103, 21);
            this.sgc_enable.TabIndex = 2;
            this.sgc_enable.Text = "sgc_enable";
            this.sgc_enable.UseVisualStyleBackColor = true;
            // 
            // drycheckon
            // 
            this.drycheckon.AutoSize = true;
            this.drycheckon.Location = new System.Drawing.Point(24, 74);
            this.drycheckon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drycheckon.Name = "drycheckon";
            this.drycheckon.Size = new System.Drawing.Size(103, 21);
            this.drycheckon.TabIndex = 1;
            this.drycheckon.Text = "drycheckon";
            this.drycheckon.UseVisualStyleBackColor = true;
            // 
            // adaptoff
            // 
            this.adaptoff.AutoSize = true;
            this.adaptoff.Location = new System.Drawing.Point(24, 20);
            this.adaptoff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adaptoff.Name = "adaptoff";
            this.adaptoff.Size = new System.Drawing.Size(82, 21);
            this.adaptoff.TabIndex = 0;
            this.adaptoff.Text = "adaptoff";
            this.adaptoff.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 378);
            this.tabControl1.TabIndex = 2;
            // 
            // bciFileOpen
            // 
            this.bciFileOpen.FileName = "openFileDialog1";
            this.bciFileOpen.Filter = "BCI-files|*.bci";
            this.bciFileOpen.FileOk += new System.ComponentModel.CancelEventHandler(this.BcFile_FileOk);
            // 
            // bdyFileOpen
            // 
            this.bdyFileOpen.FileName = "openFileDialog1";
            this.bdyFileOpen.Filter = "BDY-files|*.bdy";
            this.bdyFileOpen.FileOk += new System.ComponentModel.CancelEventHandler(this.bdyFileOpen_FileOk);
            // 
            // DEMfileOpen
            // 
            this.DEMfileOpen.FileName = "DEMfileOpen";
            this.DEMfileOpen.Filter = "DEM-files|*.asc";
            // 
            // RootFolderOpen
            // 
            this.RootFolderOpen.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ComputeBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ComputeBtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox DEMpath;
        private System.Windows.Forms.CheckBox elevoff;
        private System.Windows.Forms.CheckBox sgc_enable;
        private System.Windows.Forms.CheckBox drycheckon;
        private System.Windows.Forms.CheckBox adaptoff;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resroot;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox max_Froude;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fpfric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox saveint;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox massint;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox init_tstep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sim_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rootFolder;
        private System.Windows.Forms.OpenFileDialog bciFileOpen;
        private System.Windows.Forms.Button BciOpen;
        private System.Windows.Forms.TextBox BdyPath;
        private System.Windows.Forms.TextBox BciPath;
        private System.Windows.Forms.Button BdyOpen;
        private System.Windows.Forms.OpenFileDialog bdyFileOpen;
        private System.Windows.Forms.Button OpenDEM;
        private System.Windows.Forms.OpenFileDialog DEMfileOpen;
        private System.Windows.Forms.Button SelectRootFolderBtn;
        private System.Windows.Forms.FolderBrowserDialog RootFolderOpen;
    }
}

