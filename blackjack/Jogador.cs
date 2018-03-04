using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Jogador
    {
        public string Nome;
        public List<Carta> Mao;

        public Jogador(string Nome)
        {
            this.Nome = Nome;
            this.Mao = new List<Carta>();
        }

        public int somaMao()
        {
            int soma = 0;
            bool achou = false;
            foreach (Carta c in Mao)
                soma += c.ValorCarta;

            foreach (Carta c in Mao)
            {
                achou = (c.TipoCarta == "As");
                if (achou && soma <= 10)
                {
                    soma += 10;
                    Console.Write("\n\nVocê possui um Ás na mão que pode valer 1 ou 11, por hora ele está valendo 11.\n" +
                        "Caso retire mais uma carta e a soma da sua mão for maior que 11 ele passará a valer 1.\n");
                }
            }

            return soma;
        }

        public void Jogar(PilhaBaralho Baralho)
        {
            Mao.Add(Baralho.Desempilha());                     
        }

        public void ImprimeMao()
        {
            Console.Write("\nMão: ");
            foreach (Carta c in Mao)
                Console.Write(c.ValorCarta + " ");

            Console.Write("\nSoma: " + somaMao());

        }
    }
}
