using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
namespace API
{
         public interface IRoomsDataProvider
        {
            Task<IEnumerable<TblSalas>> GetRooms();
        }
}


