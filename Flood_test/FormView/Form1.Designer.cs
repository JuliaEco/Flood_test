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
            this.button1 = new System.Windows.Forms.Button();
            this.BdyPath = new System.Windows.Forms.TextBox();
            this.BciPath = new System.Windows.Forms.TextBox();
            this.BdyOpen = new System.Windows.Forms.Button();
            this.BciOpen = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DEMpath = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bciFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.bdyFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.DEMfileOpen = new System.Windows.Forms.OpenFileDialog();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComputeBtn
            // 
            this.ComputeBtn.Location = new System.Drawing.Point(672, 415);
            this.ComputeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComputeBtn.Name = "ComputeBtn";
            this.ComputeBtn.Size = new System.Drawing.Size(106, 23);
            this.ComputeBtn.TabIndex = 0;
            this.ComputeBtn.Text = "Compute";
            this.ComputeBtn.UseVisualStyleBackColor = true;
            this.ComputeBtn.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.BdyPath);
            this.tabPage2.Controls.Add(this.BciPath);
            this.tabPage2.Controls.Add(this.BdyOpen);
            this.tabPage2.Controls.Add(this.BciOpen);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.textBox11);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.DEMpath);
            this.tabPage2.Controls.Add(this.checkBox4);
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(767, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parameters";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 32);
            this.button1.TabIndex = 38;
            this.button1.Text = "Open DEM .asc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.BciPath.TextChanged += new System.EventHandler(this.BciPath_TextChanged);
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
            this.label19.Location = new System.Drawing.Point(587, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 17);
            this.label19.TabIndex = 33;
            this.label19.Text = "Boundary conditions";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(147, 300);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 17);
            this.label17.TabIndex = 32;
            this.label17.Text = "max_Forude";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(147, 300);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 17);
            this.label18.TabIndex = 31;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(24, 295);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 30;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(276, 294);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 21;
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(276, 258);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 18;
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
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(276, 217);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 16;
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
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(276, 178);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 14;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(24, 257);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "dirroot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(24, 220);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 178);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DEMpath
            // 
            this.DEMpath.Enabled = false;
            this.DEMpath.Location = new System.Drawing.Point(24, 140);
            this.DEMpath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DEMpath.Name = "DEMpath";
            this.DEMpath.Size = new System.Drawing.Size(100, 22);
            this.DEMpath.TabIndex = 4;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(24, 101);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(72, 21);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "elevoff";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(24, 47);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(103, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "sgc_enable";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(24, 74);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "drycheckon";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 20);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "adaptoff";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.OpenFileDialog bciFileOpen;
        private System.Windows.Forms.Button BciOpen;
        private System.Windows.Forms.TextBox BdyPath;
        private System.Windows.Forms.TextBox BciPath;
        private System.Windows.Forms.Button BdyOpen;
        private System.Windows.Forms.OpenFileDialog bdyFileOpen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog DEMfileOpen;
    }
}

