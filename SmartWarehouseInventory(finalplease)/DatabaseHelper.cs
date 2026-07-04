using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace SmartWarehouseInventory_finalplease_
{
   class DatabaseHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                @"Data Source=(localdb)\MSSQLLocalDB;
                Initial Catalog=WarehouseDB;
                Integrated Security=True;");
        }
    }
}
