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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void otdelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.otdelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_KuDataSet);

        }

        private void otdelBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.otdelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_KuDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_KuDataSet1.Sotrud". При необходимости она может быть перемещена или удалена.
            this.sotrudTableAdapter.Fill(this.dB_KuDataSet1.Sotrud);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_KuDataSet1.otdel". При необходимости она может быть перемещена или удалена.
            this.otdelTableAdapter1.Fill(this.dB_KuDataSet1.otdel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_KuDataSet.otdel". При необходимости она может быть перемещена или удалена.
            this.otdelTableAdapter.Fill(this.dB_KuDataSet.otdel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
