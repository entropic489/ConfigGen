namespace ConfigGen
{
    partial class SNMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SNMP));
            this.ipDomainNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.communityStringTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.readOnlyRadio = new System.Windows.Forms.RadioButton();
            this.readWriteRadio = new System.Windows.Forms.RadioButton();
            this.versionOneRadio = new System.Windows.Forms.RadioButton();
            this.versionTwoRadio = new System.Windows.Forms.RadioButton();
            this.versionThreeRadio = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.versionPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.versionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipDomainNameTextBox
            // 
            this.ipDomainNameTextBox.Location = new System.Drawing.Point(13, 32);
            this.ipDomainNameTextBox.Name = "ipDomainNameTextBox";
            this.ipDomainNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ipDomainNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Domain-Name";
            // 
            // communityStringTextBox
            // 
            this.communityStringTextBox.Location = new System.Drawing.Point(13, 86);
            this.communityStringTextBox.Name = "communityStringTextBox";
            this.communityStringTextBox.Size = new System.Drawing.Size(100, 20);
            this.communityStringTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Community String";
            // 
            // readOnlyRadio
            // 
            this.readOnlyRadio.AutoSize = true;
            this.readOnlyRadio.Location = new System.Drawing.Point(5, 3);
            this.readOnlyRadio.Name = "readOnlyRadio";
            this.readOnlyRadio.Size = new System.Drawing.Size(75, 17);
            this.readOnlyRadio.TabIndex = 4;
            this.readOnlyRadio.TabStop = true;
            this.readOnlyRadio.Text = "Read-Only";
            this.readOnlyRadio.UseVisualStyleBackColor = true;
            // 
            // readWriteRadio
            // 
            this.readWriteRadio.AutoSize = true;
            this.readWriteRadio.Location = new System.Drawing.Point(5, 26);
            this.readWriteRadio.Name = "readWriteRadio";
            this.readWriteRadio.Size = new System.Drawing.Size(79, 17);
            this.readWriteRadio.TabIndex = 5;
            this.readWriteRadio.TabStop = true;
            this.readWriteRadio.Text = "Read-Write";
            this.readWriteRadio.UseVisualStyleBackColor = true;
            // 
            // versionOneRadio
            // 
            this.versionOneRadio.AutoSize = true;
            this.versionOneRadio.Location = new System.Drawing.Point(14, 16);
            this.versionOneRadio.Name = "versionOneRadio";
            this.versionOneRadio.Size = new System.Drawing.Size(68, 17);
            this.versionOneRadio.TabIndex = 6;
            this.versionOneRadio.TabStop = true;
            this.versionOneRadio.Text = "version 1";
            this.versionOneRadio.UseVisualStyleBackColor = true;
            // 
            // versionTwoRadio
            // 
            this.versionTwoRadio.AutoSize = true;
            this.versionTwoRadio.Location = new System.Drawing.Point(14, 36);
            this.versionTwoRadio.Name = "versionTwoRadio";
            this.versionTwoRadio.Size = new System.Drawing.Size(68, 17);
            this.versionTwoRadio.TabIndex = 7;
            this.versionTwoRadio.TabStop = true;
            this.versionTwoRadio.Text = "version 2";
            this.versionTwoRadio.UseVisualStyleBackColor = true;
            // 
            // versionThreeRadio
            // 
            this.versionThreeRadio.AutoSize = true;
            this.versionThreeRadio.Location = new System.Drawing.Point(14, 59);
            this.versionThreeRadio.Name = "versionThreeRadio";
            this.versionThreeRadio.Size = new System.Drawing.Size(68, 17);
            this.versionThreeRadio.TabIndex = 8;
            this.versionThreeRadio.TabStop = true;
            this.versionThreeRadio.Text = "version 3";
            this.versionThreeRadio.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(82, 235);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save and Close";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(82, 264);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(108, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.readOnlyRadio);
            this.panel1.Controls.Add(this.readWriteRadio);
            this.panel1.Location = new System.Drawing.Point(164, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 11;
            // 
            // versionPanel
            // 
            this.versionPanel.Controls.Add(this.versionOneRadio);
            this.versionPanel.Controls.Add(this.versionTwoRadio);
            this.versionPanel.Controls.Add(this.versionThreeRadio);
            this.versionPanel.Location = new System.Drawing.Point(16, 135);
            this.versionPanel.Name = "versionPanel";
            this.versionPanel.Size = new System.Drawing.Size(200, 100);
            this.versionPanel.TabIndex = 12;
            // 
            // SNMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(284, 307);
            this.Controls.Add(this.versionPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.communityStringTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipDomainNameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SNMP";
            this.Text = "SNMP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.versionPanel.ResumeLayout(false);
            this.versionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipDomainNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox communityStringTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton readOnlyRadio;
        private System.Windows.Forms.RadioButton readWriteRadio;
        private System.Windows.Forms.RadioButton versionOneRadio;
        private System.Windows.Forms.RadioButton versionTwoRadio;
        private System.Windows.Forms.RadioButton versionThreeRadio;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel versionPanel;
    }
}