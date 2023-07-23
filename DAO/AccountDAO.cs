using DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DoAn.DAO.DataProvider;

namespace DoAn.DAO
{
    public class AccountDAO
    {

        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO(); return instance;
            }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string username, string password)
        {
            string query = "SELECT \"UserName\",\"PassWord\" FROM \"Account\" WHERE \"UserName\" = '" + username + "' AND \"PassWord\" = '" + password + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public Account GetAccount(string username)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from \"Account\" where \"UserName\" = '" + username + "'");
            foreach (DataRow dr in dt.Rows)
            {
                return new Account(dr);
            }
            return null;

        }
        
            
        }
    }


