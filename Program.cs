using System;

namespace pooMaiorIdade
{
    class Program
    {
        static void Main(string[]args)
        {
            Pessoa p1;
            Pessoa p2;
            Pessoa p3;

            Console.WriteLine("Determine qual é a pessoa mais velha");
            Console.WriteLine();

            Console.WriteLine("Nome da primeira pessoa: ");
            p1 = new Pessoa();
            p1.Nome = Console.ReadLine(); 
            Console.WriteLine("Idade da primeira pessoa: ");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nome da segunda pessoa: ");
            p2 = new Pessoa();
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade da segunda pessoa: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nome da terceira pessoa: ");
            p3 = new Pessoa();
            p3.Nome = Console.ReadLine();
            Console.WriteLine("Idade da terceira pessoa: ");
            p3.Idade = Convert.ToInt32(Console.ReadLine());

            if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p1.ExibirDados();
            }
            else
            {   
                {
                    if ((p2.Idade > p3.Idade) && (p2.Idade > p1.Idade))
                    {
                        p2.ExibirDados();
                    }

                    else
                    {
                        if((p3.Idade > p1.Idade) && (p3.Idade > p2.Idade))
                        {
                            Console.WriteLine("A pessoa mais velha é: ");
                            p3.ExibirDados();
                        }
                        else
                        {
                            Console.WriteLine("Todas as pessoas tem a mesma idade");
                        }
                    }
                }
                           
            }
             Console.ReadKey();

        }

    }
    

}
