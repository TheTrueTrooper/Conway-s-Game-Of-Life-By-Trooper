namespace AngeloSanchesCMPELab2
{
    partial class PatternModel
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
            this.Bu_Cancel = new System.Windows.Forms.Button();
            this.Bu_Ok = new System.Windows.Forms.Button();
            this.TrBa_Percent = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RaBu_Custom = new System.Windows.Forms.RadioButton();
            this.RaBu_Blue = new System.Windows.Forms.RadioButton();
            this.RaBu_Green = new System.Windows.Forms.RadioButton();
            this.RaBu_Red = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TrBa_BluePercent = new System.Windows.Forms.TrackBar();
            this.TrBa_GreenPercent = new System.Windows.Forms.TrackBar();
            this.TrBa_RedPercent = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TrBa_Value = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RaBu_Value = new System.Windows.Forms.RadioButton();
            this.RaBu_Percent = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Bu_Clear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrBa_Percent)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrBa_BluePercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBa_GreenPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBa_RedPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBa_Value)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bu_Cancel
            // 
            this.Bu_Cancel.Location = new System.Drawing.Point(137, 275);
            this.Bu_Cancel.Name = "Bu_Cancel";
            this.Bu_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Bu_Cancel.TabIndex = 0;
            this.Bu_Cancel.Text = "Cancel";
            this.Bu_Cancel.UseVisualStyleBackColor = true;
            this.Bu_Cancel.Click += new System.EventHandler(this.Bu_Cancel_Click);
            // 
            // Bu_Ok
            // 
            this.Bu_Ok.Location = new System.Drawing.Point(56, 275);
            this.Bu_Ok.Name = "Bu_Ok";
            this.Bu_Ok.Size = new System.Drawing.Size(75, 23);
            this.Bu_Ok.TabIndex = 1;
            this.Bu_Ok.Text = "Ok";
            this.Bu_Ok.UseVisualStyleBackColor = true;
            this.Bu_Ok.Click += new System.EventHandler(this.Bu_Ok_Click);
            // 
            // TrBa_Percent
            // 
            this.TrBa_Percent.Enabled = false;
            this.TrBa_Percent.Location = new System.Drawing.Point(12, 158);
            this.TrBa_Percent.Maximum = 80;
            this.TrBa_Percent.Minimum = 20;
            this.TrBa_Percent.Name = "TrBa_Percent";
            this.TrBa_Percent.Size = new System.Drawing.Size(243, 56);
            this.TrBa_Percent.TabIndex = 2;
            this.TrBa_Percent.Value = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RaBu_Custom);
            this.groupBox1.Controls.Add(this.RaBu_Blue);
            this.groupBox1.Controls.Add(this.RaBu_Green);
            this.groupBox1.Controls.Add(this.RaBu_Red);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 142);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colours";
            // 
            // RaBu_Custom
            // 
            this.RaBu_Custom.AutoSize = true;
            this.RaBu_Custom.Location = new System.Drawing.Point(6, 104);
            this.RaBu_Custom.Name = "RaBu_Custom";
            this.RaBu_Custom.Size = new System.Drawing.Size(76, 21);
            this.RaBu_Custom.TabIndex = 3;
            this.RaBu_Custom.TabStop = true;
            this.RaBu_Custom.Text = "Custom";
            this.RaBu_Custom.UseVisualStyleBackColor = true;
            this.RaBu_Custom.CheckedChanged += new System.EventHandler(this.RaBu_Custom_CheckedChanged);
            // 
            // RaBu_Blue
            // 
            this.RaBu_Blue.AutoSize = true;
            this.RaBu_Blue.Location = new System.Drawing.Point(6, 77);
            this.RaBu_Blue.Name = "RaBu_Blue";
            this.RaBu_Blue.Size = new System.Drawing.Size(57, 21);
            this.RaBu_Blue.TabIndex = 2;
            this.RaBu_Blue.TabStop = true;
            this.RaBu_Blue.Text = "Blue";
            this.RaBu_Blue.UseVisualStyleBackColor = true;
            this.RaBu_Blue.CheckedChanged += new System.EventHandler(this.RaBu_Blue_CheckedChanged);
            // 
            // RaBu_Green
            // 
            this.RaBu_Green.AutoSize = true;
            this.RaBu_Green.Location = new System.Drawing.Point(7, 50);
            this.RaBu_Green.Name = "RaBu_Green";
            this.RaBu_Green.Size = new System.Drawing.Size(69, 21);
            this.RaBu_Green.TabIndex = 1;
            this.RaBu_Green.TabStop = true;
            this.RaBu_Green.Text = "Green";
            this.RaBu_Green.UseVisualStyleBackColor = true;
            this.RaBu_Green.CheckedChanged += new System.EventHandler(this.RaBu_Green_CheckedChanged);
            // 
            // RaBu_Red
            // 
            this.RaBu_Red.AutoSize = true;
            this.RaBu_Red.Checked = true;
            this.RaBu_Red.Location = new System.Drawing.Point(7, 22);
            this.RaBu_Red.Name = "RaBu_Red";
            this.RaBu_Red.Size = new System.Drawing.Size(55, 21);
            this.RaBu_Red.TabIndex = 0;
            this.RaBu_Red.TabStop = true;
            this.RaBu_Red.Text = "Red";
            this.RaBu_Red.UseVisualStyleBackColor = true;
            this.RaBu_Red.CheckedChanged += new System.EventHandler(this.RaBu_Red_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "1000";
            // 
            // TrBa_BluePercent
            // 
            this.TrBa_BluePercent.Enabled = false;
            this.TrBa_BluePercent.Location = new System.Drawing.Point(235, 22);
            this.TrBa_BluePercent.Maximum = 100;
            this.TrBa_BluePercent.Name = "TrBa_BluePercent";
            this.TrBa_BluePercent.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrBa_BluePercent.Size = new System.Drawing.Size(56, 143);
            this.TrBa_BluePercent.TabIndex = 6;
            this.TrBa_BluePercent.Value = 33;
            this.TrBa_BluePercent.Scroll += new System.EventHandler(this.TrBa_BluePercent_Scroll);
            // 
            // TrBa_GreenPercent
            // 
            this.TrBa_GreenPercent.Enabled = false;
            this.TrBa_GreenPercent.Location = new System.Drawing.Point(173, 22);
            this.TrBa_GreenPercent.Maximum = 100;
            this.TrBa_GreenPercent.Name = "TrBa_GreenPercent";
            this.TrBa_GreenPercent.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrBa_GreenPercent.Size = new System.Drawing.Size(56, 143);
            this.TrBa_GreenPercent.TabIndex = 7;
            this.TrBa_GreenPercent.Value = 33;
            this.TrBa_GreenPercent.Scroll += new System.EventHandler(this.TrBa_GreenPercent_Scroll);
            // 
            // TrBa_RedPercent
            // 
            this.TrBa_RedPercent.Enabled = false;
            this.TrBa_RedPercent.Location = new System.Drawing.Point(111, 22);
            this.TrBa_RedPercent.Maximum = 100;
            this.TrBa_RedPercent.Name = "TrBa_RedPercent";
            this.TrBa_RedPercent.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrBa_RedPercent.Size = new System.Drawing.Size(56, 143);
            this.TrBa_RedPercent.TabIndex = 8;
            this.TrBa_RedPercent.Value = 33;
            this.TrBa_RedPercent.Scroll += new System.EventHandler(this.TrBa_RedPercent_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Green";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Blue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "100%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "0%";
            // 
            // TrBa_Value
            // 
            this.TrBa_Value.Location = new System.Drawing.Point(12, 213);
            this.TrBa_Value.Maximum = 1000;
            this.TrBa_Value.Minimum = 100;
            this.TrBa_Value.Name = "TrBa_Value";
            this.TrBa_Value.Size = new System.Drawing.Size(243, 56);
            this.TrBa_Value.TabIndex = 14;
            this.TrBa_Value.Value = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RaBu_Value);
            this.groupBox2.Controls.Add(this.RaBu_Percent);
            this.groupBox2.Location = new System.Drawing.Point(265, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(86, 87);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fill";
            // 
            // RaBu_Value
            // 
            this.RaBu_Value.AutoSize = true;
            this.RaBu_Value.Checked = true;
            this.RaBu_Value.Location = new System.Drawing.Point(6, 49);
            this.RaBu_Value.Name = "RaBu_Value";
            this.RaBu_Value.Size = new System.Drawing.Size(65, 21);
            this.RaBu_Value.TabIndex = 5;
            this.RaBu_Value.TabStop = true;
            this.RaBu_Value.Text = "Value";
            this.RaBu_Value.UseVisualStyleBackColor = true;
            this.RaBu_Value.CheckedChanged += new System.EventHandler(this.RaBu_Value_CheckedChanged);
            // 
            // RaBu_Percent
            // 
            this.RaBu_Percent.AutoSize = true;
            this.RaBu_Percent.Location = new System.Drawing.Point(6, 22);
            this.RaBu_Percent.Name = "RaBu_Percent";
            this.RaBu_Percent.Size = new System.Drawing.Size(78, 21);
            this.RaBu_Percent.TabIndex = 4;
            this.RaBu_Percent.TabStop = true;
            this.RaBu_Percent.Text = "Percent";
            this.RaBu_Percent.UseVisualStyleBackColor = true;
            this.RaBu_Percent.CheckedChanged += new System.EventHandler(this.RaBu_Percent_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "80%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "20%";
            // 
            // Bu_Clear
            // 
            this.Bu_Clear.Location = new System.Drawing.Point(218, 275);
            this.Bu_Clear.Name = "Bu_Clear";
            this.Bu_Clear.Size = new System.Drawing.Size(75, 23);
            this.Bu_Clear.TabIndex = 18;
            this.Bu_Clear.Text = "Clear";
            this.Bu_Clear.UseVisualStyleBackColor = true;
            this.Bu_Clear.Click += new System.EventHandler(this.Bu_Clear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Number of Cells";
            // 
            // PatternModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 309);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Bu_Clear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrBa_Value);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bu_Ok);
            this.Controls.Add(this.Bu_Cancel);
            this.Controls.Add(this.TrBa_Percent);
            this.Controls.Add(this.TrBa_BluePercent);
            this.Controls.Add(this.TrBa_GreenPercent);
            this.Controls.Add(this.TrBa_RedPercent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PatternModel";
            this.Text = "Pattern";
            ((System.ComponentModel.ISupportInitialize)(this.TrBa_Percent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrBa_BluePercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBa_GreenPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBa_RedPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrBa_Value)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bu_Cancel;
        private System.Windows.Forms.Button Bu_Ok;
        private System.Windows.Forms.TrackBar TrBa_Percent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RaBu_Blue;
        private System.Windows.Forms.RadioButton RaBu_Green;
        private System.Windows.Forms.RadioButton RaBu_Red;
        private System.Windows.Forms.RadioButton RaBu_Custom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar TrBa_BluePercent;
        private System.Windows.Forms.TrackBar TrBa_GreenPercent;
        private System.Windows.Forms.TrackBar TrBa_RedPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar TrBa_Value;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RaBu_Value;
        private System.Windows.Forms.RadioButton RaBu_Percent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Bu_Clear;
        private System.Windows.Forms.Label label10;
    }
}