namespace Workshops.Day2HandsOnSession
{
    partial class IceCreamParlour
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
            this.gboSize = new System.Windows.Forms.GroupBox();
            this.gboFlavour = new System.Windows.Forms.GroupBox();
            this.optStrawberry = new System.Windows.Forms.RadioButton();
            this.optChocolate = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optChocolateTopping = new System.Windows.Forms.CheckBox();
            this.optRaisins = new System.Windows.Forms.CheckBox();
            this.optNuts = new System.Windows.Forms.CheckBox();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.gboSize.SuspendLayout();
            this.gboFlavour.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboSize
            // 
            this.gboSize.Controls.Add(this.sizeComboBox);
            this.gboSize.Location = new System.Drawing.Point(56, 12);
            this.gboSize.Name = "gboSize";
            this.gboSize.Size = new System.Drawing.Size(483, 200);
            this.gboSize.TabIndex = 0;
            this.gboSize.TabStop = false;
            this.gboSize.Text = "Size";
            // 
            // gboFlavour
            // 
            this.gboFlavour.Controls.Add(this.optStrawberry);
            this.gboFlavour.Controls.Add(this.optChocolate);
            this.gboFlavour.Location = new System.Drawing.Point(56, 218);
            this.gboFlavour.Name = "gboFlavour";
            this.gboFlavour.Size = new System.Drawing.Size(483, 268);
            this.gboFlavour.TabIndex = 1;
            this.gboFlavour.TabStop = false;
            this.gboFlavour.Text = "Flavour";
            // 
            // optStrawberry
            // 
            this.optStrawberry.AutoSize = true;
            this.optStrawberry.Location = new System.Drawing.Point(154, 173);
            this.optStrawberry.Name = "optStrawberry";
            this.optStrawberry.Size = new System.Drawing.Size(188, 36);
            this.optStrawberry.TabIndex = 1;
            this.optStrawberry.Text = "Strawberry";
            this.optStrawberry.UseVisualStyleBackColor = true;
            // 
            // optChocolate
            // 
            this.optChocolate.AutoSize = true;
            this.optChocolate.Checked = true;
            this.optChocolate.Location = new System.Drawing.Point(154, 93);
            this.optChocolate.Name = "optChocolate";
            this.optChocolate.Size = new System.Drawing.Size(181, 36);
            this.optChocolate.TabIndex = 0;
            this.optChocolate.TabStop = true;
            this.optChocolate.Text = "Chocolate";
            this.optChocolate.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 850);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optChocolateTopping);
            this.groupBox1.Controls.Add(this.optRaisins);
            this.groupBox1.Controls.Add(this.optNuts);
            this.groupBox1.Location = new System.Drawing.Point(56, 492);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 334);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toppings";
            // 
            // optChocolateTopping
            // 
            this.optChocolateTopping.AutoSize = true;
            this.optChocolateTopping.Location = new System.Drawing.Point(154, 237);
            this.optChocolateTopping.Name = "optChocolateTopping";
            this.optChocolateTopping.Size = new System.Drawing.Size(182, 36);
            this.optChocolateTopping.TabIndex = 2;
            this.optChocolateTopping.Text = "Chocolate";
            this.optChocolateTopping.UseVisualStyleBackColor = true;
            // 
            // optRaisins
            // 
            this.optRaisins.AutoSize = true;
            this.optRaisins.Location = new System.Drawing.Point(154, 163);
            this.optRaisins.Name = "optRaisins";
            this.optRaisins.Size = new System.Drawing.Size(147, 36);
            this.optRaisins.TabIndex = 1;
            this.optRaisins.Text = "Raisins";
            this.optRaisins.UseVisualStyleBackColor = true;
            // 
            // optNuts
            // 
            this.optNuts.AutoSize = true;
            this.optNuts.Location = new System.Drawing.Point(154, 93);
            this.optNuts.Name = "optNuts";
            this.optNuts.Size = new System.Drawing.Size(111, 36);
            this.optNuts.TabIndex = 0;
            this.optNuts.Text = "Nuts";
            this.optNuts.UseVisualStyleBackColor = true;
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Big"});
            this.sizeComboBox.Location = new System.Drawing.Point(150, 82);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(192, 39);
            this.sizeComboBox.TabIndex = 0;
            // 
            // IceCreamParlour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 929);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gboFlavour);
            this.Controls.Add(this.gboSize);
            this.Name = "IceCreamParlour";
            this.Text = "Example2_5";
            this.gboSize.ResumeLayout(false);
            this.gboFlavour.ResumeLayout(false);
            this.gboFlavour.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboSize;
        private System.Windows.Forms.GroupBox gboFlavour;
        private System.Windows.Forms.RadioButton optStrawberry;
        private System.Windows.Forms.RadioButton optChocolate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox optChocolateTopping;
        private System.Windows.Forms.CheckBox optRaisins;
        private System.Windows.Forms.CheckBox optNuts;
        private System.Windows.Forms.ComboBox sizeComboBox;
    }
}