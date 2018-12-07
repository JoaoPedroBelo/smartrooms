using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TblEventos
    {
        public int Id { get; set; }
        public int Tipo { get; set; }
        public DateTime Time { get; set; }
        public int TblSalasId { get; set; }
        public int? OccupiedSeats { get; set; }
        public int? EmptySeats { get; set; }

        public TblSalas TblSalas { get; set; }
    }
}
