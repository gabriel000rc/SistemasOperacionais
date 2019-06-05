using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorSemaforo
{
    class Program
    {
        static void Main(string[] args)
        {
            RAM ram = new RAM();
            var r = new Random();
            Processo[] processos = new Processo[10];

            /// CONTAR AS 200 VEZES 
            for (int contador = 0; contador < 200; ++contador)
            {
                /// Cria processos e adiciona no Aray
                for(int i = 0; i < 5; ++i)
                {
                    var aux = new ProcessoInput();
                    processos[i] = aux;
                }
                for (int i = 5; i < 10; ++i)
                {
                    var aux2 = new ProcessoOutput();
                    processos[i] = aux2;
                }


                /// DEIXAR OS 10 PROCESSOS ALEATORIO
                for (int i = 0; i < 10; i++)
                {
                    var j = r.Next(10);
                    var obj = processos[j];
                    processos[j] = processos[i];
                    processos[i] = obj;
                }

                /// Executa os Processos 
                for (int i = 0;i < 10; ++i)
                {
                    Console.Write("\nCarga[{0}] Processo [{1}]\n", contador + 1, i + 1);
                    var aux = processos[i];
                    aux.executaAcao(ram);
                                                    
                }


                
                
            }
            ram.imprimir();
            Console.Read();
        }
    }
}
