using DoAn.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            loadAccount();
            loadFood();
        }
        void loadAccount()
        {
            string query = "select * from \"Account\"";
            DataProvider dataProvider = new DataProvider();
            datagrv_Account.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void loadFood()
        {
            string query = "select \"name\", \"idCategory\",\"price\" from public.\"Food\""; 
            DataProvider dataProvider = new DataProvider();
            datagrv_thucan.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadListBillDate(dateTimePicker1.Value, dateTimePicker2.Value);
            
        }

        void LoadListBillDate(DateTime? chekIn, DateTime? chekOut)
        {
            datagrv_doanhthu.DataSource = BillDAO.Instance.GetBillListDate(chekIn, chekOut);

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
