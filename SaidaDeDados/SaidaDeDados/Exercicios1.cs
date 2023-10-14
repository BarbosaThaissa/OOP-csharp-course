using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaidaDeDados
{
    internal class Exercicios1
    {
        public void MetodosExercicio1()
        {
            Console.WriteLine("COMEÇO EXERCICIO 1");

            SomarDoisNumeros();
            QualERaio();
            DiferencaProduto();
            SalarioFun();
            Console.WriteLine("FIM");
        }

        #region SomarDoisNumeros
        static void SomarDoisNumeros()
        {

            Console.WriteLine("Escreva um numero:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro numero");
            int b = int.Parse(Console.ReadLine());
            var result = a + b;

            Console.WriteLine($"SOMA = {result}");
        }
        #endregion

        #region QualERaio
        static void QualERaio()
        {
            double pi = 3.14159;
            Console.WriteLine("Escreva o valor do raio: (double)");
            double raio = double.Parse(Console.ReadLine());
            double area = pi * (raio * raio);

            Console.WriteLine($"A = {area:F4}");
        }
        #endregion

        #region DiferencaProduto

        static void DiferencaProduto()
        {
            Console.WriteLine("Escreva um numero:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro numero:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro numero:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro numero:");
            int d = int.Parse(Console.ReadLine());

            int produto = (a * b) - (c * d);
            Console.WriteLine($"DIFERENÇA = {produto}");
        }
        #endregion

        #region SalarioFun
        static void SalarioFun()
        {
            Console.WriteLine($"Qual é o numero do funcionário?");
            int funNumero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual é o numero de horas trabalhadas?");
            int horasTrabalhas = int.Parse(Console.ReadLine());

            Console.WriteLine($"Quanto ele recebe por hora?");
            double valorHora = double.Parse(Console.ReadLine());

            double result = valorHora * horasTrabalhas;

            Console.WriteLine($"Number = {funNumero} \nSalary = U$ {result:F2}");
        }
        #endregion
    }
}
