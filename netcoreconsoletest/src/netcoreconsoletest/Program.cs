using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace netcoreconsoletest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            string connectionString = @"Data Source=XXX;Initial Catalog=SDB_Metabas;User Id=XXX;Password=XXX;";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {

                    var tables = conn.Query<MainTableC>("select * from MainTable");

                    foreach (var tbl in tables)
                    {
                        Console.WriteLine(tbl.MainTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }

    public class MainTableC
    {
        public string MainTable { get; set; }
        //public string Status { get; set; }
        //public string Text { get; set; }
        public string TableId { get; set; }

    }
}
