using System;
using System.Collections;

namespace programa_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando o arraylist e instanciando os dois primeiros elementos da seqûência de fibonacci
            ArrayList fibonacci = new ArrayList();
            fibonacci.Add(0);
            fibonacci.Add(1);


            Console.WriteLine("Olá, seja bem vindo ao programa de Fibonacci \n");
            Console.WriteLine("Digite um número inteiro para verifica-lo se está na sequência de Fibonacci: ");

            string number = Console.ReadLine();

            //Verifica se o número digitado é um inteiro
            bool isNumeric = int.TryParse(number, out int n);
            if (isNumeric == false)
            {
                Console.WriteLine("\n!!! Você não digitou um número, tente novamente por favor !!! \n\n");
                return;
            }
                

            for (int i = 0; (int)fibonacci[i] <= n; i++)
            {
                if(i >= 1)//a parti daqui já tem o número de elemenbtos mínumos para a verificação
                {
                    int soma = (int)fibonacci[i] + (int)fibonacci[i-1];
                    fibonacci.Add(soma);
                }
            }            
            
            fibonacci.RemoveAt(fibonacci.Count-1);//Remove o último elemento que sempre passa da um valor da lista

            //verifica se o número digitado está na sequência de fibonacci
            for (int i = 0; i < fibonacci.Count; i++)
            {
                if((int)fibonacci[i] == n)
                {
                    Console.WriteLine("\nO número digitado: " + n + " está na sequência de fibonacci");
                    return;
                }
            }

            Console.WriteLine("\nO número digitado: " + n + " não está na sequência de fibonacci");
            Console.ReadLine();

        }
    }
}
