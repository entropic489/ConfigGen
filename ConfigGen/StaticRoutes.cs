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
    public partial class StaticRoutes : Form
    {
        public Data data;

        public StaticRoutes()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (interfaceRadioButton.Checked == true)
            {
                data.StaticRoutes.Add(new StaticRoute(true, destinationIPTextBox.Text, destinationSubnetMask.Text, sourceIntTextBox.Text, sourceIPTextBox.Text, sourceSubnetMask.Text));
            }
            else if (ipRadioButton.Checked == true)
            {
                data.StaticRoutes.Add(new StaticRoute(false, destinationIPTextBox.Text, destinationSubnetMask.Text, sourceIntTextBox.Text, sourceIPTextBox.Text, sourceSubnetMask.Text));
            }

            SetDefaults();
        }

        private void interfaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sourceIntTextBox.Visible = true;
            sourceIntLabel.Visible = true;
            sourceIPTextBox.Visible = false;
            sourceSubnetMask.Visible = false;
            sourceSubnetLabel.Visible = false;
            sourceIPLabel.Visible = false;
        }

        private void ipRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sourceIntTextBox.Visible = false;
            sourceIntLabel.Visible = false;
            sourceIPTextBox.Visible = true;
            sourceSubnetMask.Visible = true;
            sourceSubnetLabel.Visible = true;
            sourceIPLabel.Visible = true;
        }

        private void SetDefaults()
        {
            sourceIntTextBox.Visible = false;
            sourceIntLabel.Visible = false;
            sourceIPTextBox.Visible = false;
            sourceSubnetMask.Visible = false;
            sourceSubnetLabel.Visible = false;
            sourceIPLabel.Visible = false;

            destinationIPTextBox.Text = null;
            destinationSubnetMask.Text = null;
            sourceIntTextBox.Text = null;
            sourceSubnetMask.Text = null;
            sourceIPTextBox.Text = null;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
