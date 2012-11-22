namespace ElektroApp
{
    partial class Watt
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
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.answerUI = new System.Windows.Forms.Label();
            this.calcUI = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.tbAmpere = new System.Windows.Forms.TextBox();
            this.tbVolt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "U (spenning) * I (ampere)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Tilbake";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // answerUI
            // 
            this.answerUI.AutoSize = true;
            this.answerUI.Location = new System.Drawing.Point(12, 89);
            this.answerUI.Name = "answerUI";
            this.answerUI.Size = new System.Drawing.Size(32, 13);
            this.answerUI.TabIndex = 44;
            this.answerUI.Text = "Svar:";
            // 
            // calcUI
            // 
            this.calcUI.Location = new System.Drawing.Point(12, 53);
            this.calcUI.Name = "calcUI";
            this.calcUI.Size = new System.Drawing.Size(154, 33);
            this.calcUI.TabIndex = 43;
            this.calcUI.Text = "Regn ut";
            this.calcUI.UseVisualStyleBackColor = true;
            this.calcUI.Click += new System.EventHandler(this.calcUI_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "A";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(152, 7);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(14, 13);
            this.A.TabIndex = 41;
            this.A.Text = "V";
            // 
            // tbAmpere
            // 
            this.tbAmpere.Location = new System.Drawing.Point(107, 27);
            this.tbAmpere.Name = "tbAmpere";
            this.tbAmpere.Size = new System.Drawing.Size(41, 20);
            this.tbAmpere.TabIndex = 40;
            // 
            // tbVolt
            // 
            this.tbVolt.Location = new System.Drawing.Point(107, 4);
            this.tbVolt.Name = "tbVolt";
            this.tbVolt.Size = new System.Drawing.Size(41, 20);
            this.tbVolt.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Strøm (ampere)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Spenning (volt)";
            // 
            // Watt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 278);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answerUI);
            this.Controls.Add(this.calcUI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.A);
            this.Controls.Add(this.tbAmpere);
            this.Controls.Add(this.tbVolt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Watt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label answerUI;
        private System.Windows.Forms.Button calcUI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.TextBox tbAmpere;
        private System.Windows.Forms.TextBox tbVolt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}