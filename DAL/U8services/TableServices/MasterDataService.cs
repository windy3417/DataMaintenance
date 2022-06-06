using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Utility.Sql.Sqlhelper;

namespace DataMaintenance.DAL.U8services.TableServices
{
 public   class MasterDataService
    {

        public List<Customer> GetListCustomer()
        {
            return Utility.DAL.QueryService.GetDataList<Customer>(DataSourceType.u8);
        }

        public List<Inventory> GetListInventory()
        {
            return Utility.DAL.QueryService.GetDataList<Inventory>(DataSourceType.u8);
        }

        public List<InventoryClass> GetListInventoryClass()
        {
            return Utility.DAL.QueryService.GetDataList<InventoryClass>(DataSourceType.u8);
        }
    }
}
