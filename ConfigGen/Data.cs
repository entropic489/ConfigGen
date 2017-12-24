using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigGen
{
    public struct VLAN
    {
        public int ID;
        public string description;

        public VLAN(int newID, string newDescription)
        {
            ID = newID;
            description = newDescription;
        }

    }

    public struct Interface
    {
        public bool isRange;
        public string type;
        public string switchportType;
        public string firstInterface;
        public string lastInterface;
        public string intIPAddress;
        public string intSubnetMask;
        public string accessVlan;
        public string voiceVlan;

        public Interface(bool newIsRange, string newType, string newSwitchportType, string newFirstInt, string newLastInt, string newIPAddress, string newSubnetMask, string newAccessVlan, string newVoiceVlan)
        {
            isRange = newIsRange;
            type = newType;
            switchportType = newSwitchportType;
            firstInterface = newFirstInt;
            lastInterface = newLastInt;
            intIPAddress = newIPAddress;
            intSubnetMask = newSubnetMask;
            accessVlan = newAccessVlan;
            voiceVlan = newVoiceVlan;
        }
    }

    public struct Net
    {
        public string netIPAddress;
        public string netSubnetMask;

        public Net(string newNetIPAddress, string newNetSubnetMask)
        {
            netIPAddress = newNetIPAddress;
            netSubnetMask = newNetSubnetMask;
        }
    }

    public struct StaticRoute
    {
        public string destinationIP;
        public string destinationSubnetMask;
        public bool isInterface;
        public string sourceInterface;
        public string sourceIP;
        public string sourceSubnetMask;

        public StaticRoute(bool newIsInterface, string newDestIP, string newDestSubnetMask, string newSourceInt, string newSourceIP, string newSourceSubnetMask)
        {
            isInterface = newIsInterface;
            destinationIP = newDestIP;
            destinationSubnetMask = newDestSubnetMask;
            sourceInterface = newSourceInt;
            sourceIP = newSourceIP;
            sourceSubnetMask = newSourceSubnetMask;
        }
    }

    public class Data
    {
        public bool eigrp;
        public bool snmp;
        public bool snmpCommunityReadOnly;
        public bool ssh;
        public bool vtp;

        public int vlanNum;
        public int eigrpNets;
        public int eigrpASN;

        public string hostname;
        public string enPass;
        public string username;
        public string userPass;
        public string snmpCommunityString;
        public string ipDomainName;
        public string snmpVersion;
        public string vtpMode;
        public string vtpDomainName;

        public List<VLAN> Vlans;
        public List<Interface> Interfaces;
        public List<Net> EIGRP;
        public List<StaticRoute> StaticRoutes;

        public void Main()
        {
            Vlans = new List<VLAN>();
            Interfaces = new List<Interface>();
            EIGRP = new List<Net>();
            StaticRoutes = new List<StaticRoute>();
        }
    }

}
