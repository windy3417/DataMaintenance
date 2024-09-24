using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataMaintenance.Model;
using System.Data;
using System.Data.SqlClient;
using static Utility.Sql.Sqlhelper;
using DataMaintenance.Model.Maintenance;

namespace DataMaintenance.DAL
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

            SqlDataReader sqlDataReader = Utility.Sql.Sqlhelper.GetSqlDataReader(sql, sqlParameters, DataSourceType.business );
            while (sqlDataReader.Read())
            {
                UserModle m = new UserModle();
                m.userID = sqlDataReader["userID"].ToString();
                m.UserName = sqlDataReader["name"].ToString();




                listUser.Add(m);
            }
            return listUser;
        }


        #region login check

        /// <summary>
        /// login check from buseness db
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool loginCheck(string userID, string pwd, out string userName)
        {


            string sql = "select  *  from  [user] where userID=@userID and pwd=@pwd  ";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@userID",userID ),
                new SqlParameter("@pwd",pwd ),
            };

            SqlDataReader sqlDataReader = Utility.Sql.Sqlhelper.GetSqlDataReader(sql, sqlParameters, DataSourceType.business);
            if (sqlDataReader.HasRows)
            {
                sqlDataReader.Read();
                userName = sqlDataReader["UserName"].ToString();
                return true;


            }
            userName = "";
            return false;
        }

        public bool LogingCheckFromU8(string userID, string pwd, out string userName)
        {
            string sql = @"select cUser_Id,cUser_Name,cPassword,nState from UA_User where cUser_Id = @cUser_Id and cPassword = @cPassword";
            SqlParameter[] sqlParameters =
           {
                new SqlParameter("@cUser_Id",userID ),
                new SqlParameter("@cPassword",pwd ),
            };

            SqlDataReader sqlDataReader = Utility.Sql.Sqlhelper.GetSqlDataReader(sql, sqlParameters, DataSourceType.ufsystem);
            if (sqlDataReader.HasRows)
            {
                sqlDataReader.Read();
                userName = sqlDataReader["cUser_Name"].ToString();
                return true;


            }
            userName = "";
            return false;

        }


        #endregion
        /// <summary>
        /// 检测登录密码与用户名
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool loginCheck(string userID,string pwd)
        {
            using (var db=new DataMaintenanceContext())
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



