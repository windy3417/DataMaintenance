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

        public List<Customer> GetListCustomer()
        {
            return Utility.DAL.QueryService.GetListFromSingleTable<Customer>(DataSourceType.u8,"017");
        }

        public List<Vendor> GetListVendor()
        {
            return Utility.DAL.QueryService.GetListFromSingleTable<Vendor>(DataSourceType.u8,"017");
        }

        public List<Inventory> GetListInventory()
        {
            return Utility.DAL.QueryService.GetListFromSingleTable<Inventory>(DataSourceType.u8,"017");
        }

        public List<InventoryClass> GetListInventoryClass()
        {
            return Utility.DAL.QueryService.GetListFromSingleTable<InventoryClass>(DataSourceType.u8,"017");
        }
    }
}
