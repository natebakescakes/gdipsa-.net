﻿namespace Day3HandsOnSession
{
    partial class Example3_1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalSizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enlargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Image = global::Workshops.Day3HandsOnSession.Properties.Resources.White_Rabbit;
            this.pictureBox1.Location = new System.Drawing.Point(306, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallerToolStripMenuItem,
            this.normalSizedToolStripMenuItem,
            this.enlargeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(291, 197);
            // 
            // smallerToolStripMenuItem
            // 
            this.smallerToolStripMenuItem.Name = "smallerToolStripMenuItem";
            this.smallerToolStripMenuItem.Size = new System.Drawing.Size(290, 46);
            this.smallerToolStripMenuItem.Text = "Smaller";
            this.smallerToolStripMenuItem.Click += new System.EventHandler(this.smallerToolStripMenuItem_Click);
            // 
            // normalSizedToolStripMenuItem
            // 
            this.normalSizedToolStripMenuItem.Name = "normalSizedToolStripMenuItem";
            this.normalSizedToolStripMenuItem.Size = new System.Drawing.Size(290, 46);
            this.normalSizedToolStripMenuItem.Text = "Normal Sized";
            this.normalSizedToolStripMenuItem.Click += new System.EventHandler(this.normalSizedToolStripMenuItem_Click);
            // 
            // enlargeToolStripMenuItem
            // 
            this.enlargeToolStripMenuItem.Name = "enlargeToolStripMenuItem";
            this.enlargeToolStripMenuItem.Size = new System.Drawing.Size(290, 46);
            this.enlargeToolStripMenuItem.Text = "Enlarge";
            this.enlargeToolStripMenuItem.Click += new System.EventHandler(this.enlargeToolStripMenuItem_Click);
            // 
            // Example3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 786);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Example3_1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smallerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalSizedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enlargeToolStripMenuItem;
    }
}

