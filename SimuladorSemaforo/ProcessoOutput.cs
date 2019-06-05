using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorSemaforo
{
    public class ProcessoOutput : Processo
    {

        // No caso desta classe ela tira itens da lista
        public override void executaAcao(RAM ram)
        {
            // verificar se a ram esta cheia
           if(ram.espCritico[ram.inicio] == 0)
            {
                Console.Write("Area Critica Vazia\n");
                return;
            }

            for (int i = 0; i < base.quantidadeBlocosAcao; ++i)
            {
                var aux = Convert.ToString(ram.espCritico[ram.inicio]);
                Console.Write("Removeu: {0}\n",aux);
                ram.remover();
            }
        }
    }
}
