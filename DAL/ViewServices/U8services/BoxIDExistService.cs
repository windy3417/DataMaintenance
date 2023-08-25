using DataMaintenance.Model;
using DataMaintenance.Model.U8;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Common;

namespace DataMaintenance.DAL.ViewServices.U8services
{
   public class BoxIDExistService
    {
        public DataTable GetCurrentStock(Func<CurrentStock, Boolean> headerFilter, Func<rdrecord10, Boolean> funcDetail)


        {
            using (var db = new U8Context())
            {
                var q = (from a in db.CurrentStock.Where(headerFilter)
                         join b in db.Inventory on a.cInvCode equals b.cInvCode
                         join c in db.Warehouse on a.cWhCode equals c.cWhCode
                         select new {c.cWhCode,c.cWhName, a.cInvCode, b.cInvName, b.cInvStd, a.iQuantity }).ToList(); ;

                
                return Utility.Common.CustomLINQtoDataSetMethods.CopyToDataTable(q);
            }
        }

        
        public DataTable GetBoxIdExist(string invCode,DateTime stockInDate)
        {
            //DateTime startDate = DateTime.Parse("2023-01-01");
            using (var db=new U8Context())
            {
                var q = (from a in db.rdrecord10.Where(s => s.dDate >= stockInDate)
                          join b in db.rdrecords10.Where(s =>s.cInvCode== invCode) 
                                    on a.ID equals b.ID 
                        
                          join c in db.rdrecords32.Where(s =>s.cInvCode==invCode) 
                                    on new { b.cInvCode, b.cDefine31 } equals new { c.cInvCode, c.cDefine31 } into bc
                          from d in bc.DefaultIfEmpty()
                          select new { a,b, d }).ToList();

                var dataSource =from s in q
                                 where s.d is null
                                 orderby s.a.dDate
                                 select new { s.a.dDate, s.a.cCode, s.b.cInvCode, s.b.cDefine31,s.b.iQuantity };
              

                return dataSource.CopyToDataTable();
            }
        }
    }
}
