using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorSemaforo
{
    public class ProcessoInput : Processo
    {

        /// metodo feito para preencher a lista
        public override void executaAcao(RAM ram)
        {

            Random valor = new Random();

            if (ram.fim == 1000)
            {            
                    ram.fim = 0;
            }
            if (ram.espCritico[ram.fim] != 0)
            {
                    Console.Write("Area Critica Cheia");
                    return;
            }


            for (int i = 0 ; i <  base.quantidadeBlocosAcao ; ++i)
            {
                var aux = valor.Next(1, 101);
                ram.inserir(aux);
                Console.Write("Inseriu:{0}\n", Convert.ToString(aux));
            }
           
        }
    }
}
