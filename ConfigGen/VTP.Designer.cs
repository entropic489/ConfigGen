namespace ConfigGen
{
    partial class VTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VTP));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.vtpDomainName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vlanDataGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.vtpModePanel = new System.Windows.Forms.Panel();
            this.vlanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlanDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vlanDataGridView)).BeginInit();
            this.vtpModePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Server";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Client";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(82, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Transparent";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "VTP Mode";
            // 
            // vtpDomainName
            // 
            this.vtpDomainName.Location = new System.Drawing.Point(177, 35);
            this.vtpDomainName.Name = "vtpDomainName";
            this.vtpDomainName.Size = new System.Drawing.Size(100, 20);
            this.vtpDomainName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "VTP Domain Name";
            // 
            // vlanDataGridView
            // 
            this.vlanDataGridView.AllowDrop = true;
            this.vlanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vlanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vlanID,
            this.vlanDescription});
            this.vlanDataGridView.Location = new System.Drawing.Point(15, 106);
            this.vlanDataGridView.Name = "vlanDataGridView";
            this.vlanDataGridView.Size = new System.Drawing.Size(243, 128);
            this.vlanDataGridView.TabIndex = 6;
            this.vlanDataGridView.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(132, 240);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save and Close";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(132, 269);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(104, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // vtpModePanel
            // 
            this.vtpModePanel.Controls.Add(this.radioButton1);
            this.vtpModePanel.Controls.Add(this.radioButton2);
            this.vtpModePanel.Controls.Add(this.radioButton3);
            this.vtpModePanel.Location = new System.Drawing.Point(15, 35);
            this.vtpModePanel.Name = "vtpModePanel";
            this.vtpModePanel.Size = new System.Drawing.Size(156, 65);
            this.vtpModePanel.TabIndex = 9;
            // 
            // vlanID
            // 
            this.vlanID.HeaderText = "VLAN ID";
            this.vlanID.Name = "vlanID";
            // 
            // vlanDescription
            // 
            this.vlanDescription.HeaderText = "Description";
            this.vlanDescription.Name = "vlanDescription";
            // 
            // VTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(370, 303);
            this.Controls.Add(this.vtpModePanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.vlanDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vtpDomainName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VTP";
            this.Text = "VTP Config";
            ((System.ComponentModel.ISupportInitialize)(this.vlanDataGridView)).EndInit();
            this.vtpModePanel.ResumeLayout(false);
            this.vtpModePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vtpDomainName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView vlanDataGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel vtpModePanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlanDescription;
    }
}