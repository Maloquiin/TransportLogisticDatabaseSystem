using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma
{
    class AutoSQL
    {
        public string DateDel { get; set; }
        public string TypeDel { get; set; }
        public string NumCon { get; set; }
        public string Id_client { get; set; }
        public string Adress { get; set; }
        public string Zpu { get; set; }
        public string HoursPause { get; set; }
        public string Id_mkad { get; set; }
        public string OptAdress { get; set; }
        public string OverLoad { get; set; }
        public string Expe { get; set; }
        public string DateOplata { get; set; }
        public string Id_drivers { get; set; }

        public AutoSQL(string dateDel, string typeDel, string numCon, string id_client, string adress, 
            string zpu, string hoursPause, string id_mkad, string optAdress, string overLoad, string expe, string dateOplata, string id_drivers)
        {
            DateDel = dateDel;
            TypeDel = typeDel;
            NumCon = numCon;
            Id_client = id_client;
            Adress = adress;
            Zpu = zpu;
            HoursPause = hoursPause;
            Id_mkad = id_mkad;
            OptAdress = optAdress;
            OverLoad = overLoad;
            Expe = expe;
            DateOplata = dateOplata;
            Id_drivers = id_drivers;
        }
    }
}
