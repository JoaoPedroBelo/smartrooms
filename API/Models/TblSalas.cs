using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TblSalas
    {
        public TblSalas()
        {
            TblAccountHasTblSalas = new HashSet<TblAccountHasTblSalas>();
            TblEventos = new HashSet<TblEventos>();
            TblOcupacao = new HashSet<TblOcupacao>();
        }

        public int Id { get; set; }
        public string NomeSala { get; set; }
        public int Capacidade { get; set; }
        public string Color { get; set; }

        public ICollection<TblAccountHasTblSalas> TblAccountHasTblSalas { get; set; }
        public ICollection<TblEventos> TblEventos { get; set; }
        public ICollection<TblOcupacao> TblOcupacao { get; set; }
    }
}
