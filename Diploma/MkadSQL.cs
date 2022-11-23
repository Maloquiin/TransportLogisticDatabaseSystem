using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma
{
    class MkadSQL
    {
        public string Taking { get; set; }
        public string Setting { get; set; }
        public string Mkad_km { get; set; }


        public MkadSQL(string taking, string setting, string mkad_km)
        {
            Taking = taking;
            Setting = setting;
            Mkad_km = mkad_km;
        }
    }
}
