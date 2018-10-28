using System;

using System.Collections.Generic;

using System.Text;



namespace Calculadora

{
    public class CalculadoraSimples
    {

        public double Soma(double num1, double num2)
        {
            double soma;
            soma = num1 + num2;
            return soma;
        }

        public double Subtracao(double num1, double num2)
        {
            double subtracao;
            subtracao = num1 - num2;
            return subtracao;
        }

        public double Divisao(double num1, double num2)
        {
            double divisao;
            divisao = num1 / num2;
            return divisao;
        }

        public double Multiplicacao(double num1, double num2)
        {
            double multiplicacao;
            multiplicacao = num1 * num2;
            return multiplicacao;
        }




    }


    class Program

    {

        static void Main(string[] args)

        {
            CalculadoraSimples calculadora = new CalculadoraSimples();
            double num1, num2;

            int resul = 0;


            Console.WriteLine("Digite o primeiro numero");

            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");

            num2 = double.Parse(Console.ReadLine());



            Console.Clear();



            while (resul != 5)

            {
                Console.WriteLine("SELECIONE QUAL OPERAÇÃO DESEJA EFETUAR:");

                Console.WriteLine("1. Somar");

                Console.WriteLine("2. Subtrair");

                Console.WriteLine("3. Dividir");

                Console.WriteLine("4. Multiplicar");

                Console.WriteLine("5. Sair");

                resul = int.Parse(Console.ReadLine());

                if (resul == 1)

                {

                    Console.WriteLine("Soma = {0}", calculadora.Soma(num1, num2));

                }

                if (resul == 2)

                {

                    Console.WriteLine("Subtração = {0}", calculadora.Subtracao(num1, num2));

                }

                if (resul == 3)

                {

                    Console.WriteLine("Divisão = {0}", calculadora.Divisao(num1, num2));

                }

                if (resul == 4)

                {

                    Console.WriteLine("Multiplicação = {0}", calculadora.Multiplicacao(num1, num2));

                }

                Console.ReadLine();

                Console.Clear();

            }

        }

    }

}