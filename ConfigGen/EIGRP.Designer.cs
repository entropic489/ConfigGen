namespace ConfigGen
{
    partial class EIGRP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EIGRP));
            this.asnTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.netDataGridView = new System.Windows.Forms.DataGridView();
            this.net = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wildcardMask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.netDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // asnTextBox
            // 
            this.asnTextBox.Location = new System.Drawing.Point(13, 30);
            this.asnTextBox.Name = "asnTextBox";
            this.asnTextBox.Size = new System.Drawing.Size(100, 20);
            this.asnTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ASN (NUMBERS ONLY!!!)";
            // 
            // netDataGridView
            // 
            this.netDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.netDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.net,
            this.wildcardMask});
            this.netDataGridView.Location = new System.Drawing.Point(12, 79);
            this.netDataGridView.Name = "netDataGridView";
            this.netDataGridView.Size = new System.Drawing.Size(244, 124);
            this.netDataGridView.TabIndex = 2;
            // 
            // net
            // 
            this.net.HeaderText = "Net";
            this.net.Name = "net";
            // 
            // wildcardMask
            // 
            this.wildcardMask.HeaderText = "Wildcard Mask";
            this.wildcardMask.Name = "wildcardMask";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ALL NUMBERS ENTERED IN QUAD FORMAT";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(79, 209);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save and Close";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(79, 239);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(118, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EIGRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(272, 275);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.netDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asnTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EIGRP";
            this.Text = "EIGRP";
            this.Load += new System.EventHandler(this.EIGRP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.netDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox asnTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView netDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn net;
        private System.Windows.Forms.DataGridViewTextBoxColumn wildcardMask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}