﻿namespace WindowsFormsApp3
{
    partial class LOC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOC));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AVC_Combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FPLOC = new System.Windows.Forms.TextBox();
            this.LOC_Button = new System.Windows.Forms.Button();
            this.LOC_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(191, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculate Line of Code";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(484, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(83, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Programing Language";
            // 
            // AVC_Combo
            // 
            this.AVC_Combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AVC_Combo.FormattingEnabled = true;
            this.AVC_Combo.Items.AddRange(new object[] {
            "Assembly Language ( 320 )",
            "C ( 128 )",
            "COBOL/Fortran ( 105 )",
            "Pascal ( 90 ) ",
            "Ada ( 70 )",
            "C++ ( 64 )",
            "Visual basic ( 32 )",
            "Object Oriented Languages ( 30 )",
            "Smalltalk ( 22 )",
            "Code Generators (15 )",
            "SQL/ORACLE ( 12 )",
            "Spreadsheets ( 6 )",
            "Graphical Languages ( 4 )"});
            this.AVC_Combo.Location = new System.Drawing.Point(315, 159);
            this.AVC_Combo.Name = "AVC_Combo";
            this.AVC_Combo.Size = new System.Drawing.Size(121, 21);
            this.AVC_Combo.TabIndex = 3;
            this.AVC_Combo.SelectedIndexChanged += new System.EventHandler(this.AVC_Combo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(109, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Function point";
            // 
            // FPLOC
            // 
            this.FPLOC.Location = new System.Drawing.Point(315, 216);
            this.FPLOC.Name = "FPLOC";
            this.FPLOC.Size = new System.Drawing.Size(121, 20);
            this.FPLOC.TabIndex = 5;
            // 
            // LOC_Button
            // 
            this.LOC_Button.BackColor = System.Drawing.Color.Transparent;
            this.LOC_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOC_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOC_Button.ForeColor = System.Drawing.Color.Indigo;
            this.LOC_Button.Location = new System.Drawing.Point(484, 274);
            this.LOC_Button.Name = "LOC_Button";
            this.LOC_Button.Size = new System.Drawing.Size(131, 37);
            this.LOC_Button.TabIndex = 6;
            this.LOC_Button.Text = "Calculate LOC";
            this.LOC_Button.UseVisualStyleBackColor = false;
            this.LOC_Button.Click += new System.EventHandler(this.LOC_Button_Click);
            // 
            // LOC_TextBox
            // 
            this.LOC_TextBox.Location = new System.Drawing.Point(315, 284);
            this.LOC_TextBox.Name = "LOC_TextBox";
            this.LOC_TextBox.Size = new System.Drawing.Size(121, 20);
            this.LOC_TextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(109, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Line of Code";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(630, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 160;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // LOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(681, 380);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LOC_TextBox);
            this.Controls.Add(this.LOC_Button);
            this.Controls.Add(this.FPLOC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AVC_Combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOC";
            this.Load += new System.EventHandler(this.LOC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AVC_Combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FPLOC;
        private System.Windows.Forms.Button LOC_Button;
        private System.Windows.Forms.TextBox LOC_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}