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
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.gboFlavour = new System.Windows.Forms.GroupBox();
            this.optStrawberry = new System.Windows.Forms.RadioButton();
            this.optChocolate = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toppingsListBox = new System.Windows.Forms.ListBox();
            this.gboSize.SuspendLayout();
            this.gboFlavour.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboSize
            // 
            this.gboSize.Controls.Add(this.sizeComboBox);
            this.gboSize.Location = new System.Drawing.Point(21, 5);
            this.gboSize.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gboSize.Name = "gboSize";
            this.gboSize.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gboSize.Size = new System.Drawing.Size(181, 84);
            this.gboSize.TabIndex = 0;
            this.gboSize.TabStop = false;
            this.gboSize.Text = "Size";
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Big"});
            this.sizeComboBox.Location = new System.Drawing.Point(56, 34);
            this.sizeComboBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(74, 21);
            this.sizeComboBox.TabIndex = 0;
            // 
            // gboFlavour
            // 
            this.gboFlavour.Controls.Add(this.optStrawberry);
            this.gboFlavour.Controls.Add(this.optChocolate);
            this.gboFlavour.Location = new System.Drawing.Point(21, 91);
            this.gboFlavour.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gboFlavour.Name = "gboFlavour";
            this.gboFlavour.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gboFlavour.Size = new System.Drawing.Size(181, 112);
            this.gboFlavour.TabIndex = 1;
            this.gboFlavour.TabStop = false;
            this.gboFlavour.Text = "Flavour";
            // 
            // optStrawberry
            // 
            this.optStrawberry.AutoSize = true;
            this.optStrawberry.Location = new System.Drawing.Point(58, 73);
            this.optStrawberry.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.optStrawberry.Name = "optStrawberry";
            this.optStrawberry.Size = new System.Drawing.Size(75, 17);
            this.optStrawberry.TabIndex = 1;
            this.optStrawberry.Text = "Strawberry";
            this.optStrawberry.UseVisualStyleBackColor = true;
            // 
            // optChocolate
            // 
            this.optChocolate.AutoSize = true;
            this.optChocolate.Checked = true;
            this.optChocolate.Location = new System.Drawing.Point(58, 39);
            this.optChocolate.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.optChocolate.Name = "optChocolate";
            this.optChocolate.Size = new System.Drawing.Size(73, 17);
            this.optChocolate.TabIndex = 0;
            this.optChocolate.TabStop = true;
            this.optChocolate.Text = "Chocolate";
            this.optChocolate.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 316);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toppingsListBox);
            this.groupBox1.Location = new System.Drawing.Point(21, 206);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Size = new System.Drawing.Size(181, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toppings";
            // 
            // toppingsListBox
            // 
            this.toppingsListBox.FormattingEnabled = true;
            this.toppingsListBox.Items.AddRange(new object[] {
            "Nuts",
            "Rasins",
            "Chocolate"});
            this.toppingsListBox.Location = new System.Drawing.Point(33, 30);
            this.toppingsListBox.Name = "toppingsListBox";
            this.toppingsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.toppingsListBox.Size = new System.Drawing.Size(120, 43);
            this.toppingsListBox.TabIndex = 0;
            // 
            // IceCreamParlour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gboFlavour);
            this.Controls.Add(this.gboSize);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "IceCreamParlour";
            this.Text = "Example2_5";
            this.gboSize.ResumeLayout(false);
            this.gboFlavour.ResumeLayout(false);
            this.gboFlavour.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboSize;
        private System.Windows.Forms.GroupBox gboFlavour;
        private System.Windows.Forms.RadioButton optStrawberry;
        private System.Windows.Forms.RadioButton optChocolate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.ListBox toppingsListBox;
    }
}