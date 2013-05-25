using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class ThamSoDAO
    {
        public static string CreateThamSoId()
        {
            return (string)DataProvider.ExecuteScalar("usp_CreateThamSoId");
        }
    }
}
