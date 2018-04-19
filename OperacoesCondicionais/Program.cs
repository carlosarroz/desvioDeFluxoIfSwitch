using System;

namespace OperacoesCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //comentario in-line(em linha) 
            /*
                comentario in-block(em bloco)
             */
            //declaração da variavel operação. Ela séra do tipo inteira

            int operacao;

            //declaração das variaveis n1 e n2. Elas serão do tipo double 

            double n1, n2;

            /*
                Para limpar a tela de comando a cada execução, utilizaremos o comando Console.Clear();
                obs.: Clear -> Limpar
             */

             Console.Clear(); 
             Console.WriteLine("Escolha umas das operações a baixo:");
             
             /*
                Para a exibição das opções de operações, vamos usar o comando Console.Writeline e , nele usaremos um comando de quebra de linha
                 \n(contra-barra n (new line)).
                assim, as opções ficarão uma abaixo da outra             
              */

                Console.WriteLine("1-soma\n2-subtrair\n3-multiplicar\n4-dividir");
                operacao = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite um numero");
                n1 = double.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite outro numero");
                n2 = double.Parse(Console.ReadLine());
                
                if(operacao==1)
                {
                    Console.WriteLine("O resultado da soma é:"+(n1+n2));
                    }
                else if (operacao==2)
                {
                    Console.WriteLine("O resultado da subtração é:"+(n1-n2));
                }
                else if (operacao==3)
                {
                    Console.WriteLine("O resultado da multiplicação é"+(n1*n2));
                }
                else if (operacao==4)
                {
                    Console.WriteLine("O resultado da divisão é:"+(n1/n2));
                }    
                else 
                {
                    Console.WriteLine("Operação invalida!");
                }
        }
    }
}
