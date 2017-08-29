﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            void ex1()
            {
                double soma = 0;

                for (int num = 0; num <= 100; num++)
                {
                    soma += num;
                }

                Console.WriteLine(soma);
            }

            void ex2()
            {
                for(int num = 7 ; num <= 200 ; num += 7)
                {
                    Console.WriteLine(num);
                }
            }

            void ex3()
            {
                int soma = 0;

                for (int num = 1 ; num < 100 ; num++)
                {
                    if (num % 4 == 0)
                    {
                        soma += num;
                    }
                }

                Console.WriteLine(soma);
            }

            void ex4 ()
            {
                //implementar
            }

            void ex5()
            {
                int[] array = new int[10];
                int num = 5;

                //Array com o resultado da tabuada do 5
                for (int contador = 1;contador <= 10;contador++)
                {
                    array[contador - 1] = num * contador;
                }

                //Estrutura de repetição FOR
                Console.WriteLine("Estrutura de repetição FOR: ");
                for (int contador = 1;contador <= 10;contador++)
                {
                    Console.WriteLine(num + "*" + contador + "=" + array[contador - 1]);
                }

                //Estrutura de repetição WHILE
                Console.WriteLine("Estrutura de repetição WHILE: ");

                int count = 1;

                while (count <= 10)
                {
                    Console.WriteLine(num + "*" + count + "=" + array[count - 1]);
                    count++;
                }
            }

            void ex6()
            {
                int num;
                int[] array = new int[10];

                Console.Write("Digite número (-1 para sair): ");
                num = int.Parse(Console.ReadLine());
                
                while (num != -1)
                {
                    //Array com o resultado da tabuada
                    for (int contador = 1; contador <= 10; contador++)
                    {
                        array[contador - 1] = num * contador;
                    }

                    //Estrutura de repetição FOR
                    Console.WriteLine("Estrutura de repetição FOR: ");
                    for (int contador = 1; contador <= 10; contador++)
                    {
                        Console.WriteLine(num + "*" + contador + "=" + array[contador - 1]);
                    }

                    //Estrutura de repetição WHILE
                    Console.WriteLine("Estrutura de repetição WHILE: ");

                    int count = 1;

                    while (count <= 10)
                    {
                        Console.WriteLine(num + "*" + count + "=" + array[count - 1]);
                        count++;
                    }

                    Console.Write("Digite número (-1 para sair): ");
                    num = int.Parse(Console.ReadLine());
                }
            }

            void ex7()
            {
                //implementar
            }

            void ex8()
            {
                //implementar
            }

            void ex9()
            {
                //implementar
            }

            void ex10()
            {
                //implementar
            }

            Console.WriteLine("Calcular e imprimir a soma dos números naturais de 1 ao 100: ");
            ex1();
            Console.WriteLine("Imprimir os múltiplos de 7 menores que 200: ");
            ex2();
            Console.WriteLine("Calcular e imprimir os números divisíveis por 4 menosres que 100: ");
            ex3();
            Console.WriteLine("Imprimir a tabuada do número 5 utilizando os 2 tipos de estrutura de repetição FOR e WHILE: ");
            ex5();
            Console.WriteLine("Imprima a tabuada de qualquer número fornecido pelo usuário. Para finalizar utilize o número -1. (Utilize os 2 tipos de repetição: WHILE e FOR: ");
            ex6();

            Console.Read();
        }
    }
}
