using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMaintenance.Model.Maintenance
{
    [Table("UnitProductionCost")]
    public  class UnitProductionCost
    {

            public int Id { get; set; }
            public int iYear { get; set; }
            public string cMonth { get; set; }
            public string AccountNo { get; set; }
        

            public string cInvCode { get; set; }
            public string cInvName { get; set; }
            public string cInvStd { get; set; }
            public decimal? UnitCost { get; set; }


        
    }
}

