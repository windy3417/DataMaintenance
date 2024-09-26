using DataMaintenance.DAL.TableServices.U8services;

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
  public  class CustomerAttachmentService
    {
        public List<ArchiveVModel> GetListArchiveEntiy(String u8Account)
        {

            var q = from s in new MasterDataService().GetListCustomer(u8Account)
                    join y in new AttacheFileService().GetListAttachfile()
                    on s.cCusCode equals y.cInvCode
                    select new { s.cCusCode, s.cCusName, y.cFileName, y.AttachFileGUID };

            List<ArchiveVModel> ls = new List<ArchiveVModel>();

            foreach (var item in q)
            {
                ArchiveVModel m = new ArchiveVModel();
                m.ArchiveCode = item.cCusCode;
                m.ArchiveName = item.cCusName;
                m.AttachFileGUID = item.AttachFileGUID;

                ls.Add(m);
            }

            return ls;

        }

        public List<ArchiveVModel> GetCustomerArchive(List<SqlParameter> sqlParameters)
        {
            var q = QueryService.GetDataList<Attachfile>(sqlParameters, Utility.Sql.Sqlhelper.DataSourceType.u8);

            var q1 = QueryService.GetDataList<Customer>(Utility.Sql.Sqlhelper.DataSourceType.u8);

            var q3 = from s in q
                     join c in q1 on s.cInvCode equals c.cCusCode
                     select new { cInvCode = c.cCusCode, archiveMarsterName = c.cCusName, 
                         archiveName = s.cFileName, s.AttachFileGUID };




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
