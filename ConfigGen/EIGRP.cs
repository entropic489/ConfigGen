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
    public partial class EIGRP : Form
    {
        public Data data;

        public EIGRP()
        {
            InitializeComponent();
        }

        private void EIGRP_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            data.eigrpASN = Convert.ToInt32(asnTextBox.Text);

            for (int i = 0; i <= netDataGridView.RowCount - 2; i++)
            {
                data.eigrpNets++;
                data.EIGRP.Add(new Net(netDataGridView[0, i].Value.ToString(), netDataGridView[1, i].Value.ToString()));
            }
            
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
