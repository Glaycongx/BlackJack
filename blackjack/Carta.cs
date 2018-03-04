using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Carta
    {
        public string TipoCarta;
        public int ValorCarta;
        public int img;

        public Carta(int ValorCarta, int img)
        {
            this.ValorCarta = ValorCarta;
            this.img = img;
            this.TipoCarta = null;
        }

        public Carta(int ValorCarta, string TipoCarta, int img)
        {
            this.TipoCarta = TipoCarta;
            this.ValorCarta = ValorCarta;
            this.img = img;
        }

      
    }
}
