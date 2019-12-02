using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distancia_entre_pontos
{
    class dist
    {
        private double _x1, _x2, _y1, _y2;

        public string PontoX1 { set => _x1 = Convert.ToDouble(value); }
        public string PontoX2 { set => _x2 = Convert.ToDouble(value); }
        public string PontoY1 { set => _y1 = Convert.ToDouble(value); }
        public string PontoY2 { set => _y2 = Convert.ToDouble(value); }


        public string Pontos => (Math.Sqrt((_x2 - _x1) * (_x2 - _x1) + (_y2 - _y1) * (_y2 - _y1))).ToString();

    }
}
