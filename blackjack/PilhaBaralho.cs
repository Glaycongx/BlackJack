using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class PilhaBaralho
    {
        public CelulaBaralho Topo = null;
        public int Qtde = 0;


        public PilhaBaralho()
        {
            Carta[] vetorCarta = new Carta[52] {new Carta(1,"As", 0),new Carta(1,"As", 0),new Carta(1,"As", 0),new Carta(1,"As", 0),new Carta(2, 0),
            new Carta(2,0), new Carta(2, 0), new Carta(2, 0), new Carta(3, 0), new Carta(3, 0), new Carta(3, 0), new Carta(3, 0), new Carta(4, 0),
            new Carta(4,0), new Carta(4, 0), new Carta(4, 0), new Carta(5, 0),new Carta(5, 0), new Carta(5, 0),new Carta(5, 0),new Carta(6, 0),
            new Carta(6,0), new Carta(6, 0),new Carta(6, 0),new Carta(7, 0),new Carta(7, 0), new Carta(7, 0),new Carta(7, 0),new Carta(8, 0),
            new Carta(8,0), new Carta(8, 0),new Carta(8, 0),new Carta(9, 0),new Carta(9, 0), new Carta(9, 0),new Carta(9, 0),new Carta(10, 0),
            new Carta(10,0), new Carta(10, 0),new Carta(10, 0),new Carta(10, 0),new Carta(10, 0), new Carta(10, 0),new Carta(10, 0),new Carta(10, 0),
            new Carta(10,0),new Carta(10, 0),new Carta(10, 0),new Carta(10, 0),new Carta(10, 0), new Carta(10, 0),new Carta(10, 0)};

            Embaralha(vetorCarta);

        }


        public void Empilha(Carta ValorCarta)
        {
            Topo = new CelulaBaralho(ValorCarta, Topo);
            Qtde++;
        }


        public Carta Desempilha()
        {
            Carta Item = null;
            if (Topo != null)
            {
                Item = Topo.carta;
                Topo = Topo.Prox;
                Qtde--;
            }
            return Item;
        }

        public bool Contem(string tipoCarta) { 
        
            bool achou = false;
            CelulaBaralho aux = Topo;
            while (aux != null && !achou)
            {
                achou = aux.carta.TipoCarta.Equals(tipoCarta);
                aux = aux.Prox;
            }
            return achou;
        }

        public void imprimir()
        {
            CelulaBaralho aux = Topo;
            while (aux != null)
            {
                Console.Write(aux.carta.ValorCarta + " ");
                aux = aux.Prox;
            }
        }

        public void Embaralha(Carta[] vetorCarta)
        {
            Random aleatorio = new Random();
            int pos, cont = 51;
            Carta aux;


            for (int i = 0; i < 52; i++)
            {
                pos = aleatorio.Next(0, cont);
                Empilha(vetorCarta[pos]);
                aux = vetorCarta[pos];
                vetorCarta[pos] = vetorCarta[cont];
                vetorCarta[cont] = aux;
                cont--;
            }
        }
    }
}

