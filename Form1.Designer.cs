namespace ElektroApp
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
            this.btVolt = new System.Windows.Forms.Button();
            this.btOhm = new System.Windows.Forms.Button();
            this.btAmpere = new System.Windows.Forms.Button();
            this.btWatt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btVolt
            // 
            this.btVolt.Location = new System.Drawing.Point(12, 12);
            this.btVolt.Name = "btVolt";
            this.btVolt.Size = new System.Drawing.Size(300, 36);
            this.btVolt.TabIndex = 0;
            this.btVolt.Text = "Volt";
            this.btVolt.UseVisualStyleBackColor = true;
            this.btVolt.Click += new System.EventHandler(this.btVolt_Click);
            // 
            // btOhm
            // 
            this.btOhm.Location = new System.Drawing.Point(12, 54);
            this.btOhm.Name = "btOhm";
            this.btOhm.Size = new System.Drawing.Size(300, 36);
            this.btOhm.TabIndex = 1;
            this.btOhm.Text = "Ohm";
            this.btOhm.UseVisualStyleBackColor = true;
            this.btOhm.Click += new System.EventHandler(this.btOhm_Click);
            // 
            // btAmpere
            // 
            this.btAmpere.Location = new System.Drawing.Point(12, 96);
            this.btAmpere.Name = "btAmpere";
            this.btAmpere.Size = new System.Drawing.Size(300, 35);
            this.btAmpere.TabIndex = 2;
            this.btAmpere.Text = "Ampere";
            this.btAmpere.UseVisualStyleBackColor = true;
            this.btAmpere.Click += new System.EventHandler(this.btAmpere_Click);
            // 
            // btWatt
            // 
            this.btWatt.Location = new System.Drawing.Point(12, 137);
            this.btWatt.Name = "btWatt";
            this.btWatt.Size = new System.Drawing.Size(300, 34);
            this.btWatt.TabIndex = 3;
            this.btWatt.Text = "Watt";
            this.btWatt.UseVisualStyleBackColor = true;
            this.btWatt.Click += new System.EventHandler(this.btWatt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Laget av Vebjørn Hallås © 2012";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(12, 200);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(300, 37);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Avslutt";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 278);
            this.ControlBox = false;
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWatt);
            this.Controls.Add(this.btAmpere);
            this.Controls.Add(this.btOhm);
            this.Controls.Add(this.btVolt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElektroApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVolt;
        private System.Windows.Forms.Button btOhm;
        private System.Windows.Forms.Button btAmpere;
        private System.Windows.Forms.Button btWatt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExit;
    }
}

