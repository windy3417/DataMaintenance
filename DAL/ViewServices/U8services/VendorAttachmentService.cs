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
  public  class VendorAttachmentService
    {
        public List<ArchiveVModel> GetListArchiveEntiy()
        {

            var q = from s in new MasterDataService().GetListVendor()
                    join y in new AttacheFileService().GetListAttachfile()
                    on s.cVenCode equals y.cInvCode
                    select new { s.cVenCode, s.cVenName, y.cFileName, y.AttachFileGUID };

            List<ArchiveVModel> ls = new List<ArchiveVModel>();

            foreach (var item in q)
            {
                ArchiveVModel m = new ArchiveVModel();
                m.ArchiveCode = item.cVenCode;
                m.ArchiveName = item.cVenName;
                m.AttachFileGUID = item.AttachFileGUID;

                ls.Add(m);
            }

            return ls;

        }

        public List<ArchiveVModel> GetVendorArchive(List<SqlParameter> sqlParameters)
        {
            var q = QueryService.GetDataList<Attachfile>(sqlParameters, Utility.Sql.Sqlhelper.DataSourceType.u8);

            var q1 = QueryService.GetDataList<Vendor>(Utility.Sql.Sqlhelper.DataSourceType.u8);

            var q3 = from s in q
                     join c in q1 on s.cInvCode equals c.cVenCode
                     select new { cInvCode = c.cVCCode, archiveMarsterName = c.cVenName, 
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
