using System;
using System.Text;
using System.Collections.Generic;

namespace Calculadora
{ 

    class Program
    { 
    static void Main(string[] args)
    {
        double num1, num2;
        int resul = 0;

        Console.WriteLine("Digite um valor");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro valor");
        num2 = double.Parse(Console.ReadLine());

        Console.Clear();

        while (resul != 5)
        {
            Console.WriteLine(" + digite 1");
            Console.WriteLine(" - digite 2");
            Console.WriteLine(" / digite 3");
            Console.WriteLine(" * digite 4");
            Console.WriteLine(" digite 5 pra sair");
            resul = int.Parse(Console.ReadLine());
            if (resul == 1)
            {
                Console.WriteLine("Soma = {0}", num1 + num2);
            }
            if (resul == 2)
            {
                Console.WriteLine("Subtração = {0}", num1 - num2);
            }
            if (resul == 3)
            {
                Console.WriteLine("Divisão = {0}", num1 / num2);
            }
            if (resul == 4)
            {
                Console.WriteLine("Multiplicação = {0}", num1 * num2);

            }
            Console.ReadLine();
            Console.Clear();
        }
    }



    }

}