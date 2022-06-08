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
            return Utility.DAL.QueryService.GetDataList<Customer>(DataSourceType.u8);
        }

        public List<Vendor> GetListVendor()
        {
            return Utility.DAL.QueryService.GetDataList<Vendor>(DataSourceType.u8);
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
