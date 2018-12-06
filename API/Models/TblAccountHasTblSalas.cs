using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TblAccountHasTblSalas
    {
        public int Id { get; set; }
        public int TblAccountId { get; set; }
        public int TblSalasId { get; set; }

        public TblAccount TblAccount { get; set; }
        public TblSalas TblSalas { get; set; }
    }
}
