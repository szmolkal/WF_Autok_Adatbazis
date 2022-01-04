using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Autok_Adatbazis
{
    class Auto
    {
        int id = 0;
        string rendszam = null;
        string gyartmany = null;
        string tipus = null;

        public Auto()
        {
        }

        public Auto(int id, string rendszam, string gyartmany, string tipus)
        {
            this.id = id;
            this.rendszam = rendszam;
            this.gyartmany = gyartmany;
            this.tipus = tipus;
        }

        public int Id { get => id; set => id = value; }
        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Gyartmany { get => gyartmany; set => gyartmany = value; }
        public string Tipus { get => tipus; set => tipus = value; }

        public override string ToString()
        {
            return id + " " + rendszam + " " + gyartmany + " " + tipus;
        }
    }
}
