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
    public partial class Main : Form
    {
        public Data data;
        public Interfaces interfaces;

        public Main()
        {
            InitializeComponent();
            data = new Data();
            data.Main();
            interfaces = new Interfaces();
        }

        private void finalizeButton_Click(object sender, EventArgs e)
        {
            data.hostname = hostnameTextBox.Text;
            data.username = usernameTextBox.Text;
            data.enPass = enablePasswordTextBox.Text;
            data.userPass = usernamePasswordTextBox.Text;

            Viewer viewer = new Viewer();
            viewer.Show();
            viewer.data = data;

            Console.Write(data.hostname);
        }

        private void sshCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (data.ssh == true)
            {
                data.ssh = false;
            }
            else if (data.ssh == false)
            {
                data.ssh = true;
            }
        }

        private void snmpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SNMP snmp = new SNMP();

            if (data.snmp == false)
            {
                data.snmp = true;
                snmp.Show();
                snmp.data = data;
            }

            else if (data.snmp == true)
            {
                data.snmp = false;
            }
        }

        private void vtpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            VTP vtp = new VTP();
            if (data.vtp == false)
            {
                data.vtp = true;
                vtp.Show();
                vtp.data = data;
            }
            else if (data.vtp == true)
            {
                data.vtp = false;
            }
        }

        private void eigrpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EIGRP eigrp = new EIGRP();
            if (data.eigrp == false)
            {
                data.eigrp = true;
                eigrp.Show();
                eigrp.data = data;
            }
            else if (data.eigrp == true)
            {
                data.eigrp = false;
            }
        }

        private void configureInterfacesButton_Click(object sender, EventArgs e)
        {
            if (interfaces.Visible == false)
            {
                ViewVlans viewVlans = new ViewVlans();
                viewVlans.data = data;
                viewVlans.Left = 800;
                viewVlans.Show();
                interfaces.data = data;
                interfaces.interfaceView = viewVlans;
                interfaces.Show();
            }
            else if (interfaces.Visible == true)
            {
                interfaces = new Interfaces();
            }
        }

        private void staticRoutesButton_Click(object sender, EventArgs e)
        {
            StaticRoutes staticRoutes = new StaticRoutes();
            staticRoutes.data = data;
            staticRoutes.Show();
        }
    }
}
