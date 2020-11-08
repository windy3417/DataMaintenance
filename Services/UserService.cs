using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataMaintenance.Modle;
using System.Data;
using System.Data.SqlClient;
using static Utility.Sql.Sqlhelper;

namespace DataMaintenance.Services
{
    class UserService
    {
        public List<UserModle> getUserList()
        {
            List<UserModle> listUser = new List<UserModle>();
            string sql = "select  *  from  [user] where 1=@queryAll   ";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@queryAll",1 )
            };

            SqlDataReader sqlDataReader = Utility.Sql.Sqlhelper.GetSqlDataReader(sql, dataSourceType.plug, sqlParameters);
            while (sqlDataReader.Read())
            {
                UserModle m = new UserModle();
                m.userID = Convert.ToInt32(sqlDataReader["userID"]);
                m.name = sqlDataReader["name"].ToString();




                listUser.Add(m);
            }
            return listUser;
        }


        /// <summary>
        /// 检测登录密码与用户名
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool loginCheck(int userID,string pwd)
        {
            using (var db=new DataMaitenanceContext())
            {
                
                var q = db.Users.Where( s =>s.userID==userID  & s.pwd == pwd).ToList();
                if (q.Count>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            

        }

        public void updateCustomer()
        {

        }
    }
}



