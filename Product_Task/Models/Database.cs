using Product_Task.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Product_Task.Models
{

    public class Database
    {
        SqlConnection conn;

        public Products Products { get; set; }

        public Database()
        {
            string connString = @"Server=DESKTOP-4P63PB7\SQLEXPRESS; Database=tempdb; Integrated Security=true ";
            conn = new SqlConnection(connString);
            Products = new Products(conn);
        }
    }
}