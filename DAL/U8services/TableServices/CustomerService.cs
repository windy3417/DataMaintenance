using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Utility.Sql.Sqlhelper;

namespace DataMaintenance.DAL.U8services.TableServices
{
 public   class CustomerService
    {

        public List<Customer> GetListCustomer()
        {
            return Utility.DAL.QueryService.GetDataList<Customer>(DataSourceType.u8);
        }
    }
}
