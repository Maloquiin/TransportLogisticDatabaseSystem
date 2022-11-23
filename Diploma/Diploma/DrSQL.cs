using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma
{
    //DrSQL - класс для использования заглушек в классе DB 
    class DrSQL
    {
        public string NameD { get; set; }

        // Переменные для заглушек
        public DrSQL(string named)
        {
            NameD = named;
        }
    }
}
