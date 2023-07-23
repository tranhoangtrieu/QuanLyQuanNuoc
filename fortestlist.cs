using DoAn.DAO;
using DoAn.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAn
{
    public partial class fortestlist : Form
    {
        public fortestlist()
        {
            InitializeComponent();
            //loaddata();
           
        }


        void loaddata()
        {
            int id = 2;
            // string query = "select * from \"FoodCategory\" " ;

            //string query = "select * from \"Food\" where \"idCategory\" = " + id;
            // DataProvider dt = new DataProvider();
            //datagrTest.DataSource = DataProvider.Instance.ExecuteQuery(query);
            

            //  List<Food> foods = FoodDAO.Instance.GetFoodList(id);
            // datagrTest.DataSource = foods;
            // comboBox1.DisplayMember = "name";
        }

       


        private void datagrTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
