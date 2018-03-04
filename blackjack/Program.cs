using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 1;

            while (op == 1)
            {
                Console.Clear();
                PilhaBaralho Baralho = new PilhaBaralho();

                Console.Write("JOGO DE CARTAS - 21");

                Console.Write("\n\nDigite seu nome jogador 1: ");
                Jogador jogador1 = new Jogador(Console.ReadLine());

                Console.Write("Digite seu nome jogador 2: ");
                Jogador jogador2 = new Jogador(Console.ReadLine());

                //Inicializando as mãos dos jogadores
                for (int i = 0; i < 2; i++)
                {
                    jogador1.Jogar(Baralho);
                    jogador2.Jogar(Baralho);
                }


                //Escolhendo aleatóriamente quem será o primeiro jogador a iniciar
                Random jogAleatorio = new Random();
                int JogInicia = jogAleatorio.Next(1, 3);

                int opcao, cont = 0;

                //Onde o jogo acontece
                //Se o cont for igual a 2 quer dizer que ambos jogadores já jogaram
                while (cont < 2)
                {
                    opcao = -1;

                    //Possibilita a jogada do jogador 1
                    if (cont < 2 && JogInicia == 1)
                    {
                        while (opcao != 0 && jogador1.somaMao() < 21)
                        {
                            Console.Clear();
                            Console.Write("Vez de " + jogador1.Nome);
                            jogador1.ImprimeMao();

                            Console.Write("\n\nAperte 1 para puxar uma carta do baralho ou 0 para parar: ");
                            opcao = int.Parse(Console.ReadLine());

                            if (opcao == 1)
                                jogador1.Jogar(Baralho);

                            if (opcao == 0 || jogador1.somaMao() > 21)
                            {
                                if (jogador1.somaMao() > 21)
                                {
                                    jogador1.ImprimeMao();
                                    Console.Write("\nVocê estourou a soma das cartas.  YOU LOSE!");
                                    //Se o jogador estourou o 21 o mesmo não poderá mais jogar, logo a opção recebe 0.
                                    opcao = 0;
                                    Console.ReadKey(true);
                                }
                                //jogInicia é alterado para 2 para que entre na condição do jogador 2 também jogar
                                JogInicia = 2;
                                cont++;
                            }
                        }
                    }

                    opcao = -1;

                    //Possibilita a jogada do jogador 2
                    if (cont < 2 && JogInicia == 2)
                    {
                        while (opcao != 0 && jogador2.somaMao() < 21)
                        {
                            Console.Clear();
                            Console.Write("Vez de " + jogador2.Nome);
                            jogador2.ImprimeMao();
                            Console.Write("\n\nAperte 1 para puxar uma carta do baralho ou 0 para parar: ");
                            opcao = int.Parse(Console.ReadLine());

                            if (opcao == 1)
                                jogador2.Jogar(Baralho);

                            if (opcao == 0 || jogador2.somaMao() > 21)
                            {
                                if (jogador2.somaMao() > 21)
                                {
                                    jogador2.ImprimeMao();
                                    Console.Write("\n\nVocê estourou a soma das cartas.  YOU LOSE!");
                                    opcao = 0;
                                    Console.ReadKey(true);
                                }
                                JogInicia = 1;
                                cont++;
                            }
                        }
                    }
                }

                //Verificando quem foi o vencedor da jogada
                Console.Clear();
                Console.Write("Resultado " + jogador1.Nome);
                jogador1.ImprimeMao();
                Console.Write("\n\nResultado " + jogador2.Nome);
                jogador2.ImprimeMao();
                if (jogador1.somaMao() > 21 && jogador2.somaMao() > 21)
                    Console.Write("\n\nNão houve um campeão no jogo! Cambada de nub!");
                else
                {
                    if (jogador1.somaMao() < jogador2.somaMao())
                        Console.Write("\n\n" + jogador1.Nome + " ganhou a rodada. " + jogador2.Nome + " seu(a) nub!");
                    else
                        Console.Write("\n\n" + jogador2.Nome + " ganhou a rodada. " + jogador1.Nome + " seu(a) nub!");
                }
                Console.Write("\n\n Aperte [1] Para jogar novamente ou [0] para sair: ");
                op = int.Parse(Console.ReadLine());
            }
        }
    }
}
