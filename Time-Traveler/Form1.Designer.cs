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
            this.UTCLabel.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UTCLabel.Location = new System.Drawing.Point(12, 9);
            this.UTCLabel.Name = "UTCLabel";
            this.UTCLabel.Size = new System.Drawing.Size(161, 38);
            this.UTCLabel.TabIndex = 1;
            this.UTCLabel.Text = "00:00:00";
            // 
            // LocalLabel
            // 
            this.LocalLabel.AutoSize = true;
            this.LocalLabel.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalLabel.Location = new System.Drawing.Point(12, 74);
            this.LocalLabel.Name = "LocalLabel";
            this.LocalLabel.Size = new System.Drawing.Size(161, 38);
            this.LocalLabel.TabIndex = 2;
            this.LocalLabel.Text = "00:00:00";
            // 
            // TimeIOLabel
            // 
            this.TimeIOLabel.AutoSize = true;
            this.TimeIOLabel.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeIOLabel.Location = new System.Drawing.Point(12, 139);
            this.TimeIOLabel.Name = "TimeIOLabel";
            this.TimeIOLabel.Size = new System.Drawing.Size(161, 38);
            this.TimeIOLabel.TabIndex = 3;
            this.TimeIOLabel.Text = "00:00:00";
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
            this.button1.Location = new System.Drawing.Point(12, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update Local Time";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_click);
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Location = new System.Drawing.Point(11, 252);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(51, 17);
            this.AdminLabel.TabIndex = 6;
            this.AdminLabel.Text = "ADMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last time Set:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(69, 252);
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
            this.VersionLabel.Location = new System.Drawing.Point(261, 244);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(41, 17);
            this.VersionLabel.TabIndex = 9;
            this.VersionLabel.Text = "V 1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 282);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeIOLabel);
            this.Controls.Add(this.LocalLabel);
            this.Controls.Add(this.UTCLabel);
            this.Name = "Form1";
            this.Text = "Time Traveler 2019 AC9HP";
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
    }
}

