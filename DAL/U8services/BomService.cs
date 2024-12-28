using DataMaintenance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMaintenance.DAL.U8services
{
    internal class BomService
    {
        public string GetBomParent(string childInvCode,string u8Account)
        {
            using (var db = new U8Context(u8Account))
            {
                var query= from b in db.bom_bom
                           join c in db.bom_parent on  b.BomId equals c.BomId
                           join d in db.bas_part on c.ParentId equals d.PartId
                           join e in db.bom_opcomponent on c.BomId equals e.BomId
                           join f in db.bas_part on e.ComponentId equals f.PartId

                           where f.InvCode==childInvCode 
                           select d.InvCode;
                return query.FirstOrDefault();
            }
        }
    }
}
