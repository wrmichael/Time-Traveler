﻿namespace Time_Traveler
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
            this.UTCLabel.Location = new System.Drawing.Point(15, 47);
            this.UTCLabel.Name = "UTCLabel";
            this.UTCLabel.Size = new System.Drawing.Size(161, 38);
            this.UTCLabel.TabIndex = 1;
            this.UTCLabel.Text = "00:00:00";
            // 
            // LocalLabel
            // 
            this.LocalLabel.AutoSize = true;
            this.LocalLabel.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalLabel.Location = new System.Drawing.Point(15, 95);
            this.LocalLabel.Name = "LocalLabel";
            this.LocalLabel.Size = new System.Drawing.Size(161, 38);
            this.LocalLabel.TabIndex = 2;
            this.LocalLabel.Text = "00:00:00";
            // 
            // TimeIOLabel
            // 
            this.TimeIOLabel.AutoSize = true;
            this.TimeIOLabel.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeIOLabel.Location = new System.Drawing.Point(12, 151);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeIOLabel);
            this.Controls.Add(this.LocalLabel);
            this.Controls.Add(this.UTCLabel);
            this.Name = "Form1";
            this.Text = "Time Traveler 2019 AC9HP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.form_paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label UTCLabel;
        private System.Windows.Forms.Label LocalLabel;
        private System.Windows.Forms.Label TimeIOLabel;
        private System.Windows.Forms.Label label1;
    }
}
