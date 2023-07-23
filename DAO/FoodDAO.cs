using DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get { if (FoodDAO.instance == null) instance = new FoodDAO(); return instance; }
            private set { FoodDAO.instance = value; }
        }

        public FoodDAO() { }
        public List<Food> GetFoodList(int id)
        {
            List<Food> list = new List<Food>();
            string query = "select * from \"Food\" where \"idCategory\" = " + id;
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                Food food = new Food(row);
                list.Add(food);
            }
            return list;

        }


    }
}
