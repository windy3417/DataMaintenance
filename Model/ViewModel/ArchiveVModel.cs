using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataMaintenance.Model.ViewModel
{
  public  class ArchiveVModel
    {
        public string ArchiveCode { get; set; }
        public string ArchiveName { get; set; }

        public string ArchiveMarsterName { get; set; }


        public string Describe { get; set; }
        public Guid AttachFileGUID { get; set; }

    }
}
