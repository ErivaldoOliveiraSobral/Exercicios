using System;
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
                Console.Write("Digite quantidade de alunos: ");
                int qtdAlunos = int.Parse(Console.ReadLine());

                int indice = 0;
                string nome;
                int nota;
                double media = 0;
                string[] nomes = new string[qtdAlunos];
                int[] notas = new int[qtdAlunos];

                do
                {
                    Console.Write("Digite nome do Aluno: ");
                    nomes[indice] = Console.ReadLine();
                    Console.Write("Digite nota do Aluno: ");
                    notas[indice] = int.Parse(Console.ReadLine());

                    indice++;

                } while (indice < qtdAlunos);

                foreach (int somaNotas in notas)
                {
                    media += somaNotas;
                }

                double medias = media / qtdAlunos;

                for (int x = 0;x < qtdAlunos;x++)
                {
                    if (notas[x] > medias)
                        Console.WriteLine("Aluno com nota acima da média: " + nomes[x]);
                }
            }

            void ex10()
            {
                ArrayList salarios = new ArrayList();
                double reajuste;
                Console.Write("Digite salário (-1 para sair): ");
                double valorDigitado = double.Parse(Console.ReadLine());

                if (valorDigitado != -1)
                {
                    do
                    {
                        salarios.Add(valorDigitado);
                        Console.Write("Digite salário (-1 para sair): ");
                        valorDigitado = double.Parse(Console.ReadLine());
                    } while (valorDigitado != -1);


                    Console.Write("Digite Reajuste (em %): ");
                    reajuste = double.Parse(Console.ReadLine());


                    foreach (double valoresReajustados in salarios)
                    {
                        double valor = valoresReajustados / 100 * reajuste + valoresReajustados;
                        Console.WriteLine("R$" + valor);
                    }
                }
            }

            Console.WriteLine("1 - Calcular e imprimir a soma dos números naturais de 1 ao 100: ");
            ex1();
            Console.WriteLine();
            Console.WriteLine("2 - Imprimir os múltiplos de 7 menores que 200: ");
            ex2();
            Console.WriteLine();
            Console.WriteLine("3 - Calcular e imprimir os números divisíveis por 4 menosres que 100: ");
            ex3();
            Console.WriteLine();
            Console.WriteLine("4 - Implementar");
            ex4();
            Console.WriteLine();
            Console.WriteLine("5 - Imprimir a tabuada do número 5 utilizando os 2 tipos de estrutura de repetição FOR e WHILE: ");
            ex5();
            Console.WriteLine();
            Console.WriteLine("6 - Imprima a tabuada de qualquer número fornecido pelo usuário. " +
                "Para finalizar utilize o número -1. (Utilize os 2 tipos de repetição: WHILE e FOR: ");
            ex6();
            Console.WriteLine();
            Console.WriteLine("7 - Implementar");
            ex7();
            Console.WriteLine();
            Console.WriteLine("8 - Implementar");
            ex8();
            Console.WriteLine();
            Console.WriteLine("9 - Leia um conjunto de alunos, cada uma com o nome e a nota. " +
                "Em seguida exiba o nome dos alunos que possuem a nota maior do que a média da turma");
            ex9();
            Console.WriteLine();
            Console.WriteLine("10 - Leia um conjunto de salários, sendo que para terminar a entrada será fornecido o valor -1. " +
                "Após toda a entrada ter sido realizada, leia o valor de um reajuste.Em seguida exiba todos os " +
                "salários já reajustados");
            ex10();

            Console.ReadKey();
        }
    }
}
