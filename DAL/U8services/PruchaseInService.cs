using DataMaintenance.Model;
using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMaintenance.DAL.U8services
{
    internal class PruchaseInService
    {
        public decimal? GetPurchseAmountQty(Func<RdRecord01, Boolean> headerFilter,
            Func<rdrecords01, Boolean> funcDetail, string u8AccountNo)
        {
            using (var db=new U8Context(u8AccountNo))
            {
                var query = from p in db.RdRecord01.Where(headerFilter)
                            join r in db.rdrecords01.Where(funcDetail) 
                            on p.ID equals r.ID
                            
 
                            select r.iQuantity;
                return query.Sum();
            }
        }

        public decimal? GetPurchseAmountQty(DateTime stockInDate,
           string cinvCode, string u8AccountNo)
        {
            using (var db = new U8Context(u8AccountNo))
            {
                var query = from p in db.RdRecord01.Where( s => s.dDate <= stockInDate )
                            join r in db.rdrecords01.Where(rd =>rd.cInvCode == cinvCode)
                            on p.ID equals r.ID


                            select r.iQuantity;
                
                return query.ToList().Sum();
            }
        }
    }
}
