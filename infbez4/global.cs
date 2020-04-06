using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace infbez4
{
    public static class global
    {
        public static string connectionString = "Host=students.ami.nstu.ru;Port=5432;Database=students;User Id=pmi-b6602;Password=ekNonuc1;";
        public static NpgsqlConnection conn;
    }
}
