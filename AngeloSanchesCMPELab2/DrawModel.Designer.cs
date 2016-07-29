namespace AngeloSanchesCMPELab2
{
    partial class DrawModel
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
            this.Bu_Colour = new System.Windows.Forms.Button();
            this.Bu_Ok = new System.Windows.Forms.Button();
            this.Bu_ReSize = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Bu_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.DrawCheck = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bu_Colour
            // 
            this.Bu_Colour.Location = new System.Drawing.Point(12, 12);
            this.Bu_Colour.Name = "Bu_Colour";
            this.Bu_Colour.Size = new System.Drawing.Size(75, 56);
            this.Bu_Colour.TabIndex = 0;
            this.Bu_Colour.Text = "Colour";
            this.Bu_Colour.UseVisualStyleBackColor = true;
            this.Bu_Colour.Click += new System.EventHandler(this.Bu_Colour_Click);
            // 
            // Bu_Ok
            // 
            this.Bu_Ok.Location = new System.Drawing.Point(12, 100);
            this.Bu_Ok.Name = "Bu_Ok";
            this.Bu_Ok.Size = new System.Drawing.Size(121, 23);
            this.Bu_Ok.TabIndex = 1;
            this.Bu_Ok.Text = "Ok";
            this.Bu_Ok.UseVisualStyleBackColor = true;
            this.Bu_Ok.Click += new System.EventHandler(this.Bu_Ok_Click);
            // 
            // Bu_ReSize
            // 
            this.Bu_ReSize.Location = new System.Drawing.Point(12, 71);
            this.Bu_ReSize.Name = "Bu_ReSize";
            this.Bu_ReSize.Size = new System.Drawing.Size(258, 23);
            this.Bu_ReSize.TabIndex = 2;
            this.Bu_ReSize.Text = "Resize";
            this.Bu_ReSize.UseVisualStyleBackColor = true;
            this.Bu_ReSize.Click += new System.EventHandler(this.Bu_ReSize_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(93, 12);
            this.trackBar1.Maximum = 31;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(177, 56);
            this.trackBar1.SmallChange = 2;
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 1;
            // 
            // Bu_Cancel
            // 
            this.Bu_Cancel.Location = new System.Drawing.Point(139, 100);
            this.Bu_Cancel.Name = "Bu_Cancel";
            this.Bu_Cancel.Size = new System.Drawing.Size(131, 23);
            this.Bu_Cancel.TabIndex = 4;
            this.Bu_Cancel.Text = "Cancel";
            this.Bu_Cancel.UseVisualStyleBackColor = true;
            this.Bu_Cancel.Click += new System.EventHandler(this.Bu_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "31";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // DrawCheck
            // 
            this.DrawCheck.Tick += new System.EventHandler(this.DrawCheck_Tick);
            // 
            // DrawModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 138);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bu_Cancel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Bu_ReSize);
            this.Controls.Add(this.Bu_Ok);
            this.Controls.Add(this.Bu_Colour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DrawModel";
            this.Text = "Draw";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bu_Colour;
        private System.Windows.Forms.Button Bu_Ok;
        private System.Windows.Forms.Button Bu_ReSize;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Bu_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer DrawCheck;
    }
}