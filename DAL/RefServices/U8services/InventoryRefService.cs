using DataMaintenance.DAL.TableServices.U8services;

using DataMaintenance.Model;
using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataMaintenance.DAL.RefServices.U8services
{
    public class InventoryRefService


    {

        public List<Inventory> GetListInventoryInArchive(String u8Account)

        {

            var q = from s in new MasterDataService().GetListInventory(u8Account)
                    join y in new AttacheFileService().GetListInventoryInAttachfiles()
                    on s.cInvCode equals y
                    select new { s.cInvCode, s.cInvName, s.cInvStd };

            List<Inventory> ls = new List<Inventory>();

            foreach (var item in q)
            {
                Inventory m = new Inventory();
                m.cInvCode = item.cInvCode;
                m.cInvName = item.cInvName;
                m.cInvStd = item.cInvStd;

                ls.Add(m);
            }

            return ls;

        }

        public List<Inventory> GetListInventoryInArchiveWithEF()

        {
            using (var db = new U8Context("017"))
            {
                var q = from s in db.Inventory
                        join a in db.Attachfile.Where(s => s.cTableName == "inventory")
                        on s.cInvCode equals a.cInvCode
                        select new { s.cInvCode, s.cInvName, s.cInvStd ,s.cInvCCode};
                List<Inventory> ls = new List<Inventory>();

                foreach (var item in q)
                {
                    Inventory m = new Inventory();
                    m.cInvCode = item.cInvCode;
                    m.cInvName = item.cInvName;
                    m.cInvStd = item.cInvStd;
                    m.cInvCCode = item.cInvCCode;

                    ls.Add(m);
                }

                return ls;

            }




        }

    }
}
