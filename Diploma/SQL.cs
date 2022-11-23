using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Diploma
{
    class SQL
    {
        MySqlConnection TKbd = new MySqlConnection("server=127.0.0.1;port=3306;username=admin;password=admin;database=auto");

        public void Start()
        {
            if (TKbd.State == System.Data.ConnectionState.Closed)
                TKbd.Open();
        }

        public void End()
        {
            if (TKbd.State == System.Data.ConnectionState.Open)
                TKbd.Close();
        }

        public MySqlConnection get()
        {
            return TKbd;
        }
    }
}
