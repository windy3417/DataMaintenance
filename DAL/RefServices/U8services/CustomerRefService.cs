using DataMaintenance.DAL.TableServices.U8services;

using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataMaintenance.DAL.RefServices.U8services
{
    public class CustomerRefService

    {

        public List<Customer> GetListCustomerInArchive(String u8Account)
        {

            var q = from s in new MasterDataService().GetListCustomer(u8Account)
                    join y in new AttacheFileService().GetListCustomerInAttachfiles()
                    on s.cCusCode equals y
                    select new { s.cCusCode, s.cCusName };

            List<Customer> ls = new List<Customer>();

            foreach (var item in q)
            {
                Customer m = new Customer();
                m.cCusCode = item.cCusCode;
                m.cCusName = item.cCusName;

                ls.Add(m);
            }

            return ls;

        }
    }
}
 

