using DataMaintenance.Model;
using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMaintenance.DAL.TableServices.U8services
{
  public  class Rdrecord32Service
    {
        public DataTable GetRdrecord32(Func<rdrecord32, Boolean> headerFilter)

        {
            using (var db = new U8Context())
            {
                var q = from h in db.rdrecord32.Where(headerFilter)
                        join d in db.rdrecords32
                          on h.ID equals d.ID
                        join p in db.Inventory on d.cInvCode equals p.cInvCode
                        select new
                        {
                            h.dDate ,
                            h.cCode,
                            d.cDefine31,
                            
                            d.cInvCode,
                            p.cInvName,
                            p.cInvStd,
                            d.iQuantity



                        };
                return Utility.Common.CustomLINQtoDataSetMethods.CopyToDataTable(q);
            }
        }
    }
}
