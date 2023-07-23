using DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get { if (CategoryDAO.instance == null) instance = new CategoryDAO(); return instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }

        public List<Category> getlistCategory()
        {
            List<Category> list = new List<Category>();
            string query = "select * from \"FoodCategory\"";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                Category category = new Category(dr);
                list.Add(category);
            }
            return list;
        }

    }
}
