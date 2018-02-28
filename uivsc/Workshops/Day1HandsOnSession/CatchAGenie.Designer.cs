namespace Workshops.Day1HandsOnSession
{
    partial class CatchAGenie
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
            this.Genie = new System.Windows.Forms.PictureBox();
            this.Lamp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Genie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lamp)).BeginInit();
            this.SuspendLayout();
            // 
            // Genie
            // 
            this.Genie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Genie.Image = global::Workshops.Day1HandsOnSession.Properties.Resources.Genie;
            this.Genie.Location = new System.Drawing.Point(347, 342);
            this.Genie.Name = "Genie";
            this.Genie.Size = new System.Drawing.Size(728, 825);
            this.Genie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Genie.TabIndex = 1;
            this.Genie.TabStop = false;
            this.Genie.Visible = false;
            this.Genie.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Genie_MouseMove);
            // 
            // Lamp
            // 
            this.Lamp.Image = global::Workshops.Day1HandsOnSession.Properties.Resources.Magic_Genie_Lamp_PNG;
            this.Lamp.Location = new System.Drawing.Point(449, 905);
            this.Lamp.Name = "Lamp";
            this.Lamp.Size = new System.Drawing.Size(600, 466);
            this.Lamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Lamp.TabIndex = 0;
            this.Lamp.TabStop = false;
            this.Lamp.Click += new System.EventHandler(this.Lamp_Click);
            this.Lamp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Lamp_MouseDoubleClick);
            // 
            // CatchAGenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 1412);
            this.Controls.Add(this.Genie);
            this.Controls.Add(this.Lamp);
            this.Name = "CatchAGenie";
            this.Text = "CatchAGenie";
            ((System.ComponentModel.ISupportInitialize)(this.Genie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lamp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Lamp;
        private System.Windows.Forms.PictureBox Genie;
    }
}