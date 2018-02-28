namespace Workshops.Day1HandsOnSession
{
    partial class CatchAFish
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timeSpanLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::Workshops.Day1HandsOnSession.Properties.Resources.Blue_Fish_PNG_Image;
            this.button1.Location = new System.Drawing.Point(350, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(760, 760);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Taken: ";
            // 
            // timeSpanLabel
            // 
            this.timeSpanLabel.AutoSize = true;
            this.timeSpanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSpanLabel.Location = new System.Drawing.Point(315, 9);
            this.timeSpanLabel.Name = "timeSpanLabel";
            this.timeSpanLabel.Size = new System.Drawing.Size(0, 58);
            this.timeSpanLabel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "High Score: ";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLabel.Location = new System.Drawing.Point(315, 79);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(0, 58);
            this.highScoreLabel.TabIndex = 4;
            // 
            // CatchAFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3808, 2072);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeSpanLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "CatchAFish";
            this.Text = "CatchAFish";
            this.Load += new System.EventHandler(this.CatchAFish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeSpanLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label highScoreLabel;
    }
}