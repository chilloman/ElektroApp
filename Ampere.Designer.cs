namespace ElektroApp
{
    partial class Ampere
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.answerUR = new System.Windows.Forms.Label();
            this.calcUR = new System.Windows.Forms.Button();
            this.tbAmpere2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOhm = new System.Windows.Forms.TextBox();
            this.tbVolt1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.answerPU = new System.Windows.Forms.Label();
            this.calcPU = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.tbVolt = new System.Windows.Forms.TextBox();
            this.tbWatt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "U (spenning) / R (motstand)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "P (effekt) / U (spenning)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Tilbake";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // answerUR
            // 
            this.answerUR.AutoSize = true;
            this.answerUR.Location = new System.Drawing.Point(12, 220);
            this.answerUR.Name = "answerUR";
            this.answerUR.Size = new System.Drawing.Size(35, 13);
            this.answerUR.TabIndex = 34;
            this.answerUR.Text = "Svar: ";
            // 
            // calcUR
            // 
            this.calcUR.Location = new System.Drawing.Point(15, 184);
            this.calcUR.Name = "calcUR";
            this.calcUR.Size = new System.Drawing.Size(154, 33);
            this.calcUR.TabIndex = 33;
            this.calcUR.Text = "Regn ut";
            this.calcUR.UseVisualStyleBackColor = true;
            this.calcUR.Click += new System.EventHandler(this.calcUR_Click);
            // 
            // tbAmpere2
            // 
            this.tbAmpere2.AutoSize = true;
            this.tbAmpere2.Location = new System.Drawing.Point(152, 158);
            this.tbAmpere2.Name = "tbAmpere2";
            this.tbAmpere2.Size = new System.Drawing.Size(16, 13);
            this.tbAmpere2.TabIndex = 32;
            this.tbAmpere2.Text = "Ω";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "V";
            // 
            // tbOhm
            // 
            this.tbOhm.Location = new System.Drawing.Point(107, 155);
            this.tbOhm.Name = "tbOhm";
            this.tbOhm.Size = new System.Drawing.Size(41, 20);
            this.tbOhm.TabIndex = 30;
            // 
            // tbVolt1
            // 
            this.tbVolt1.Location = new System.Drawing.Point(107, 133);
            this.tbVolt1.Name = "tbVolt1";
            this.tbVolt1.Size = new System.Drawing.Size(41, 20);
            this.tbVolt1.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ohm (motstand)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Volt (spenning)";
            // 
            // answerPU
            // 
            this.answerPU.AutoSize = true;
            this.answerPU.Location = new System.Drawing.Point(12, 91);
            this.answerPU.Name = "answerPU";
            this.answerPU.Size = new System.Drawing.Size(32, 13);
            this.answerPU.TabIndex = 26;
            this.answerPU.Text = "Svar:";
            // 
            // calcPU
            // 
            this.calcPU.Location = new System.Drawing.Point(12, 55);
            this.calcPU.Name = "calcPU";
            this.calcPU.Size = new System.Drawing.Size(154, 33);
            this.calcPU.TabIndex = 25;
            this.calcPU.Text = "Regn ut";
            this.calcPU.UseVisualStyleBackColor = true;
            this.calcPU.Click += new System.EventHandler(this.calcPU_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "V";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(152, 9);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(18, 13);
            this.A.TabIndex = 23;
            this.A.Text = "W";
            // 
            // tbVolt
            // 
            this.tbVolt.Location = new System.Drawing.Point(107, 29);
            this.tbVolt.Name = "tbVolt";
            this.tbVolt.Size = new System.Drawing.Size(41, 20);
            this.tbVolt.TabIndex = 22;
            // 
            // tbWatt
            // 
            this.tbWatt.Location = new System.Drawing.Point(107, 6);
            this.tbWatt.Name = "tbWatt";
            this.tbWatt.Size = new System.Drawing.Size(41, 20);
            this.tbWatt.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Volt (spenning)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Watt (effekt)";
            // 
            // Ampere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 278);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answerUR);
            this.Controls.Add(this.calcUR);
            this.Controls.Add(this.tbAmpere2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbOhm);
            this.Controls.Add(this.tbVolt1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.answerPU);
            this.Controls.Add(this.calcPU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.A);
            this.Controls.Add(this.tbVolt);
            this.Controls.Add(this.tbWatt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ampere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ampere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label answerUR;
        private System.Windows.Forms.Button calcUR;
        private System.Windows.Forms.Label tbAmpere2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOhm;
        private System.Windows.Forms.TextBox tbVolt1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label answerPU;
        private System.Windows.Forms.Button calcPU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.TextBox tbVolt;
        private System.Windows.Forms.TextBox tbWatt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}