using DataMaintenance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMaintenance.DAL.U8services
{
    internal class MateriaOutService
    {
        public decimal? GetMateriaOutAmount(DateTime stockOutDate,
           string cinvCode, string u8AccountNo)
        {
            using (var db = new U8Context(u8AccountNo))
            {
                var query = from p in db.rdrecord11.Where(s => s.dDate <= stockOutDate)
                            join r in db.rdrecords11.Where(rd => rd.cInvCode == cinvCode)
                            on p.ID equals r.ID


                            select r.iQuantity;

                return query.ToList().Sum();
            }
        }
    }
}
