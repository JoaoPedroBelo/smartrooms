using System;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using System.Data;

namespace API.DataProvider
{
    public class RoomsDataProvider: IRoomsDataProvider
    {
        private readonly string connectionString = "Server=smartroomsdbserver.database.windows.net;Database=smartrooms_db;UID=smartrooms @smartroomsdbserver; PWD=SDgrupo3_projecto;";
        private SqlConnection sqlConnection;

        public async Task<IEnumerable<TblSalas>> GetRooms()
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.OpenAsync();
                return await sqlConnection.QueryAsync<TblSalas>(
                    "Select_All_Rooms",
                    null,
                    commandType: CommandType.StoredProcedure);
            }
        }


    }
}
