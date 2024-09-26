using DataMaintenance.DAL.TableServices.U8services;

using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataMaintenance.DAL.RefServices.U8services
{
    public class VendorRefService


    {

        public List<Vendor> GetListVendorInArchive(String u8Account)
        {

            var q = from s in new MasterDataService().GetListVendor(u8Account)
                    join y in new AttacheFileService().GetListVendorInAttachfiles()
                    on s.cVenCode equals y
                    select new { s.cVenCode, s.cVenName };

            List<Vendor> ls = new List<Vendor>();

            foreach (var item in q)
            {
                Vendor m = new Vendor();
                m.cVenCode = item.cVenCode;
                m.cVenName = item.cVenName;

                ls.Add(m);
            }

            return ls;

        }
    }
}
 

