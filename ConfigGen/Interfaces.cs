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
    public partial class Interfaces : Form
    {
        public Data data;
        public ViewVlans interfaceView;

        public Interfaces()
        {
            InitializeComponent();
        }

        private void intTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (intTypeComboBox.SelectedIndex == 3)
            {
                switchportComboBox.SelectedIndex = 2;
            }
        }

        private void switchportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (switchportComboBox.SelectedIndex == 0)
            {
                voiceVlan.Visible = true;
                voiceVlanLabel.Visible = true;
                intIPAddressLabel.Visible = false;
                intIPAddressTextBox.Visible = false;
                intSubnetMask.Visible = false;
                intSubnetMaskLabel.Visible = false;
                accessVlanLabel.Visible = true;
                accessVlanTextBox.Visible = true;
            }
            if (switchportComboBox.SelectedIndex == 1)
            {
                voiceVlan.Visible = false;
                voiceVlanLabel.Visible = false;
                intIPAddressLabel.Visible = false;
                intIPAddressTextBox.Visible = false;
                intSubnetMask.Visible = false;
                intSubnetMaskLabel.Visible = false;
                accessVlanLabel.Visible = false;
                accessVlanTextBox.Visible = false;
            }
            if (switchportComboBox.SelectedIndex == 2)
            {
                voiceVlan.Visible = false;
                voiceVlanLabel.Visible = false;
                intIPAddressLabel.Visible = true;
                intIPAddressTextBox.Visible = true;
                intSubnetMask.Visible = true;
                intSubnetMaskLabel.Visible = true;
                accessVlanLabel.Visible = false;
                accessVlanTextBox.Visible = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (lastInterface.Text == null || intTypeComboBox.SelectedIndex == 3)
            {
                if (switchportComboBox.SelectedIndex == 0)
                {
                    if (voiceVlan.Text == null)
                    {
                        data.Interfaces.Add(new Interface(false, intTypeComboBox.SelectedItem.ToString(), switchportComboBox.SelectedItem.ToString(), firstInterface.Text, null, null, null, accessVlanTextBox.Text, null));
                    }
                    else
                    {
                        data.Interfaces.Add(new Interface(false, intTypeComboBox.SelectedItem.ToString(), switchportComboBox.SelectedItem.ToString(), firstInterface.Text, null, null, null, accessVlanTextBox.Text, voiceVlan.Text));
                    }
                }
                else if (switchportComboBox.SelectedIndex == 1)
                {
                    data.Interfaces.Add(new Interface(false, intTypeComboBox.SelectedItem.ToString(), switchportComboBox.SelectedItem.ToString(), firstInterface.Text, null, null, null, null, null));
                }
                else if (switchportComboBox.SelectedIndex == 2)
                {
                    data.Interfaces.Add(new Interface(false, intTypeComboBox.SelectedItem.ToString(), switchportComboBox.SelectedItem.ToString(), firstInterface.Text, null, intIPAddressTextBox.Text, intSubnetMask.Text, null, null));
                }
            }
            else
            {
                if (switchportComboBox.SelectedIndex == 0)
                {
                    if(voiceVlan.Text == null)
                    {
                        data.Interfaces.Add(new Interface(true, intTypeComboBox.SelectedItem.ToString(), switchportComboBox.SelectedItem.ToString(), firstInterface.Text, lastInterface.Text, null, null, accessVlanTextBox.Text, null));
                    }
                    else
                    {
                        data.Interfaces.Add(new Interface(true, intTypeComboBox.SelectedItem.ToString(), switchportComboBox.SelectedItem.ToString(), firstInterface.Text, lastInterface.Text, null, null, accessVlanTextBox.Text, voiceVlan.Text));
                    }
                }
                else if (switchportComboBox.SelectedIndex == 1)
                {
                    data.Interfaces.Add(new Interface(true, intTypeComboBox.SelectedItem.ToString(), switchportComboBox.SelectedItem.ToString(), firstInterface.Text, lastInterface.Text, null, null, null, null));
                }
                else if (switchportComboBox.SelectedIndex == 2)
                {
                    data.Interfaces.Add(new Interface(true, intTypeComboBox.SelectedItem.ToString(), switchportComboBox.SelectedItem.ToString(), firstInterface.Text, lastInterface.Text, intIPAddressTextBox.Text, intSubnetMask.Text, null, null));
                }
            }
            Console.WriteLine(data.Interfaces[0].firstInterface);
            SetDefaults();
        }

        private void SetDefaults()
        {
            intTypeComboBox.SelectedIndex = -1;
            switchportComboBox.SelectedIndex = -1;
            firstInterface.Text = null;
            lastInterface.Text = null;
            intIPAddressTextBox.Text = null;
            intSubnetMask.Text = null;
            voiceVlan.Text = null;
            accessVlanTextBox.Text = null;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewVlansButton_Click(object sender, EventArgs e)
        {
            interfaceView.RefreshInterfaces();
        }
    }
}
