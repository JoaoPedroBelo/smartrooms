using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.DataProvider;
namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private IRoomsDataProvider RoomsDataProvider;

        public RoomsController(IRoomsDataProvider RoomsDataProvider)
        {
            this.RoomsDataProvider = RoomsDataProvider;
        }


        [HttpGet]
        public async Task<IEnumerable<TblSalas>> Get()
        {
            return await this.RoomsDataProvider.GetRooms();
        }
    }
}