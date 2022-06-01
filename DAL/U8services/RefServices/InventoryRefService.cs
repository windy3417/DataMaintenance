using DataMaintenance.DAL.U8services.TableServices;
using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataMaintenance.DAL.U8services.RefServices
{
  public  class InventoryRefService


    {

        public List<Inventory> GetListInventoryInArchive()

        {

            var q = from s in new MasterDataService().GetListInventory()
                    join y in new AttacheFileService().GetListInventoryInAttachfiles()
                    on s.cInvCode equals y
                    select new { s.cInvCode, s.cInvName,s.cInvStd };

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
    }
}
