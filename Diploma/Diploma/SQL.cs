using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Diploma
{
    //DrSQL - класс для подключения к базе данных 
    class SQL
    {
        MySqlConnection TKbd = new MySqlConnection("server=127.0.0.1;port=3306;username=admin;password=admin;database=auto");

        /*Функция для подключения 
        * Формальные параметры отсутствуют
        * Локальные переменные отсутствуют
        */
        public void Start()
        {
            if (TKbd.State == System.Data.ConnectionState.Closed)
                TKbd.Open();
        }

        /*Функция для отключения 
        * Формальные параметры отсутствуют
        * Локальные переменные отсутствуют
        */
        public void End()
        {
            if (TKbd.State == System.Data.ConnectionState.Open)
                TKbd.Close();
        }

        /*Функция для получения 
        * Формальные параметры отсутствуют
        * Локальные переменные отсутствуют
        */
        public MySqlConnection get()
        {
            return TKbd;
        }
    }
}
