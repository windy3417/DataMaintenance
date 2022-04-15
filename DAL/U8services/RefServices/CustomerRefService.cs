﻿using DataMaintenance.DAL.U8services.TableServices;
using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataMaintenance.DAL.U8services.RefServices
{
  public  class CustomerRefService

    {

        public List<Customer> GetListCustomerInArchive()
        {

            var q = from s in new CustomerService().GetListCustomer()
                    join y in new AttacheFileService().GetListCustomer()
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
