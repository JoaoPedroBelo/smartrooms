using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TblAccount
    {
        public TblAccount()
        {
            TblAccountHasTblSalas = new HashSet<TblAccountHasTblSalas>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<TblAccountHasTblSalas> TblAccountHasTblSalas { get; set; }
    }
}
