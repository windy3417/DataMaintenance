using DataMaintenance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMaintenance.DAL.U8services
{
    internal class FinishedGoodService
    {
        public decimal? GetFinishedGoodAmount(DateTime FinishedGoodInDate,
           string cinvCode, string u8AccountNo)
        {
            using (var db = new U8Context(u8AccountNo))
            {
                var query = from p in db.rdrecord10.Where(s => s.dDate <= FinishedGoodInDate)
                            join r in db.rdrecords10.Where(rd => rd.cInvCode == cinvCode)
                            on p.ID equals r.ID


                            select r.iQuantity;

                return query.ToList().Sum();
            }
        }
    }
}
