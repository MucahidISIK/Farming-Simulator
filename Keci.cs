using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmingSimulator
{
    class Keci : Hayvan
    {
        private int sutVermeSuresi;

        public int SutVermeSuresi
        {
            get { return sutVermeSuresi; }
            set { sutVermeSuresi = value; }
        }

        public Keci(int _sutVermeSuresi, int _enerjiTuketimi) : base(_enerjiTuketimi)
        {
            sutVermeSuresi = _sutVermeSuresi;
        }

        public int EnerjiAzalt(int enerji)
        {
            enerji -= base.EnerjiTuketimi;
            return enerji;
        }
    }
}
