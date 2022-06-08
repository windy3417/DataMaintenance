using DataMaintenance.Model.U8;
using DataMaintenance.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Utility.DAL;

namespace DataMaintenance.DAL.ViewServices.U8services
{
  public  class InventoryAttachmentService
    {
        public List<ArchiveVModel> GetInventoryArchive(List<SqlParameter> sqlParameters)

        {
            var q = QueryService.GetDataList<Attachfile>(sqlParameters, Utility.Sql.Sqlhelper.DataSourceType.u8);

            var q1 = QueryService.GetDataList<Inventory>(Utility.Sql.Sqlhelper.DataSourceType.u8);

            var q3 = from s in q
                     join c in q1 on s.cInvCode equals c.cInvCode
                     select new
                     {
                         cInvCode = c.cInvCode,
                         archiveMarsterName = c.cInvName,
                         archiveName = s.cFileName,
                         s.AttachFileGUID
                     };



            List<ArchiveVModel> ls = new List<ArchiveVModel>();

            foreach (var item in q3)
            {
                ArchiveVModel m = new ArchiveVModel();
                m.ArchiveCode = item.cInvCode;
                m.ArchiveMarsterName = item.archiveMarsterName;
                m.ArchiveName = item.archiveName;
                m.AttachFileGUID = item.AttachFileGUID;

                ls.Add(m);
            }

            return ls;


        }

    }
}
