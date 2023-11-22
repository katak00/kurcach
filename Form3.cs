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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void filialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_KuDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_KuDataSet.Filial". При необходимости она может быть перемещена или удалена.
            this.filialTableAdapter.Fill(this.dB_KuDataSet.Filial);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
