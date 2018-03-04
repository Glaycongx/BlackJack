using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class CelulaBaralho
    {
        public Carta carta;
        public CelulaBaralho Prox;

        public CelulaBaralho()
        {
            carta = null;
            Prox = null;
        }

        public CelulaBaralho(Carta valorCarta)
        {
            carta = valorCarta;
            Prox = null;
        }


        public CelulaBaralho(Carta valorCarta, CelulaBaralho ProxCelula)
        {
            carta = valorCarta;
            Prox = ProxCelula;
        }
    }
}
