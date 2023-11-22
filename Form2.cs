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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void filialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_KuDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_KuDataSet.Filial". При необходимости она может быть перемещена или удалена.
            this.filialTableAdapter.Fill(this.dB_KuDataSet.Filial);

        }
        private Form3 t;
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Form3();
            t.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < filialDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < filialDataGridView.RowCount - 1; j++)
                {
                    filialDataGridView[i, j].Style.BackColor = Color.White;
                    filialDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < filialDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < filialDataGridView.RowCount - 1; j++)
                {
                    if (filialDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        filialDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        filialDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            filialBindingSource.Filter = "Gorod='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            filialBindingSource.Filter = "";
        }
    }
}
