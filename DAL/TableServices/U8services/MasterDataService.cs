using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Utility.Sql.Sqlhelper;

namespace DataMaintenance.DAL.TableServices.U8services
{
 public   class MasterDataService
    {

        public List<Customer> GetListCustomer(String u8Account)
        {
            return Utility.DAL.QueryService.GetListFromSingleTable<Customer>(DataSourceType.u8,u8Account);
        }

        public List<Vendor> GetListVendor(String u8Account)
        {
            return Utility.DAL.QueryService.GetListFromSingleTable<Vendor>(DataSourceType.u8,u8Account);
        }

        public List<Inventory> GetListInventory(String u8Account)
        {
            return Utility.DAL.QueryService.GetListFromSingleTable<Inventory>(DataSourceType.u8,u8Account);
        }

        public List<InventoryClass> GetListInventoryClass(String u8Account)
        {
            return Utility.DAL.QueryService.GetListFromSingleTable<InventoryClass>(DataSourceType.u8,u8Account);
        }
    }
}
