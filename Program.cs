using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 17 ;
            int acompanhado = 1;
            double valor;
        
            //Caso seja maior de idade tera a entrada liberada, e ja imprime o valor.
            if(idade >= 18){
                valor = 20.00;
                Console.WriteLine("Maior de idade esta liberado, valor da entrada " + valor);
            }
            // Se não executa esse bloco de código onde fara as comparações.
            else{
                Console.WriteLine("Somente acompanhado você podera entrar!");

                if(acompanhado != 1){
                Console.WriteLine("Infelismente não poderá entrar!");
                }

                else{
                valor = 40.00;
                Console.WriteLine("Está liberado para entrar, valor da entrada " + valor);
                }

            }

           
        }
    }
}
