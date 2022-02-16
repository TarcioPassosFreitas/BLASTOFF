using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeLogica
{
    //Tarcio Passos Freitas
    internal class Program
    {
        public static int[,] array = new int[2,2] { { 10,20}, { 30,40} };
        static void Main(string[] args)
        {
            Console.WriteLine("1- Dada as idades I, J, K, X, Y. Faça um algoritmo para calcular a média das idades\n");

            // Resposta da Questão 1 do desafio
            Quest1 q = new Quest1(10, 20, 30, 40, 50);
            Console.WriteLine("A média das idades I, J, K, X e Y é: " + q.Media() + "\n");

            Console.WriteLine("============================================================================================");
            

            Console.WriteLine("2- Dada a distância A e o combustível gasto B, faça um algoritmo para calcular o consumo"
             + " médio\n");
            
            //Resposta da Questão 2 do desafio
            Quest2 q2 = new Quest2(180.0, 50);
            Console.WriteLine("O consumo médio é: " + q2.consumoMedio() + "\n");

            Console.WriteLine("============================================================================================");

            Console.WriteLine("3 - Dados três números (a, b, c), faça um algoritmo para mostrar o menor número\n");

            //Resposta da Questão 3 do desafio
            Quest3 q3 = new Quest3();
            //teste para a posição A
            Console.WriteLine("O menor número é: " + q3.MenorNumero(5,20,30));
            //teste para a posição B
            Console.WriteLine("O menor número é: " + q3.MenorNumero(20,10,30));
            //Teste para a a posição C
            Console.WriteLine("O menor número é: " + q3.MenorNumero(20,30,15) + "\n");

            Console.WriteLine("============================================================================================");

            Console.WriteLine("4 - Faça um algoritmo que converta a temperatura de C para F. Utilize a fórmula" +
                " C = (5/9)*(f-32)\n");

            //Resposta da Questão 4 do desafio
            Quest4 q4 = new Quest4(25);
            Console.WriteLine("A temperatura convertida é: " + q4.ConverteF() + "\n");

            Console.WriteLine("============================================================================================");

            Console.WriteLine("5 - Faça um algoritmo para apresentar se dois números são múltiplos\n");

            //Resposta da Questão 5 do desafio
            Quest5 q5 = new Quest5();
            //Teste para múltiplos
            q5.multiplos(2, 4);
            //Teste para não múltiplos
            q5.multiplos(4, 2);
            Console.WriteLine();

            Console.WriteLine("============================================================================================");

            Console.WriteLine("6 - Uma partida de futebol iniciou na hora A e terminou na hora B. Faça um algoritmo que" +
            " calcule o tempo que durou a partida\n");

            //Resposta da Questão 6 do desafio
            Quest6 q6 = new Quest6();
            System.DateTime inicio = new System.DateTime(2022, 2, 16, 8, 40, 0);
            System.DateTime fim = new System.DateTime(2022, 2, 16, 12, 25, 0);
            Console.WriteLine("A duração da partida foi de: " + q6.duracaoPartida(inicio, fim) + "\n");

            Console.WriteLine("============================================================================================");

            Console.WriteLine("7 - Dada uma lista de números A[1,2,3,…], faça um algoritmo que retorne uma lista somente" +
            " com os números pares\n");

            //Resposta da Questão 7 do desafio
            Quest7 q7 = new Quest7();
            q7.add(1);
            q7.add(2);
            q7.add(3);
            q7.add(4);
            q7.add(5);
            q7.add(6);
            Console.WriteLine("Os números pares são: ");
            foreach (double n in q7.numerosPares())
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            Console.WriteLine("============================================================================================");

            Console.WriteLine("8 - Faça um algoritmo que receba um número e retorne se o número é primo ou não\n");

            //Resposta da Questão 8 do desafio
            Quest8 q8 = new Quest8();
            if(q8.ePrimo(19) == true)
            {
                Console.WriteLine("É Primo!\n");
            }
            else
            {
                Console.WriteLine("Não é Primo!\n");
            }

            Console.WriteLine("============================================================================================");

            Console.WriteLine("9 - Faça um algoritmo que receba um número e retorne a tabuada desse número\n");

            //Resposta da Questão 9 do desafio
            Quest9 q9 = new Quest9();
            Console.WriteLine("A tabuada é: ");
            q9.tabuada(9);

            Console.WriteLine();

            Console.WriteLine("============================================================================================");

            Console.WriteLine("10 - Faça um algoritmo que receba um número e retorne o Fatorial desse número\n");

            //Resposta da Questão 10 do desafio
            Quest10 q10 = new Quest10();
            Console.WriteLine("O fatorial é igual a " + q10.Fatorial(14) + "\n");

            Console.WriteLine("============================================================================================");

            Console.WriteLine("11 - Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], faça um algoritmo que retorne a" +
            " intersecção das listas\n");

            //Resposta da Questão 11 do desafio
            Quest11 q11 = new Quest11();
            Console.WriteLine("Fazem parte da intersecção das listas: ");
            foreach(int n in q11.interseccao())
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            Console.WriteLine("============================================================================================");

            Console.WriteLine("12 - Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], faça um algoritmo que retorne a" +
            " concatenação das listas\n");

            //Resposta da Questão 12 do desafio
            Quest12 q12 = new Quest12();
            Console.WriteLine("A concatenação das lista resulta em: ");
            foreach (int k in q12.concatenacao())
            {
                Console.WriteLine(k);
            }
            Console.WriteLine();

            Console.WriteLine("============================================================================================");

            Console.WriteLine("13 - Faça um algoritmo que receba uma matriz[i,z] como parâmetro e imprima todos os" +
            " valores dessa matriz\n");

            //Resposta da Questão 13 do desafio
            Quest13 q13 = new Quest13();
            Console.WriteLine("A matriz é: ");
            q13.printMatriz(array);

            Console.WriteLine();

            Console.WriteLine("============================================================================================");

            Console.WriteLine("14 - Faça um algoritmo que recebe uma palavra e retorne se a palavra é palíndromo." +
            " (Palavra que se pode ler, indiferentemente, da esquerda para direita ou vice - versa.Ex: osso," +
            " Ana e etc)\n");

            //Resposta da Questão 14 do desafio
            Quest14 q14 = new Quest14();
            if (q14.ePalindromo("arara"))
            {
                Console.WriteLine("É Palíndromo");
            }else
            {
                Console.WriteLine("Não é Palíndromo");
            }



            Console.ReadLine();
        }
    }
}
