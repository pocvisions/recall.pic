using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenshotReviewer2
{
    public partial class DataForm1 : Form
    {
        public DataForm1()
        {
            InitializeComponent();
        }

        public static DataGridView DGV1 = new DataGridView();

        private void DataForm1_Load(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter1.Fill(this.screenshotReviewerDB1DataSet.DataTable1);
            DGV1 = this.dataTable1DataGridView;
        }

        private void dataTable1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
