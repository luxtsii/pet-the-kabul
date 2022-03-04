using System;

namespace PetTheKabul
{
    partial class PetTheKabul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetTheKabul));
            this.kabulBox = new System.Windows.Forms.PictureBox();
            this.kabulTray = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kabulBox)).BeginInit();
            this.SuspendLayout();
            // 
            // kabulBox
            // 
            this.kabulBox.Location = new System.Drawing.Point(0, 0);
            this.kabulBox.Margin = new System.Windows.Forms.Padding(0);
            this.kabulBox.Name = "kabulBox";
            this.kabulBox.Size = new System.Drawing.Size(96, 96);
            this.kabulBox.TabIndex = 0;
            this.kabulBox.TabStop = false;
            this.kabulBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kabulBox_MouseDown);
            this.kabulBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.kabulBox_MouseUp);
            // 
            // kabulTray
            // 
            this.kabulTray.BalloonTipText = "Pet him.";
            this.kabulTray.BalloonTipTitle = "Pet the Kabul.";
            this.kabulTray.Icon = ((System.Drawing.Icon)(resources.GetObject("kabulTray.Icon")));
            this.kabulTray.Text = "Kabul";
            this.kabulTray.Visible = true;
            // 
            // PetTheKabul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 165);
            this.Controls.Add(this.kabulBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PetTheKabul";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pet the Kabul";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kabulBox)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.PictureBox kabulBox;
        private System.Windows.Forms.NotifyIcon kabulTray;
    }
}

