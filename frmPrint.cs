using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurcach
{
    public partial class frmPrint : Form
    {
        Orders _orders;
        List<OrderDetail> _list;
        public frmPrint(Orders orders, List<OrderDetail> list)
        {
            InitializeComponent();
            _orders = orders;
            _list = list;
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            //Init data source
          // OrderDetailBindingSource.DataSource = _list;
            //Set parameter for your report
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pOrderID",_orders.id.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pOrderDate",_orders.Data.ToString("MM/dd/yyyy")),
                
            };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
