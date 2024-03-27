using System.ComponentModel.Design;
using System.Numerics;

namespace RoboTupiniquimConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                //string opcao = Menu();

                //VerificaOpcaoDoMenu(opcao);

                //int largura = 0;
                //int comprimento = 0;

                //LerDadosDaArea(ref largura, ref comprimento);

                //int linhaRoboUm = 0;
                //int colunaRoboUm = 0;
                //char direcaoRoboUm = ' ';

                //int linhaRoboDois = 0;
                //int colunaRoboDois = 0;
                //char direcaoRoboDois = ' ';

                //LerEntradasDoRoboUm(ref linhaRoboUm, ref colunaRoboUm, ref direcaoRoboUm);

                //LerEntradasDoRoboDois(ref linhaRoboDois, ref colunaRoboDois, ref direcaoRoboDois);

                ////////////////////////////////////////////////////////////////
                Console.WriteLine("Entre com as informações da área do terreno!");
                Console.Write("Largura: ");
                int largura = int.Parse(Console.ReadLine());
                Console.Write("Comprimento: ");
                int comprimento = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Entre com as cordenadas da posição inicial do robô!");
                Console.Write("linha: ");
                int linha = int.Parse(Console.ReadLine());

                Console.Write("coluna: ");
                int coluna = int.Parse(Console.ReadLine());

                Console.Write("Direção do robô: ");
                char direcao = char.Parse(Console.ReadLine());

                Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Informações do terreno: " + largura + " X " + comprimento + ".");
                Console.WriteLine();

                Console.WriteLine("Informações da posição inicial do robô: " + linha + ", " + coluna + ", " + direcao);


                Console.WriteLine("Digite o comando que o robô deve xecutar!");
                Console.Write("Comando: ");
                string comando = Console.ReadLine();

                for (int i = 0; i < comando.Length; i++)
                {
                    Console.Write(comando[i]);
                }

                Console.WriteLine();
                Console.Write(comando.Length);
                Console.WriteLine();

                for (int i = 0; i < comando.Length; i++)
                {
                    if (comando[i] == 'e')
                    {
                        if (direcao == 'n')
                        {
                            direcao = 'o';
                        }
                        else if (direcao == 'o')
                        {
                            direcao = 's';
                        }
                        else if (direcao == 's')
                        {
                            direcao = 'l';
                        }
                        else if (direcao == 'l')
                        {
                            direcao = 'n';
                        }
                    }
                    if (comando[i] == 'd')
                    {
                        if (direcao == 'n')
                        {
                            direcao = 'l';
                        }
                        else if (direcao == 'l')
                        {
                            direcao = 's';
                        }
                        else if (direcao == 's')
                        {
                            direcao = 'o';
                        }
                        else if (direcao == 'o')
                        {
                            direcao = 'n';
                        }
                    }
                    if ( (comando[i] == 'm') && (direcao == 'n') )
                    {
                        coluna++;
                    }
                    if ( (comando[i] == 'm') && (direcao == 's') )
                    {
                        coluna--;
                    }
                    if ( (comando[i] == 'm') && (direcao == 'l') )
                    {
                        linha++;
                    }
                    if ((comando[i] == 'm') && (direcao == 'o'))
                    {
                        linha--;
                    }
                }

                Console.WriteLine("Informações da posição final do robô: " + linha + ", " + coluna + ", " + direcao);

                Console.ReadLine();
            }

    //        #region Menu
    //        static string Menu()
    //        {
    //            Console.Clear();
    //            Console.WriteLine("PROGRAMA ROBÔ TUPINIQUIM");
    //            Console.WriteLine();
    //            Console.WriteLine("Digite 'S' para sair!");
    //            Console.WriteLine("Digite 'C' para continuar!");
    //            Console.Write("Opção: ");
    //            string opcao = Console.ReadLine();
    //            Console.WriteLine();

    //            return opcao;
    //        }
    //        #endregion

    //        #region Verifica opção do menu
    //        static void VerificaOpcaoDoMenu(string opcao)
    //        {
    //            while ( (opcao != "S") && (opcao != "s") && (opcao != "C") && (opcao != "c") )
    //            {
    //                Console.WriteLine("Opção inválida...");
    //                Console.WriteLine();

    //                Console.WriteLine("Por favor digite novamente!");
    //                Console.Write("Opção: ");
    //                opcao = Console.ReadLine();
    //            }
    //            if ( (opcao == "S") && (opcao == "s") )
    //            {
    //                if (ConfirmaSaida())
    //                    Environment.Exit(0);
    //            }
    //        }
    //        #endregion

    //        #region Confirmação para sair do sistema
    //        static bool ConfirmaSaida()
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Deseja mesmo sair do sistema?");
    //            Console.WriteLine("Digite 'S' para sair!");
    //            Console.WriteLine("Digite 'C' para continuar!");
    //            Console.Write("Opção: ");
    //            string opcao = Console.ReadLine();

    //            while ((opcao != "S") && (opcao != "s") && (opcao != "C") && (opcao != "c"))
    //            {
    //                Console.WriteLine("Opção inválida...");
    //                Console.WriteLine();

    //                Console.WriteLine("Por favor digite novamente!");
    //                Console.Write("Opção: ");
    //                opcao = Console.ReadLine();
    //            }
    //            if ((opcao == "S") && (opcao == "s"))
    //                return true;
    //            else
    //                return true;
    //        }
    //        #endregion

    //        #region Ler dados de entrada da área
    //        static void LerDadosDaArea(ref int largura, ref int comprimento)
    //        {
    //            string opcao;

    //            Console.WriteLine();
    //            Console.WriteLine("Por favor digite os dados da área: ");
    //            Console.Write("Largura: ");
    //            opcao = Console.ReadLine();
    //            largura = int.Parse(verificaOpcaoInteiro(opcao));

    //            Console.Write("Comprimento: ");
    //            opcao = Console.ReadLine();
    //            largura = int.Parse(verificaOpcaoInteiro(opcao));

    //        }
    //        #endregion

    //        #region Verifica se o valor de entrada passado em um string é um valor que equivale a um valor inteiro
    //        static string verificaOpcaoInteiro(string opcao){
    //            while (!int.TryParse(opcao, out var i))
    //            {
    //                Console.WriteLine("Valor de entrada inválido...");
    //                Console.WriteLine("Por favor digite um valor inteiro!");
    //                Console.WriteLine("Opção: ");
    //                opcao = Console.ReadLine();
    //            }
    //            return opcao;
    //        }
    //        #endregion

    //        static void LerEntradasDoRoboUm(ref int linhaRoboUm, ref int colunaRoboUm, ref char direcaoRoboUm)
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Entre com as cordenadas da posição inicial do robô 1!");
    //            Console.Write("linha: ");
    //            string linha = Console.ReadLine();
    //            linhaRoboUm = int.Parse(verificaOpcaoInteiro(linha));
                

    //            Console.Write("coluna: ");
    //            string coluna = Console.ReadLine();
    //            colunaRoboUm = int.Parse(verificaOpcaoInteiro(coluna));

    //            Console.Write("Direção do robô: ");
    //            string direcao = Console.ReadLine();
    //            linhaRoboUm = char.Parse(verificaOpcaoDirecao(direcao));
    //        }

    //        static string verificaOpcaoDirecao(string direcao)
    //        {
    //            while ((direcao != "N") && (direcao != "n") && (direcao != "S") && (direcao != "s") && (direcao != "L") && (direcao != "l") &&
    //                (direcao != "O") && (direcao != "o"))
    //            {
    //                Console.WriteLine("Valor de entrada inválido...");
    //                Console.WriteLine("Por favor digite outro valor!");
    //                Console.WriteLine("Para direção Norte digite 'n'!");
    //                Console.WriteLine("Para direção Sul digite 's'!");
    //                Console.WriteLine("Para direção Leste digite 'l'!");
    //                Console.WriteLine("Para direção Oeste digite 'o'!");
    //                Console.WriteLine("Opção: ");
    //                direcao = Console.ReadLine();
    //            }
    //            return direcao;
    //        }
        }
    }
}
