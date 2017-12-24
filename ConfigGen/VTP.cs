using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigGen
{
    public partial class VTP : Form
    {
        public Data data;

        public VTP()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            vlanDataGridView.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            vlanDataGridView.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            vlanDataGridView.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            data.vtpMode = vtpModePanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            data.vtpDomainName = vtpDomainName.Text;

            if (data.vtpMode == "Server")
            {
                for (int i = 0; i <= vlanDataGridView.RowCount - 2; i++)
                {
                    data.vlanNum++;
                    data.Vlans.Add(new VLAN(Convert.ToInt32(vlanDataGridView[0,i].Value), Convert.ToString(vlanDataGridView[1,i].Value.ToString())));
                }
            }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
