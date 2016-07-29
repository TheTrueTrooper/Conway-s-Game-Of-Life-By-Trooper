namespace AngeloSanchesCMPELab2
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
            this.Bu_NewPattern = new System.Windows.Forms.Button();
            this.Bu_Draw = new System.Windows.Forms.Button();
            this.Bu_Start = new System.Windows.Forms.Button();
            this.Bu_Stop = new System.Windows.Forms.Button();
            this.Bu_Cycle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DrawChecker = new System.Windows.Forms.Timer(this.components);
            this.LifeCycle = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Ch_DrawShape = new System.Windows.Forms.CheckBox();
            this.Tb_Cycles = new System.Windows.Forms.TextBox();
            this.Ch_DoNotDrawClear = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Bu_NewPattern
            // 
            this.Bu_NewPattern.Location = new System.Drawing.Point(71, 12);
            this.Bu_NewPattern.Name = "Bu_NewPattern";
            this.Bu_NewPattern.Size = new System.Drawing.Size(111, 23);
            this.Bu_NewPattern.TabIndex = 0;
            this.Bu_NewPattern.Text = "New Pattern";
            this.Bu_NewPattern.UseVisualStyleBackColor = true;
            this.Bu_NewPattern.Click += new System.EventHandler(this.Bu_NewPattern_Click);
            // 
            // Bu_Draw
            // 
            this.Bu_Draw.Location = new System.Drawing.Point(25, 171);
            this.Bu_Draw.Name = "Bu_Draw";
            this.Bu_Draw.Size = new System.Drawing.Size(75, 23);
            this.Bu_Draw.TabIndex = 1;
            this.Bu_Draw.Text = "Draw";
            this.Bu_Draw.UseVisualStyleBackColor = true;
            this.Bu_Draw.Click += new System.EventHandler(this.Bu_Draw_Click);
            // 
            // Bu_Start
            // 
            this.Bu_Start.Location = new System.Drawing.Point(25, 200);
            this.Bu_Start.Name = "Bu_Start";
            this.Bu_Start.Size = new System.Drawing.Size(75, 23);
            this.Bu_Start.TabIndex = 2;
            this.Bu_Start.Text = "Start";
            this.Bu_Start.UseVisualStyleBackColor = true;
            this.Bu_Start.Click += new System.EventHandler(this.Bu_Start_Click);
            // 
            // Bu_Stop
            // 
            this.Bu_Stop.Enabled = false;
            this.Bu_Stop.Location = new System.Drawing.Point(101, 200);
            this.Bu_Stop.Name = "Bu_Stop";
            this.Bu_Stop.Size = new System.Drawing.Size(75, 23);
            this.Bu_Stop.TabIndex = 3;
            this.Bu_Stop.Text = "Stop";
            this.Bu_Stop.UseVisualStyleBackColor = true;
            this.Bu_Stop.Click += new System.EventHandler(this.Bu_Stop_Click);
            // 
            // Bu_Cycle
            // 
            this.Bu_Cycle.Location = new System.Drawing.Point(182, 200);
            this.Bu_Cycle.Name = "Bu_Cycle";
            this.Bu_Cycle.Size = new System.Drawing.Size(75, 23);
            this.Bu_Cycle.TabIndex = 4;
            this.Bu_Cycle.Text = "Cycle";
            this.Bu_Cycle.UseVisualStyleBackColor = true;
            this.Bu_Cycle.Click += new System.EventHandler(this.Bu_Cycles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cycle";
            // 
            // DrawChecker
            // 
            this.DrawChecker.Tick += new System.EventHandler(this.DrawChecker_Tick);
            // 
            // LifeCycle
            // 
            this.LifeCycle.Tick += new System.EventHandler(this.LifeCycle_Tick);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // Ch_DrawShape
            // 
            this.Ch_DrawShape.AutoSize = true;
            this.Ch_DrawShape.Location = new System.Drawing.Point(107, 172);
            this.Ch_DrawShape.Name = "Ch_DrawShape";
            this.Ch_DrawShape.Size = new System.Drawing.Size(107, 21);
            this.Ch_DrawShape.TabIndex = 6;
            this.Ch_DrawShape.Text = "Draw Shape";
            this.Ch_DrawShape.UseVisualStyleBackColor = true;
            // 
            // Tb_Cycles
            // 
            this.Tb_Cycles.Location = new System.Drawing.Point(119, 77);
            this.Tb_Cycles.Name = "Tb_Cycles";
            this.Tb_Cycles.ReadOnly = true;
            this.Tb_Cycles.Size = new System.Drawing.Size(75, 22);
            this.Tb_Cycles.TabIndex = 7;
            this.Tb_Cycles.Text = "0";
            this.Tb_Cycles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ch_DoNotDrawClear
            // 
            this.Ch_DoNotDrawClear.AutoSize = true;
            this.Ch_DoNotDrawClear.Location = new System.Drawing.Point(107, 145);
            this.Ch_DoNotDrawClear.Name = "Ch_DoNotDrawClear";
            this.Ch_DoNotDrawClear.Size = new System.Drawing.Size(147, 21);
            this.Ch_DoNotDrawClear.TabIndex = 8;
            this.Ch_DoNotDrawClear.Text = "Do Not Draw Clear";
            this.Ch_DoNotDrawClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.Ch_DoNotDrawClear);
            this.Controls.Add(this.Tb_Cycles);
            this.Controls.Add(this.Ch_DrawShape);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bu_Cycle);
            this.Controls.Add(this.Bu_Stop);
            this.Controls.Add(this.Bu_Start);
            this.Controls.Add(this.Bu_Draw);
            this.Controls.Add(this.Bu_NewPattern);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bu_NewPattern;
        private System.Windows.Forms.Button Bu_Draw;
        private System.Windows.Forms.Button Bu_Stop;
        private System.Windows.Forms.Button Bu_Cycle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bu_Start;
        private System.Windows.Forms.Timer DrawChecker;
        private System.Windows.Forms.Timer LifeCycle;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox Ch_DrawShape;
        private System.Windows.Forms.TextBox Tb_Cycles;
        private System.Windows.Forms.CheckBox Ch_DoNotDrawClear;
    }
}

