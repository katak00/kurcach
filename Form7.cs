using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;

namespace kurcach
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_KuDataSet.Zatrat". При необходимости она может быть перемещена или удалена.
            this.zatratTableAdapter.Fill(this.dB_KuDataSet.Zatrat);

        }









        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                //Execute query to get data from orders and customers data
                

                string query = "select c.id, o.Data, Stoim, vid_zatrat" +
                               " from Zatrat  o inner join Filial c on o.id_FG = c.id_FG" +
                                $" where o.Data between '{dtFromDate.Value}' and '{dtToDate.Value}'";


                ordersBindingSource.DataSource = db.Query<Orders>(query, commandType: CommandType.Text);
                
            }
        }



        private void btnPrint_Click(object sender, EventArgs e)
        {
            Orders obj = ordersBindingSource.Current as Orders;
            if (obj != null)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    //Execute query to get orderdetails and products data
                    string query = "select c.id, o.Data, Stoim, vid_zatrat" +
                               " from Zatrat  o inner join Filial c on o.id_FG = c.id_FG" +
                                    $" where c.id = {obj.id}";
                    List<OrderDetail> list = db.Query<OrderDetail>(query, commandType: CommandType.Text).ToList();
                   using (frmPrint frm = new frmPrint(obj, list))
                    {
                       frm.ShowDialog();
                    }
                }
            }

        }
        private Form8 b;
        private void button1_Click(object sender, EventArgs e)
        {
            b = new Form8();
            b.Visible = true;
        }
    }
}
