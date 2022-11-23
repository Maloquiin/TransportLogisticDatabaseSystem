using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma
{
    //ClientSQL - класс для использования заглушек в классе DB 
    class ClientSQL
    {
        public string Name { get; set; }
        public string Cost_downtime { get; set; }
        public string Cost_mkad { get; set; }
        public string Stavka20 { get; set; }
        public string Stavka40 { get; set; }

        // Переменные для заглушек
        public ClientSQL(string name, string cost_downtime, string cost_mkad, string stavka20,string stavka40)
        {
            Name = name;
            Cost_downtime = cost_downtime;
            Cost_mkad = cost_mkad;
            Stavka20 = stavka20;
            Stavka40 = stavka40;
        }
    }
}
