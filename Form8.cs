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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void zatratBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zatratBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_KuDataSet1);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_KuDataSet1.Filial". При необходимости она может быть перемещена или удалена.
            this.filialTableAdapter.Fill(this.dB_KuDataSet1.Filial);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_KuDataSet1.Zatrat". При необходимости она может быть перемещена или удалена.
            this.zatratTableAdapter.Fill(this.dB_KuDataSet1.Zatrat);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
