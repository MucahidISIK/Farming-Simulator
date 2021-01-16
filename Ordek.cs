using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmingSimulator
{
    class Ordek : Hayvan
    {
        private int yumurtlamaSuresi;

        public int YumurtlamaSuresi
        {
            get { return yumurtlamaSuresi; }
            set { yumurtlamaSuresi = value; }
        }

        public Ordek(int _yumurtlamaSuresi, int _enerjiTuketimi) : base(_enerjiTuketimi)
        {
            yumurtlamaSuresi = _yumurtlamaSuresi;
        }

        public int EnerjiAzalt(int enerji)
        {
            enerji -= base.EnerjiTuketimi;
            return enerji;
        }
    }
}
