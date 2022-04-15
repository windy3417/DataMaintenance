using DataMaintenance.DAL.U8services.TableServices;
using DataMaintenance.Model.U8;
using DataMaintenance.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataMaintenance.DAL.U8services
{
  public  class CustomerAttachmentService
    {
        public List<ArchiveVModel> GetListArchiveEntiy()
        {

            var q = from s in new CustomerService().GetListCustomer()
                    join y in new AttacheFileService().GetListAttachfile()
                    on s.cCusCode equals y.cInvCode
                    select new { s.cCusCode, s.cCusName, y.cFileName, y.AttachFileGUID };

            List<ArchiveVModel> ls = new List<ArchiveVModel>();

            foreach (var item in q)
            {
                ArchiveVModel m = new ArchiveVModel();
                m.ArchiveCode = item.cCusCode;
                m.ArchiveName = item.cCusName;
                m.FileID = item.AttachFileGUID;

                ls.Add(m);
            }

            return ls;

        }

    }
}
