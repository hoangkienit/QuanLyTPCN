using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DTAC_QuanLy
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=LAPTOP-PG6UI4J3\\SQLEXPRESS;Initial Catalog=StockManagement;Integrated Security=True");
    }
}
