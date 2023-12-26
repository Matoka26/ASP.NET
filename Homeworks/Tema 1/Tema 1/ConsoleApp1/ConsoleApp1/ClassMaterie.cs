using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tema01
{
    internal class Materie
    {   
        public string numeMaterie { get; set; }
        public int nota { get; set; }
        public string durata { get; set; }
        public int nrCredite { get; set; }
        public Materie(string num = "Nu stiu" ,int  not = 0 ,string dur = "?" ,int nr = 0)
        {
            this.numeMaterie = num;
            this.durata = dur;
            this.nota = not;
            this.nrCredite = nr;
        }
      
    }
}
