namespace ElektroApp
{
    partial class Volt
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbAmpere = new System.Windows.Forms.TextBox();
            this.tbOhm = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calcIR = new System.Windows.Forms.Button();
            this.answerIR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWatt = new System.Windows.Forms.TextBox();
            this.tbAmp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAmpere2 = new System.Windows.Forms.Label();
            this.calcPI = new System.Windows.Forms.Button();
            this.answerPI = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ampere (strøm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ohm (resistans)";
            // 
            // tbAmpere
            // 
            this.tbAmpere.Location = new System.Drawing.Point(107, 9);
            this.tbAmpere.Name = "tbAmpere";
            this.tbAmpere.Size = new System.Drawing.Size(41, 20);
            this.tbAmpere.TabIndex = 2;
            this.tbAmpere.TextChanged += new System.EventHandler(this.tbAmpere_TextChanged);
            // 
            // tbOhm
            // 
            this.tbOhm.Location = new System.Drawing.Point(107, 32);
            this.tbOhm.Name = "tbOhm";
            this.tbOhm.Size = new System.Drawing.Size(41, 20);
            this.tbOhm.TabIndex = 3;
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(152, 12);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(14, 13);
            this.A.TabIndex = 4;
            this.A.Text = "A";
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ω";
            // 
            // calcIR
            // 
            this.calcIR.Location = new System.Drawing.Point(12, 58);
            this.calcIR.Name = "calcIR";
            this.calcIR.Size = new System.Drawing.Size(154, 33);
            this.calcIR.TabIndex = 6;
            this.calcIR.Text = "Regn ut";
            this.calcIR.UseVisualStyleBackColor = true;
            this.calcIR.Click += new System.EventHandler(this.calcIR_Click);
            // 
            // answerIR
            // 
            this.answerIR.AutoSize = true;
            this.answerIR.Location = new System.Drawing.Point(12, 94);
            this.answerIR.Name = "answerIR";
            this.answerIR.Size = new System.Drawing.Size(32, 13);
            this.answerIR.TabIndex = 7;
            this.answerIR.Text = "Svar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Watt (effekt)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ampere (strøm)";
            // 
            // tbWatt
            // 
            this.tbWatt.Location = new System.Drawing.Point(107, 136);
            this.tbWatt.Name = "tbWatt";
            this.tbWatt.Size = new System.Drawing.Size(41, 20);
            this.tbWatt.TabIndex = 10;
            // 
            // tbAmp
            // 
            this.tbAmp.Location = new System.Drawing.Point(107, 158);
            this.tbAmp.Name = "tbAmp";
            this.tbAmp.Size = new System.Drawing.Size(41, 20);
            this.tbAmp.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "W";
            // 
            // tbAmpere2
            // 
            this.tbAmpere2.AutoSize = true;
            this.tbAmpere2.Location = new System.Drawing.Point(152, 161);
            this.tbAmpere2.Name = "tbAmpere2";
            this.tbAmpere2.Size = new System.Drawing.Size(14, 13);
            this.tbAmpere2.TabIndex = 13;
            this.tbAmpere2.Text = "A";
            // 
            // calcPI
            // 
            this.calcPI.Location = new System.Drawing.Point(15, 187);
            this.calcPI.Name = "calcPI";
            this.calcPI.Size = new System.Drawing.Size(154, 33);
            this.calcPI.TabIndex = 14;
            this.calcPI.Text = "Regn ut";
            this.calcPI.UseVisualStyleBackColor = true;
            this.calcPI.Click += new System.EventHandler(this.calcPI_Click);
            // 
            // answerPI
            // 
            this.answerPI.AutoSize = true;
            this.answerPI.Location = new System.Drawing.Point(12, 223);
            this.answerPI.Name = "answerPI";
            this.answerPI.Size = new System.Drawing.Size(35, 13);
            this.answerPI.TabIndex = 15;
            this.answerPI.Text = "Svar: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Tilbake";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "I (strøm) / R (resistans)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "P (effekt) / I (strøm)";
            // 
            // Volt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 278);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answerPI);
            this.Controls.Add(this.calcPI);
            this.Controls.Add(this.tbAmpere2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAmp);
            this.Controls.Add(this.tbWatt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.answerIR);
            this.Controls.Add(this.calcIR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.A);
            this.Controls.Add(this.tbOhm);
            this.Controls.Add(this.tbAmpere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Volt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAmpere;
        private System.Windows.Forms.TextBox tbOhm;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calcIR;
        private System.Windows.Forms.Label answerIR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbWatt;
        private System.Windows.Forms.TextBox tbAmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tbAmpere2;
        private System.Windows.Forms.Button calcPI;
        private System.Windows.Forms.Label answerPI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}