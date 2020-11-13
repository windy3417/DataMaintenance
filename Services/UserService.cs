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
        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
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
                m.userID = sqlDataReader["userID"].ToString();
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
        public bool loginCheck(string userID,string pwd)
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

        /// <summary>
        /// 使用Sqlparameters检测登录密码与用户名
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool loginCheckWithSqlparameters(string userID, string pwd)
        {
           
           
            string sql = "select  *  from  [user] where userID=@userID and pwd=@pwd  ";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@userID",userID ),
                new SqlParameter("@pwd",pwd ),
            };

            SqlDataReader sqlDataReader = Utility.Sql.Sqlhelper.GetSqlDataReader(sql, dataSourceType.plug, sqlParameters);
            if (sqlDataReader.HasRows)
            {
                return true;

                              
            }
            return false;
        }

        public void updateCustomer()
        {

        }
    }
}



