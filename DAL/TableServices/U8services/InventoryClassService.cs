
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
 public   class InventoryClassService
    {
        public List<InventoryClass> GetInveoryClass()
        {

            
            List<InventoryClass> inventoryList = new List<InventoryClass>();
            
            SqlDataReader sqlDataReader=  Sqlhelper.GetSqlDataReader("select * from inventoryClass order by cInvCCode", Sqlhelper.DataSourceType.u8);

            while (sqlDataReader.Read())
            {
                InventoryClass m = new InventoryClass();
                m.cInvCCode = sqlDataReader["cInvCCode"].ToString();
                                  
              
                m.iInvCGrade =(byte) sqlDataReader["iInvCGrade"];
                m.cInvCName = sqlDataReader["cInvCName"].ToString(); 
                m.bInvCEnd =(bool) sqlDataReader["bInvCEnd"]; 
               
                inventoryList.Add(m);
            }
        

            return inventoryList;
        }
    }
}
