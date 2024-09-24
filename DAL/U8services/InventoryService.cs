using DataMaintenance.Model;
using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Sql;

namespace DataMaintenance.DAL.U8services
{
 public   class InventoryService
    {
        public List<Inventory> GetInveoryList()
        {

            
            List<Inventory> inventoryList = new List<Inventory>();
            
            SqlDataReader sqlDataReader=  Sqlhelper.GetSqlDataReader("select * from inventory order by cInvCCode", Sqlhelper.DataSourceType.u8);

            while (sqlDataReader.Read())
            {
                Inventory m = new Inventory();
                m.cInvCCode = sqlDataReader["cInvCCode"].ToString();
                                  
              
                m.cInvCode = sqlDataReader["cInvCode"].ToString();
                m.cInvName = sqlDataReader["cInvName"].ToString(); 
                m.cInvStd = sqlDataReader["cInvStd"].ToString(); 
                m.cEnglishName = sqlDataReader["cEnglishName"].ToString();
                inventoryList.Add(m);
            }
        

            return inventoryList;
        }
    }
}
