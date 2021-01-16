using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmingSimulator
{
    // Hayvan class'i abstract olarak belirleniyor
    abstract class Hayvan
    {
        private int enerjiTuketimi;

        public int EnerjiTuketimi
        {
            get { return enerjiTuketimi; }
            set { enerjiTuketimi = value; }
        }

        public Hayvan(int _enerjiTuketimi)
        {
            enerjiTuketimi = _enerjiTuketimi;
        }
        //interface kullanılıyor
        public interface IHayvan
        {
            int EnerjiAzalt(int enerji);
        }
    }
}
