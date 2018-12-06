using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TblOcupacao
    {
        public int Id { get; set; }
        public decimal Taxa { get; set; }
        public DateTime Time { get; set; }
        public int TblSalasId { get; set; }

        public TblSalas TblSalas { get; set; }
    }
}
