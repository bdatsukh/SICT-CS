using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sict
{
    public partial class ForReport : Form
    {
        public ForReport()
        {
            InitializeComponent();
        }

        private void ForReport_Load(object sender, EventArgs e)
        {
            this.PRINTGRADETableAdapter.ClearBeforeFill = true;
            // TODO: This line of code loads data into the 'SictDataSet1.PRINTGRADE' table. You can move, or remove it, as needed.
            this.PRINTGRADETableAdapter.Fill(this.SictDataSet1.PRINTGRADE, Must.ID, Must.season, Must.date);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
