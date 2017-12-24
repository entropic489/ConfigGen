namespace ConfigGen
{
    partial class ViewVlans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewVlans));
            this.intDataGridView = new System.Windows.Forms.DataGridView();
            this.isRange = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.intType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstInt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastInt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.switchType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accVlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voiceVlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subnetMask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.intDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // intDataGridView
            // 
            this.intDataGridView.AllowUserToAddRows = false;
            this.intDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.intDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isRange,
            this.intType,
            this.firstInt,
            this.lastInt,
            this.switchType,
            this.accVlan,
            this.voiceVlan,
            this.ipAdd,
            this.subnetMask});
            this.intDataGridView.Location = new System.Drawing.Point(12, 12);
            this.intDataGridView.Name = "intDataGridView";
            this.intDataGridView.Size = new System.Drawing.Size(944, 231);
            this.intDataGridView.TabIndex = 0;
            // 
            // isRange
            // 
            this.isRange.HeaderText = "Is Range?";
            this.isRange.Name = "isRange";
            this.isRange.ReadOnly = true;
            this.isRange.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // intType
            // 
            this.intType.HeaderText = "InterfaceType";
            this.intType.Name = "intType";
            this.intType.ReadOnly = true;
            // 
            // firstInt
            // 
            this.firstInt.HeaderText = "First Interface";
            this.firstInt.Name = "firstInt";
            this.firstInt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lastInt
            // 
            this.lastInt.HeaderText = "Last Interface";
            this.lastInt.Name = "lastInt";
            this.lastInt.ReadOnly = true;
            // 
            // switchType
            // 
            this.switchType.HeaderText = "Switchport Type";
            this.switchType.Name = "switchType";
            this.switchType.ReadOnly = true;
            // 
            // accVlan
            // 
            this.accVlan.HeaderText = "Access Vlan";
            this.accVlan.Name = "accVlan";
            this.accVlan.ReadOnly = true;
            // 
            // voiceVlan
            // 
            this.voiceVlan.HeaderText = "Voice Vlan";
            this.voiceVlan.Name = "voiceVlan";
            this.voiceVlan.ReadOnly = true;
            // 
            // ipAdd
            // 
            this.ipAdd.HeaderText = "IP Address";
            this.ipAdd.Name = "ipAdd";
            this.ipAdd.ReadOnly = true;
            // 
            // subnetMask
            // 
            this.subnetMask.HeaderText = "SubnetMask";
            this.subnetMask.Name = "subnetMask";
            this.subnetMask.ReadOnly = true;
            // 
            // ViewVlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(966, 259);
            this.Controls.Add(this.intDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewVlans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "All Interfaces";
            ((System.ComponentModel.ISupportInitialize)(this.intDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView intDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn intType;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstInt;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastInt;
        private System.Windows.Forms.DataGridViewTextBoxColumn switchType;
        private System.Windows.Forms.DataGridViewTextBoxColumn accVlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn voiceVlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn subnetMask;
    }
}