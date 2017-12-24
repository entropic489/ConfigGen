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
    public partial class ViewVlans : Form
    {
        public Data data;
        private int counter;

        public ViewVlans()
        {
            InitializeComponent();
            counter = 0;
        }

        public void RefreshInterfaces()
        {
            intDataGridView.Rows.Clear();

            foreach (Interface i in data.Interfaces)
            {
                intDataGridView.RowCount += 1;

                intDataGridView[0, counter].Value = i.isRange;
                intDataGridView[1, counter].Value = i.type;
                intDataGridView[2, counter].Value = i.firstInterface;
                intDataGridView[3, counter].Value = i.lastInterface;
                intDataGridView[4, counter].Value = i.switchportType;
                intDataGridView[5, counter].Value = i.accessVlan;
                intDataGridView[6, counter].Value = i.voiceVlan;
                intDataGridView[7, counter].Value = i.intIPAddress;
                intDataGridView[8, counter].Value = i.intSubnetMask;

                counter++;
            }
            counter = 0;
        }
    }
}
