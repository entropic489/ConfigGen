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
    public partial class Viewer : Form
    {
        public Data data;

        public Viewer()
        {
            InitializeComponent();

            Console.Write(data);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            configTextBox.Text += "en";
            configTextBox.Text += "\nconf t";
            configTextBox.Text += "\nhostname " + data.hostname;
            configTextBox.Text += "\nenable secret " + data.enPass;
            configTextBox.Text += "\nusername " + data.username + " password " + data.userPass;

            if (data.ssh == true)
            {
                configTextBox.Text += "\nline vty 0 15";
                configTextBox.Text += "\ntransport input ssh";
                configTextBox.Text += "\nlogin local";
                configTextBox.Text += "\nlogging sync";
                configTextBox.Text += "\nexit";
                configTextBox.Text += "\nip domain-name " + data.ipDomainName;
                configTextBox.Text += "\ncrypto key gen rsa";
                configTextBox.Text += "\n1024";
            }
            else if (data.ssh == false)
            {
                configTextBox.Text += "\nline vty 0 15";
                configTextBox.Text += "\nlogin local";
                configTextBox.Text += "\nlogging sync";
            }
            configTextBox.Text += "\nline con 0";
            configTextBox.Text += "\nlogin local";
            configTextBox.Text += "\nlogging sync";
            configTextBox.Text += "\nexit";

            if (data.snmp == true)
            {
                configTextBox.Text += "\nsnmp-server " + data.snmpVersion;
                if (data.snmpCommunityReadOnly == true)
                {
                    configTextBox.Text += "\nsnmp-server community " + data.snmpCommunityString + " RO";
                }
                else if (data.snmpCommunityReadOnly == false)
                {
                    configTextBox.Text += "\nsnmp-server community " + data.snmpCommunityString + " RW";
                }
            }

            if (data.vtp == true)
            {
                configTextBox.Text += "\nvtp domain " + data.vtpDomainName;

                if (data.vtpMode == "Server")
                {
                    configTextBox.Text += "\nvtp mode server";

                    if (data.Vlans != null)
                    {
                        foreach (VLAN vlan in data.Vlans)
                        {
                            configTextBox.Text += "\nvlan " + vlan.ID;
                            configTextBox.Text += "\ndescription " + vlan.description;
                        }
                    }
                }
                else
                {
                    configTextBox.Text += "\nvtp mode " + data.vtpMode;
                }
                configTextBox.Text += "\nexit";
            }

            if (data.eigrp == true)
            {
                configTextBox.Text += "\nrouter eigrp " + data.eigrpASN;

                if (data.EIGRP != null)
                {
                    foreach (Net net in data.EIGRP)
                    {
                        configTextBox.Text += "\nnet " + net.netIPAddress + " " + net.netSubnetMask;
                    }
                }

                configTextBox.Text += "\nexit";
            }

            if (data.Interfaces != null)
            {
                foreach (Interface inter in data.Interfaces)
                {
                    if (inter.isRange == true)
                    {
                        configTextBox.Text += "\ninterface range " + inter.type + inter.firstInterface + "-" + inter.lastInterface;
                    }
                    else if (inter.isRange == false)
                    {
                        configTextBox.Text += "\ninterface " + inter.type + inter.firstInterface;
                    }

                    if (inter.switchportType == "access")
                    {
                        configTextBox.Text += "\nswitchport mode access";
                        configTextBox.Text += "\nswitchport access vlan " + inter.accessVlan;
                        if (inter.voiceVlan != null)
                        {
                            configTextBox.Text += "\nswitchport voice vlan " + inter.voiceVlan;
                        }
                    }
                    else if (inter.switchportType == "trunk")
                    {
                        configTextBox.Text += "\nswitchport trunk encap dot1q";
                        configTextBox.Text += "\nswitchport mode trunk";
                    }
                    else if (inter.switchportType == "IP address")
                    {
                        configTextBox.Text += "\nno switchport";
                        configTextBox.Text += "\nip add " + inter.intIPAddress + " " + inter.intSubnetMask;
                        configTextBox.Text += "\nexit";
                        configTextBox.Text += "\nip routing";
                    }
                }
            }

            if (data.StaticRoutes != null)
            {
                foreach (StaticRoute staticRoute in data.StaticRoutes)
                {
                    if (staticRoute.isInterface)
                    {
                        configTextBox.Text += "\nip route " + staticRoute.destinationIP + " " + staticRoute.destinationSubnetMask + " " + staticRoute.sourceInterface;
                    }
                    else if (!staticRoute.isInterface)
                    {
                        configTextBox.Text += "\nip route " + staticRoute.destinationIP + " " + staticRoute.destinationSubnetMask + " " + staticRoute.sourceIP + " " + staticRoute.sourceSubnetMask;
                    }
                }
            }

            configTextBox.Text += "\nservice password-encryption";
        }
    }
}
