using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaidaDeDados
{
    internal class Loops
    {
        public void MetodosLoops()
        {
            Console.WriteLine("COMEÇO LOOPS");

            RepetSenha();
            Coordenadas();
            Fatorial();
            LinhasAteN();


            Console.WriteLine("FIM");
        }

        #region RepetSenha
        static void RepetSenha()
        {
            Console.WriteLine($"Qual é a senha para repetir?");

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
        #endregion

        #region Coordenadas
        static void Coordenadas()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }

        }
        #endregion

        #region Fatorial
        static void Fatorial()
        {

            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }

            Console.WriteLine(fat);
        }

        #endregion

        #region LinhasAteN
        static void LinhasAteN()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
        }
        #endregion

    }
}
