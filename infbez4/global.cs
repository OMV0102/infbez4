using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Security.Cryptography;

namespace infbez4
{
    public static class global
    {
        public static string connectionString = "Host=students.ami.nstu.ru;Port=5432;Database=students;User Id=pmi-b6602;Password=ekNonuc1;";
        //==============================
        public static int loginCount;
        public static int loginMaxCount;
        public static bool canLogin;
        //===============================
        public static int loginMaxLength = 20;
        //===============================
        //public static string searchDefault = "google.com";
        public static string searchDefault = "yandex.ru";
    }
}
