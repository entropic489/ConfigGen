namespace ConfigGen
{
    partial class StaticRoutes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaticRoutes));
            this.label1 = new System.Windows.Forms.Label();
            this.destinationIPTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.destinationSubnetMask = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.interfaceRadioButton = new System.Windows.Forms.RadioButton();
            this.ipRadioButton = new System.Windows.Forms.RadioButton();
            this.sourceIPTextBox = new System.Windows.Forms.TextBox();
            this.sourceIPLabel = new System.Windows.Forms.Label();
            this.sourceSubnetMask = new System.Windows.Forms.TextBox();
            this.sourceSubnetLabel = new System.Windows.Forms.Label();
            this.sourceIntTextBox = new System.Windows.Forms.TextBox();
            this.sourceIntLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.intOrIpPanel = new System.Windows.Forms.Panel();
            this.intOrIpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USE DOT NOTATION FOR ALL IP\'s";
            // 
            // destinationIPTextBox
            // 
            this.destinationIPTextBox.Location = new System.Drawing.Point(16, 68);
            this.destinationIPTextBox.Name = "destinationIPTextBox";
            this.destinationIPTextBox.Size = new System.Drawing.Size(119, 20);
            this.destinationIPTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination IP";
            // 
            // destinationSubnetMask
            // 
            this.destinationSubnetMask.Location = new System.Drawing.Point(141, 67);
            this.destinationSubnetMask.Name = "destinationSubnetMask";
            this.destinationSubnetMask.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.destinationSubnetMask.Size = new System.Drawing.Size(126, 20);
            this.destinationSubnetMask.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destination Subnet Mask";
            // 
            // interfaceRadioButton
            // 
            this.interfaceRadioButton.AutoSize = true;
            this.interfaceRadioButton.Location = new System.Drawing.Point(8, 3);
            this.interfaceRadioButton.Name = "interfaceRadioButton";
            this.interfaceRadioButton.Size = new System.Drawing.Size(67, 17);
            this.interfaceRadioButton.TabIndex = 5;
            this.interfaceRadioButton.TabStop = true;
            this.interfaceRadioButton.Text = "Interface";
            this.interfaceRadioButton.UseVisualStyleBackColor = true;
            this.interfaceRadioButton.CheckedChanged += new System.EventHandler(this.interfaceRadioButton_CheckedChanged);
            // 
            // ipRadioButton
            // 
            this.ipRadioButton.AutoSize = true;
            this.ipRadioButton.Location = new System.Drawing.Point(8, 26);
            this.ipRadioButton.Name = "ipRadioButton";
            this.ipRadioButton.Size = new System.Drawing.Size(76, 17);
            this.ipRadioButton.TabIndex = 6;
            this.ipRadioButton.TabStop = true;
            this.ipRadioButton.Text = "IP Address";
            this.ipRadioButton.UseVisualStyleBackColor = true;
            this.ipRadioButton.CheckedChanged += new System.EventHandler(this.ipRadioButton_CheckedChanged);
            // 
            // sourceIPTextBox
            // 
            this.sourceIPTextBox.Location = new System.Drawing.Point(16, 180);
            this.sourceIPTextBox.Name = "sourceIPTextBox";
            this.sourceIPTextBox.Size = new System.Drawing.Size(119, 20);
            this.sourceIPTextBox.TabIndex = 7;
            this.sourceIPTextBox.Visible = false;
            // 
            // sourceIPLabel
            // 
            this.sourceIPLabel.AutoSize = true;
            this.sourceIPLabel.Location = new System.Drawing.Point(16, 161);
            this.sourceIPLabel.Name = "sourceIPLabel";
            this.sourceIPLabel.Size = new System.Drawing.Size(95, 13);
            this.sourceIPLabel.TabIndex = 8;
            this.sourceIPLabel.Text = "Source IP Address";
            this.sourceIPLabel.Visible = false;
            // 
            // sourceSubnetMask
            // 
            this.sourceSubnetMask.Location = new System.Drawing.Point(141, 179);
            this.sourceSubnetMask.Name = "sourceSubnetMask";
            this.sourceSubnetMask.Size = new System.Drawing.Size(126, 20);
            this.sourceSubnetMask.TabIndex = 9;
            this.sourceSubnetMask.Visible = false;
            // 
            // sourceSubnetLabel
            // 
            this.sourceSubnetLabel.AutoSize = true;
            this.sourceSubnetLabel.Location = new System.Drawing.Point(141, 160);
            this.sourceSubnetLabel.Name = "sourceSubnetLabel";
            this.sourceSubnetLabel.Size = new System.Drawing.Size(107, 13);
            this.sourceSubnetLabel.TabIndex = 10;
            this.sourceSubnetLabel.Text = "Source Subnet Mask";
            this.sourceSubnetLabel.Visible = false;
            // 
            // sourceIntTextBox
            // 
            this.sourceIntTextBox.Location = new System.Drawing.Point(16, 179);
            this.sourceIntTextBox.Name = "sourceIntTextBox";
            this.sourceIntTextBox.Size = new System.Drawing.Size(119, 20);
            this.sourceIntTextBox.TabIndex = 11;
            this.sourceIntTextBox.Visible = false;
            // 
            // sourceIntLabel
            // 
            this.sourceIntLabel.AutoSize = true;
            this.sourceIntLabel.Location = new System.Drawing.Point(13, 163);
            this.sourceIntLabel.Name = "sourceIntLabel";
            this.sourceIntLabel.Size = new System.Drawing.Size(186, 13);
            this.sourceIntLabel.TabIndex = 12;
            this.sourceIntLabel.Text = "Source Interface (use proper notation)";
            this.sourceIntLabel.Visible = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(101, 215);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(101, 244);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // intOrIpPanel
            // 
            this.intOrIpPanel.Controls.Add(this.interfaceRadioButton);
            this.intOrIpPanel.Controls.Add(this.ipRadioButton);
            this.intOrIpPanel.Location = new System.Drawing.Point(16, 94);
            this.intOrIpPanel.Name = "intOrIpPanel";
            this.intOrIpPanel.Size = new System.Drawing.Size(200, 49);
            this.intOrIpPanel.TabIndex = 16;
            // 
            // StaticRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.intOrIpPanel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.sourceIntLabel);
            this.Controls.Add(this.sourceIntTextBox);
            this.Controls.Add(this.sourceSubnetLabel);
            this.Controls.Add(this.sourceSubnetMask);
            this.Controls.Add(this.sourceIPLabel);
            this.Controls.Add(this.sourceIPTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.destinationSubnetMask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.destinationIPTextBox);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaticRoutes";
            this.Text = "Static Routes";
            this.intOrIpPanel.ResumeLayout(false);
            this.intOrIpPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox destinationIPTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox destinationSubnetMask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton interfaceRadioButton;
        private System.Windows.Forms.RadioButton ipRadioButton;
        private System.Windows.Forms.TextBox sourceIPTextBox;
        private System.Windows.Forms.Label sourceIPLabel;
        private System.Windows.Forms.TextBox sourceSubnetMask;
        private System.Windows.Forms.Label sourceSubnetLabel;
        private System.Windows.Forms.TextBox sourceIntTextBox;
        private System.Windows.Forms.Label sourceIntLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel intOrIpPanel;
    }
}