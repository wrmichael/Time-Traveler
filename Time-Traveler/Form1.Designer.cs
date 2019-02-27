namespace Time_Traveler
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UTCLabel = new System.Windows.Forms.Label();
            this.LocalLabel = new System.Windows.Forms.Label();
            this.TimeIOLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.VersionLabel = new System.Windows.Forms.Label();
            this.FlexDock = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GovCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UTCLabel
            // 
            this.UTCLabel.AutoSize = true;
            this.UTCLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UTCLabel.Location = new System.Drawing.Point(12, 9);
            this.UTCLabel.Name = "UTCLabel";
            this.UTCLabel.Size = new System.Drawing.Size(131, 23);
            this.UTCLabel.TabIndex = 1;
            this.UTCLabel.Text = "U: 00:00:00";
            // 
            // LocalLabel
            // 
            this.LocalLabel.AutoSize = true;
            this.LocalLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalLabel.Location = new System.Drawing.Point(12, 34);
            this.LocalLabel.Name = "LocalLabel";
            this.LocalLabel.Size = new System.Drawing.Size(131, 23);
            this.LocalLabel.TabIndex = 2;
            this.LocalLabel.Text = "L: 00:00:00";
            // 
            // TimeIOLabel
            // 
            this.TimeIOLabel.AutoSize = true;
            this.TimeIOLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeIOLabel.Location = new System.Drawing.Point(12, 59);
            this.TimeIOLabel.Name = "TimeIOLabel";
            this.TimeIOLabel.Size = new System.Drawing.Size(131, 23);
            this.TimeIOLabel.TabIndex = 3;
            this.TimeIOLabel.Text = "N: 00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update Local Time";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_click);
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Location = new System.Drawing.Point(11, 150);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(51, 17);
            this.AdminLabel.TabIndex = 6;
            this.AdminLabel.Text = "ADMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last time Set:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(69, 150);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Sync At Will";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(250, 36);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(41, 17);
            this.VersionLabel.TabIndex = 9;
            this.VersionLabel.Text = "V 1.5";
            // 
            // FlexDock
            // 
            this.FlexDock.AutoSize = true;
            this.FlexDock.Location = new System.Drawing.Point(179, 150);
            this.FlexDock.Name = "FlexDock";
            this.FlexDock.Size = new System.Drawing.Size(112, 21);
            this.FlexDock.TabIndex = 10;
            this.FlexDock.Text = "Dock with FH";
            this.FlexDock.UseVisualStyleBackColor = true;
            this.FlexDock.CheckedChanged += new System.EventHandler(this.FlexDock_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Time Traveler 2019 AC9HP";
            // 
            // GovCheck
            // 
            this.GovCheck.AutoSize = true;
            this.GovCheck.Location = new System.Drawing.Point(68, 174);
            this.GovCheck.Name = "GovCheck";
            this.GovCheck.Size = new System.Drawing.Size(117, 21);
            this.GovCheck.TabIndex = 13;
            this.GovCheck.Text = " time.nist.gov ";
            this.GovCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(300, 216);
            this.Controls.Add(this.GovCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FlexDock);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeIOLabel);
            this.Controls.Add(this.LocalLabel);
            this.Controls.Add(this.UTCLabel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.87D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label UTCLabel;
        private System.Windows.Forms.Label LocalLabel;
        private System.Windows.Forms.Label TimeIOLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.CheckBox FlexDock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox GovCheck;
    }
}

