namespace LEDCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCustomVoltage = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbLEDdrop = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbR33 = new System.Windows.Forms.Label();
            this.tbR50 = new System.Windows.Forms.Label();
            this.tbR60 = new System.Windows.Forms.Label();
            this.tbR12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.tbCustomResistance = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(99, 35);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Size = new System.Drawing.Size(249, 20);
            this.tbCurrent.TabIndex = 1;
            this.tbCurrent.Text = "10";
            this.tbCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCurrent.TextChanged += new System.EventHandler(this.tbCurrent_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voltage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "3.3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "LED Drop:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LimeGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(8, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resistance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "[V]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "5.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(202, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "6.0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "12.0";
            // 
            // tbCustomVoltage
            // 
            this.tbCustomVoltage.Location = new System.Drawing.Point(303, 6);
            this.tbCustomVoltage.Name = "tbCustomVoltage";
            this.tbCustomVoltage.Size = new System.Drawing.Size(46, 20);
            this.tbCustomVoltage.TabIndex = 3;
            this.tbCustomVoltage.Text = "24";
            this.tbCustomVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCustomVoltage.TextChanged += new System.EventHandler(this.tbCustomVoltage_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(354, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "[mA]";
            // 
            // tbLEDdrop
            // 
            this.tbLEDdrop.Location = new System.Drawing.Point(99, 64);
            this.tbLEDdrop.Name = "tbLEDdrop";
            this.tbLEDdrop.Size = new System.Drawing.Size(249, 20);
            this.tbLEDdrop.TabIndex = 2;
            this.tbLEDdrop.Text = "2";
            this.tbLEDdrop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLEDdrop.TextChanged += new System.EventHandler(this.tbLEDdrop_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(354, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "[V]";
            // 
            // tbR33
            // 
            this.tbR33.AutoSize = true;
            this.tbR33.BackColor = System.Drawing.Color.LimeGreen;
            this.tbR33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbR33.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbR33.Location = new System.Drawing.Point(96, 103);
            this.tbR33.Name = "tbR33";
            this.tbR33.Size = new System.Drawing.Size(33, 13);
            this.tbR33.TabIndex = 2;
            this.tbR33.Text = "3.3V";
            this.tbR33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbR50
            // 
            this.tbR50.AutoSize = true;
            this.tbR50.BackColor = System.Drawing.Color.LimeGreen;
            this.tbR50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbR50.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbR50.Location = new System.Drawing.Point(147, 103);
            this.tbR50.Name = "tbR50";
            this.tbR50.Size = new System.Drawing.Size(33, 13);
            this.tbR50.TabIndex = 7;
            this.tbR50.Text = "5.0V";
            this.tbR50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbR60
            // 
            this.tbR60.AutoSize = true;
            this.tbR60.BackColor = System.Drawing.Color.LimeGreen;
            this.tbR60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbR60.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbR60.Location = new System.Drawing.Point(198, 103);
            this.tbR60.Name = "tbR60";
            this.tbR60.Size = new System.Drawing.Size(33, 13);
            this.tbR60.TabIndex = 9;
            this.tbR60.Text = "6.0V";
            this.tbR60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbR12
            // 
            this.tbR12.AutoSize = true;
            this.tbR12.BackColor = System.Drawing.Color.LimeGreen;
            this.tbR12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbR12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbR12.Location = new System.Drawing.Point(249, 103);
            this.tbR12.Name = "tbR12";
            this.tbR12.Size = new System.Drawing.Size(40, 13);
            this.tbR12.TabIndex = 9;
            this.tbR12.Text = "12.0V";
            this.tbR12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.tbCustomResistance);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(8, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 40);
            this.panel1.TabIndex = 16;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.LimeGreen;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label21.Location = new System.Drawing.Point(346, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "[Ohm]";
            // 
            // tbCustomResistance
            // 
            this.tbCustomResistance.BackColor = System.Drawing.Color.LimeGreen;
            this.tbCustomResistance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbCustomResistance.Location = new System.Drawing.Point(294, 10);
            this.tbCustomResistance.Name = "tbCustomResistance";
            this.tbCustomResistance.ReadOnly = true;
            this.tbCustomResistance.Size = new System.Drawing.Size(46, 20);
            this.tbCustomResistance.TabIndex = 17;
            this.tbCustomResistance.Text = "CC";
            this.tbCustomResistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(182, 139);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(222, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "by KubaMiszcz 2017 zielonyeufor@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 157);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tbR33);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbLEDdrop);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbCustomVoltage);
            this.Controls.Add(this.tbR12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbR60);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbR50);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCurrent);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LED Calculator - KubaMiszcz 2017";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCustomVoltage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbLEDdrop;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label tbR33;
        private System.Windows.Forms.Label tbR50;
        private System.Windows.Forms.Label tbR60;
        private System.Windows.Forms.Label tbR12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbCustomResistance;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

