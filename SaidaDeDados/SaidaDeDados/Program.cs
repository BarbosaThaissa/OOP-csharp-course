using System;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            SaidaDados();
            EntradaDados();

            Exercicios1 exercicios1 = new Exercicios1();
            exercicios1.MetodosExercicio1();
            
            Exercicios2 exercicios2 = new Exercicios2();
            exercicios2.MetodosExercicios2();

            Loops exerciciosLoops = new Loops();
            exerciciosLoops.MetodosLoops();
        }

        #region SaidaDados
        static void SaidaDados()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            string result = $"Produtos: \n{produto1}, cujo preço é {preco1} \n{produto2}, cujo preço é $ {preco2} \n\nRegistro: {idade} anos de idades, código {codigo} e gênero: {genero} \n\nMedida com oito casas decimais: {medida:F8} \nArredondado(três casas decimais): {medida:F3} \nSeparador decimal invariant culture: " + medida.ToString("F2", CultureInfo.InvariantCulture);

            Console.WriteLine(result);
        }
        #endregion

        #region EntradaDados
        static void EntradaDados()
        {
            Console.WriteLine("\nEntre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("\nQuantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com o proço de um produto:");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com seu último nome, idade e altura(mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');

            Console.WriteLine("\nOs dados que você escreveu foi:");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);
        }
        #endregion

    }
}