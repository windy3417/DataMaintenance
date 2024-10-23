using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMaintenance.Model.Maintenance
{
    [Table("UnitProductionCost")]
    public  class UnitProductionCost : IEquatable<UnitProductionCost>
    {

            public int Id { get; set; }
            public int iYear { get; set; }
            public string cMonth { get; set; }
            public string AccountNo { get; set; }
        

            public string cInvCode { get; set; }
            public string cInvName { get; set; }
            public string cInvStd { get; set; }
            public decimal? UnitCost { get; set; }

        public bool Equals(UnitProductionCost other)
        {
            if (other is null)
                return false;

            return  this.Id == other.Id && this.iYear == other.iYear && this.cMonth == other.cMonth && this.AccountNo == other.AccountNo && this.cInvCode == other.cInvCode && this.cInvName == other.cInvName && this.cInvStd == other.cInvStd && this.UnitCost == other.UnitCost;
        }

        public override bool Equals(object obj) => Equals(obj as UnitProductionCost);
        //public override int GetHashCode() => (Id, iYear,cMonth,AccountNo,cInvCode,cInvName,cInvStd,UnitCost).GetHashCode();
        public override int GetHashCode() => (Id).GetHashCode();



    }
}

