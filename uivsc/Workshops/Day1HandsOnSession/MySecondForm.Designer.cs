namespace Workshops.Day1HandsOnSession
{
    partial class MySecondForm
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
            this.SuspendLayout();
            // 
            // MySecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 212);
            this.Name = "MySecondForm";
            this.Text = "MySecondForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MySecondForm_FormClosed);
            this.Load += new System.EventHandler(this.MySecondForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}