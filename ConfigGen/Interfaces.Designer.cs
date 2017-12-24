namespace ConfigGen
{
    partial class Interfaces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaces));
            this.intTypeComboBox = new System.Windows.Forms.ComboBox();
            this.firstInterface = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastInterface = new System.Windows.Forms.TextBox();
            this.switchportComboBox = new System.Windows.Forms.ComboBox();
            this.voiceVlan = new System.Windows.Forms.TextBox();
            this.voiceVlanLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.viewVlansButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.intIPAddressTextBox = new System.Windows.Forms.TextBox();
            this.intIPAddressLabel = new System.Windows.Forms.Label();
            this.intSubnetMask = new System.Windows.Forms.TextBox();
            this.intSubnetMaskLabel = new System.Windows.Forms.Label();
            this.accessVlanTextBox = new System.Windows.Forms.TextBox();
            this.accessVlanLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // intTypeComboBox
            // 
            this.intTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.intTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intTypeComboBox.FormattingEnabled = true;
            this.intTypeComboBox.Items.AddRange(new object[] {
            "FastEthernet",
            "GigabitEthernet",
            "Serial",
            "Vlan"});
            this.intTypeComboBox.Location = new System.Drawing.Point(14, 86);
            this.intTypeComboBox.Name = "intTypeComboBox";
            this.intTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.intTypeComboBox.TabIndex = 0;
            this.intTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.intTypeComboBox_SelectedIndexChanged);
            // 
            // firstInterface
            // 
            this.firstInterface.Location = new System.Drawing.Point(141, 86);
            this.firstInterface.Name = "firstInterface";
            this.firstInterface.Size = new System.Drawing.Size(127, 20);
            this.firstInterface.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Interface (or Vlan ID)";
            // 
            // lastInterface
            // 
            this.lastInterface.Location = new System.Drawing.Point(274, 86);
            this.lastInterface.Name = "lastInterface";
            this.lastInterface.Size = new System.Drawing.Size(139, 20);
            this.lastInterface.TabIndex = 3;
            // 
            // switchportComboBox
            // 
            this.switchportComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.switchportComboBox.FormattingEnabled = true;
            this.switchportComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.switchportComboBox.Items.AddRange(new object[] {
            "access",
            "trunk",
            "IP Address"});
            this.switchportComboBox.Location = new System.Drawing.Point(14, 128);
            this.switchportComboBox.Name = "switchportComboBox";
            this.switchportComboBox.Size = new System.Drawing.Size(121, 21);
            this.switchportComboBox.TabIndex = 4;
            this.switchportComboBox.SelectedIndexChanged += new System.EventHandler(this.switchportComboBox_SelectedIndexChanged);
            // 
            // voiceVlan
            // 
            this.voiceVlan.Location = new System.Drawing.Point(141, 129);
            this.voiceVlan.Name = "voiceVlan";
            this.voiceVlan.Size = new System.Drawing.Size(127, 20);
            this.voiceVlan.TabIndex = 5;
            this.voiceVlan.Visible = false;
            // 
            // voiceVlanLabel
            // 
            this.voiceVlanLabel.AutoSize = true;
            this.voiceVlanLabel.Location = new System.Drawing.Point(142, 110);
            this.voiceVlanLabel.Name = "voiceVlanLabel";
            this.voiceVlanLabel.Size = new System.Drawing.Size(106, 13);
            this.voiceVlanLabel.TabIndex = 6;
            this.voiceVlanLabel.Text = "Voice Vlan (Optional)";
            this.voiceVlanLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Interface (leave blank if not needed)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "WRITE ALL INTERFACES IN REQUIRED FORMAT (e.g. 0/0/0, 0/0, etc)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "All configs final. In other words, DON\'T FUCK UP.";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(179, 165);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // viewVlansButton
            // 
            this.viewVlansButton.Location = new System.Drawing.Point(179, 194);
            this.viewVlansButton.Name = "viewVlansButton";
            this.viewVlansButton.Size = new System.Drawing.Size(103, 23);
            this.viewVlansButton.TabIndex = 11;
            this.viewVlansButton.Text = "Refresh Interfaces";
            this.viewVlansButton.UseVisualStyleBackColor = true;
            this.viewVlansButton.Click += new System.EventHandler(this.viewVlansButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(179, 223);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(103, 23);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // intIPAddressTextBox
            // 
            this.intIPAddressTextBox.Location = new System.Drawing.Point(141, 129);
            this.intIPAddressTextBox.Name = "intIPAddressTextBox";
            this.intIPAddressTextBox.Size = new System.Drawing.Size(127, 20);
            this.intIPAddressTextBox.TabIndex = 13;
            this.intIPAddressTextBox.Visible = false;
            // 
            // intIPAddressLabel
            // 
            this.intIPAddressLabel.AutoSize = true;
            this.intIPAddressLabel.Location = new System.Drawing.Point(141, 110);
            this.intIPAddressLabel.Name = "intIPAddressLabel";
            this.intIPAddressLabel.Size = new System.Drawing.Size(73, 13);
            this.intIPAddressLabel.TabIndex = 14;
            this.intIPAddressLabel.Text = "Int IP Address";
            this.intIPAddressLabel.Visible = false;
            // 
            // intSubnetMask
            // 
            this.intSubnetMask.Location = new System.Drawing.Point(277, 128);
            this.intSubnetMask.Name = "intSubnetMask";
            this.intSubnetMask.Size = new System.Drawing.Size(136, 20);
            this.intSubnetMask.TabIndex = 15;
            this.intSubnetMask.Visible = false;
            // 
            // intSubnetMaskLabel
            // 
            this.intSubnetMaskLabel.AutoSize = true;
            this.intSubnetMaskLabel.Location = new System.Drawing.Point(277, 113);
            this.intSubnetMaskLabel.Name = "intSubnetMaskLabel";
            this.intSubnetMaskLabel.Size = new System.Drawing.Size(85, 13);
            this.intSubnetMaskLabel.TabIndex = 16;
            this.intSubnetMaskLabel.Text = "Int Subnet Mask";
            this.intSubnetMaskLabel.Visible = false;
            // 
            // accessVlanTextBox
            // 
            this.accessVlanTextBox.Location = new System.Drawing.Point(277, 128);
            this.accessVlanTextBox.Name = "accessVlanTextBox";
            this.accessVlanTextBox.Size = new System.Drawing.Size(136, 20);
            this.accessVlanTextBox.TabIndex = 17;
            this.accessVlanTextBox.Visible = false;
            // 
            // accessVlanLabel
            // 
            this.accessVlanLabel.AutoSize = true;
            this.accessVlanLabel.Location = new System.Drawing.Point(277, 113);
            this.accessVlanLabel.Name = "accessVlanLabel";
            this.accessVlanLabel.Size = new System.Drawing.Size(66, 13);
            this.accessVlanLabel.TabIndex = 18;
            this.accessVlanLabel.Text = "Access Vlan";
            this.accessVlanLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Interface Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Switchport Type";
            // 
            // Interfaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(491, 262);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accessVlanLabel);
            this.Controls.Add(this.accessVlanTextBox);
            this.Controls.Add(this.intSubnetMaskLabel);
            this.Controls.Add(this.intSubnetMask);
            this.Controls.Add(this.intIPAddressLabel);
            this.Controls.Add(this.intIPAddressTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.viewVlansButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.voiceVlanLabel);
            this.Controls.Add(this.voiceVlan);
            this.Controls.Add(this.switchportComboBox);
            this.Controls.Add(this.lastInterface);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstInterface);
            this.Controls.Add(this.intTypeComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interfaces";
            this.Text = "Interfaces";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox intTypeComboBox;
        private System.Windows.Forms.TextBox firstInterface;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastInterface;
        private System.Windows.Forms.ComboBox switchportComboBox;
        private System.Windows.Forms.TextBox voiceVlan;
        private System.Windows.Forms.Label voiceVlanLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button viewVlansButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox intIPAddressTextBox;
        private System.Windows.Forms.Label intIPAddressLabel;
        private System.Windows.Forms.TextBox intSubnetMask;
        private System.Windows.Forms.Label intSubnetMaskLabel;
        private System.Windows.Forms.TextBox accessVlanTextBox;
        private System.Windows.Forms.Label accessVlanLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}