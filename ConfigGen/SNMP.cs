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
    public partial class SNMP : Form
    {
        public Data data;
        public bool active;

        public SNMP()
        {
            active = true;
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            data.ipDomainName = ipDomainNameTextBox.Text;
            data.snmpCommunityString = communityStringTextBox.Text;

            if (readOnlyRadio.Checked == true)
            {
                data.snmpCommunityReadOnly = true;
            }
            else if(readWriteRadio.Checked == true)
            {
                data.snmpCommunityReadOnly = false;
            }

            data.snmpVersion = versionPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
