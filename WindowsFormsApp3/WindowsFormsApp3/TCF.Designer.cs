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
            this.label1 = new System.Windows.Forms.Label();
            this.DIBox = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TCFBoxINT = new System.Windows.Forms.TextBox();
            this.PLFW = new System.Windows.Forms.ComboBox();
            this.locbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FPPL = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FPBoxInternal = new System.Windows.Forms.TextBox();
            this.calctcfINT = new System.Windows.Forms.Button();
            this.FPNFINT = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DIBox
            // 
            this.DIBox.Location = new System.Drawing.Point(448, 170);
            this.DIBox.Name = "DIBox";
            this.DIBox.Size = new System.Drawing.Size(100, 20);
            this.DIBox.TabIndex = 1;
            this.DIBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(460, 213);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 19);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Internal DI";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "TCF Internal";
            // 
            // TCFBoxINT
            // 
            this.TCFBoxINT.Location = new System.Drawing.Point(146, 30);
            this.TCFBoxINT.Name = "TCFBoxINT";
            this.TCFBoxINT.Size = new System.Drawing.Size(100, 21);
            this.TCFBoxINT.TabIndex = 6;
            this.TCFBoxINT.TextChanged += new System.EventHandler(this.TCFBox_TextChanged);
            // 
            // PLFW
            // 
            this.PLFW.FormattingEnabled = true;
            this.PLFW.Items.AddRange(new object[] {
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
            this.PLFW.Location = new System.Drawing.Point(42, 126);
            this.PLFW.Name = "PLFW";
            this.PLFW.Size = new System.Drawing.Size(227, 23);
            this.PLFW.TabIndex = 9;
            this.PLFW.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // locbox
            // 
            this.locbox.Location = new System.Drawing.Point(42, 197);
            this.locbox.Name = "locbox";
            this.locbox.Size = new System.Drawing.Size(227, 21);
            this.locbox.TabIndex = 11;
            this.locbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FPPL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PLFW);
            this.groupBox1.Controls.Add(this.locbox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(570, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 360);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programing language Factors";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FPPL
            // 
            this.FPPL.BackColor = System.Drawing.Color.White;
            this.FPPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPPL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FPPL.Location = new System.Drawing.Point(87, 251);
            this.FPPL.Name = "FPPL";
            this.FPPL.Size = new System.Drawing.Size(139, 46);
            this.FPPL.TabIndex = 27;
            this.FPPL.Text = "LOC";
            this.FPPL.UseVisualStyleBackColor = false;
            this.FPPL.Click += new System.EventHandler(this.FPPL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Programming languages and weights ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "LOC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "Function Point";
            // 
            // FPBoxInternal
            // 
            this.FPBoxInternal.Location = new System.Drawing.Point(146, 92);
            this.FPBoxInternal.Name = "FPBoxInternal";
            this.FPBoxInternal.Size = new System.Drawing.Size(100, 21);
            this.FPBoxInternal.TabIndex = 33;
            // 
            // calctcfINT
            // 
            this.calctcfINT.BackColor = System.Drawing.Color.White;
            this.calctcfINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calctcfINT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.calctcfINT.Location = new System.Drawing.Point(283, 23);
            this.calctcfINT.Name = "calctcfINT";
            this.calctcfINT.Size = new System.Drawing.Size(88, 33);
            this.calctcfINT.TabIndex = 29;
            this.calctcfINT.Text = "Calc TCF";
            this.calctcfINT.UseVisualStyleBackColor = false;
            this.calctcfINT.Click += new System.EventHandler(this.button1_Click);
            // 
            // FPNFINT
            // 
            this.FPNFINT.BackColor = System.Drawing.Color.White;
            this.FPNFINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPNFINT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FPNFINT.Location = new System.Drawing.Point(270, 77);
            this.FPNFINT.Name = "FPNFINT";
            this.FPNFINT.Size = new System.Drawing.Size(119, 46);
            this.FPNFINT.TabIndex = 35;
            this.FPNFINT.Text = "FP By Internal DI";
            this.FPNFINT.UseVisualStyleBackColor = false;
            this.FPNFINT.Click += new System.EventHandler(this.FPNFINT_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.FPNFINT);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.FPBoxInternal);
            this.groupBox3.Controls.Add(this.TCFBoxINT);
            this.groupBox3.Controls.Add(this.calctcfINT);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 177);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Normal Factors Internal DI";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(460, 239);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 19);
            this.radioButton1.TabIndex = 37;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "External DI";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // TCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.DIBox);
            this.Name = "TCF";
            this.Text = "TCF";
            this.Load += new System.EventHandler(this.TCF_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DIBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TCFBoxINT;
        private System.Windows.Forms.ComboBox PLFW;
        private System.Windows.Forms.TextBox locbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FPPL;
        private System.Windows.Forms.Button calctcfINT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FPBoxInternal;
        private System.Windows.Forms.Button FPNFINT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}