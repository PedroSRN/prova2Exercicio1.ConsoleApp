using System;

namespace prova2Exercicio1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int i = 0;
            string comandos = "DDE";
            char direcao = 'N';
            char[]instrucoes = comandos.ToCharArray();

            int j = 0;
            string comandos2 = "EE";
            char direcao2 = 'N';
            char[] instrucoes2 = comandos2.ToCharArray();

            //int numeroDeComandos = instrucoes.Length;

            #region primeira posição do soldado

            for ( i = 0; i < instrucoes.Length; i++)
            {
                if (instrucoes[i] == 'D') //virar a Direita
                {
                    if (direcao == 'N')
                    {
                        direcao = 'L';
                    }

                    else if (direcao == 'S')
                    {
                        direcao = 'O';
                    }

                    else if (direcao == 'O')
                    {
                        direcao = 'N';
                    }

                    else if (direcao == 'L')
                    {
                        direcao = 'S';
                    }
                }

                if (instrucoes[i] == 'E')
                {
                    if (direcao == 'N')
                    {
                        direcao = 'O';
                    }

                    else if (direcao == 'S')
                    {
                        direcao = 'L';
                    }

                    else if (direcao == 'O')
                    {
                        direcao = 'S';
                    }

                    else if (direcao == 'L')
                    {
                        direcao = 'N';
                    }
                }

            }
            #endregion

            #region segunda posição do soldado

            for (j = 0; j < instrucoes2.Length; j++)
            {
                if (instrucoes2[j] == 'D') //virar a Direita
                {
                    if (direcao2 == 'N')
                    {
                        direcao2 = 'L';
                    }

                    else if (direcao2 == 'S')
                    {
                        direcao2 = 'O';
                    }

                    else if (direcao == 'O')
                    {
                        direcao2 = 'N';
                    }

                    else if (direcao2 == 'L')
                    {
                        direcao2 = 'S';
                    }
                }

                if (instrucoes2[j] == 'E')
                {
                    if (direcao2 == 'N')
                    {
                        direcao2 = 'O';
                    }

                    else if (direcao2 == 'S')
                    {
                        direcao2 = 'L';
                    }

                    else if (direcao2 == 'O')
                    {
                        direcao2 = 'S';
                    }

                    else if (direcao2 == 'L')
                    {
                        direcao2 = 'N';
                    }
                }

            }
            #endregion
            Console.WriteLine("");
            Console.WriteLine("Numero de comandos passados pelo sargento é de: " + i);
            Console.WriteLine("Posiçao atual do soldado é " + direcao);
            Console.WriteLine("");
            Console.WriteLine("Numero de comandos passados pelo sargento é de: " + j);
            Console.WriteLine("Posiçao atual do soldado é " + direcao2);

            Console.ReadLine();
        }
    }
}
