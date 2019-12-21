namespace WindowsFormsApp3
{
    partial class TCF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TCF));
            this.label1 = new System.Windows.Forms.Label();
            this.InternelDI_RadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TCFBOX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FPBox = new System.Windows.Forms.TextBox();
            this.TCF_Button = new System.Windows.Forms.Button();
            this.ExternelDI_RadioButton = new System.Windows.Forms.RadioButton();
            this.ExternelDI_Panel = new System.Windows.Forms.Panel();
            this.FP_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DIBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ExternelDI_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InternelDI_RadioButton
            // 
            this.InternelDI_RadioButton.AutoSize = true;
            this.InternelDI_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternelDI_RadioButton.Location = new System.Drawing.Point(317, 68);
            this.InternelDI_RadioButton.Name = "InternelDI_RadioButton";
            this.InternelDI_RadioButton.Size = new System.Drawing.Size(92, 19);
            this.InternelDI_RadioButton.TabIndex = 3;
            this.InternelDI_RadioButton.Text = "Internal DI";
            this.InternelDI_RadioButton.UseVisualStyleBackColor = true;
            this.InternelDI_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "TCF Internal";
            // 
            // TCFBOX
            // 
            this.TCFBOX.Location = new System.Drawing.Point(239, 98);
            this.TCFBOX.Name = "TCFBOX";
            this.TCFBOX.Size = new System.Drawing.Size(100, 20);
            this.TCFBOX.TabIndex = 6;
            this.TCFBOX.TextChanged += new System.EventHandler(this.TCFBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "Function Point";
            // 
            // FPBox
            // 
            this.FPBox.Location = new System.Drawing.Point(239, 166);
            this.FPBox.Name = "FPBox";
            this.FPBox.Size = new System.Drawing.Size(100, 20);
            this.FPBox.TabIndex = 33;
            // 
            // TCF_Button
            // 
            this.TCF_Button.BackColor = System.Drawing.Color.White;
            this.TCF_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCF_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TCF_Button.Location = new System.Drawing.Point(402, 85);
            this.TCF_Button.Name = "TCF_Button";
            this.TCF_Button.Size = new System.Drawing.Size(160, 33);
            this.TCF_Button.TabIndex = 29;
            this.TCF_Button.Text = " Calculate TCF";
            this.TCF_Button.UseVisualStyleBackColor = false;
            this.TCF_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExternelDI_RadioButton
            // 
            this.ExternelDI_RadioButton.AutoSize = true;
            this.ExternelDI_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExternelDI_RadioButton.Location = new System.Drawing.Point(317, 106);
            this.ExternelDI_RadioButton.Name = "ExternelDI_RadioButton";
            this.ExternelDI_RadioButton.Size = new System.Drawing.Size(96, 19);
            this.ExternelDI_RadioButton.TabIndex = 37;
            this.ExternelDI_RadioButton.Text = "External DI";
            this.ExternelDI_RadioButton.UseVisualStyleBackColor = true;
            this.ExternelDI_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ExternelDI_Panel
            // 
            this.ExternelDI_Panel.Controls.Add(this.FP_Button);
            this.ExternelDI_Panel.Controls.Add(this.label3);
            this.ExternelDI_Panel.Controls.Add(this.DIBox);
            this.ExternelDI_Panel.Controls.Add(this.TCF_Button);
            this.ExternelDI_Panel.Controls.Add(this.TCFBOX);
            this.ExternelDI_Panel.Controls.Add(this.label7);
            this.ExternelDI_Panel.Controls.Add(this.FPBox);
            this.ExternelDI_Panel.Controls.Add(this.label2);
            this.ExternelDI_Panel.Location = new System.Drawing.Point(51, 141);
            this.ExternelDI_Panel.Name = "ExternelDI_Panel";
            this.ExternelDI_Panel.Size = new System.Drawing.Size(597, 279);
            this.ExternelDI_Panel.TabIndex = 38;
            // 
            // FP_Button
            // 
            this.FP_Button.BackColor = System.Drawing.Color.White;
            this.FP_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FP_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FP_Button.Location = new System.Drawing.Point(402, 145);
            this.FP_Button.Name = "FP_Button";
            this.FP_Button.Size = new System.Drawing.Size(160, 59);
            this.FP_Button.TabIndex = 39;
            this.FP_Button.Text = "Calculate Function Point";
            this.FP_Button.UseVisualStyleBackColor = false;
            this.FP_Button.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "DI";
            // 
            // DIBox
            // 
            this.DIBox.Location = new System.Drawing.Point(239, 46);
            this.DIBox.Name = "DIBox";
            this.DIBox.Size = new System.Drawing.Size(100, 20);
            this.DIBox.TabIndex = 36;
            this.DIBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_3);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(667, 413);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 103;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(680, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 160;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // TCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(740, 470);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExternelDI_Panel);
            this.Controls.Add(this.ExternelDI_RadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InternelDI_RadioButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TCF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCF";
            this.Load += new System.EventHandler(this.TCF_Load);
            this.ExternelDI_Panel.ResumeLayout(false);
            this.ExternelDI_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton InternelDI_RadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TCFBOX;
        private System.Windows.Forms.Button TCF_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FPBox;
        private System.Windows.Forms.RadioButton ExternelDI_RadioButton;
        private System.Windows.Forms.Panel ExternelDI_Panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DIBox;
        private System.Windows.Forms.Button FP_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}