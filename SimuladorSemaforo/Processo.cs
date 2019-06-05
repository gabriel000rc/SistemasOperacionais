using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorSemaforo
{
    public abstract class Processo
    {
        public int quantidadeBlocosAcao = 10;
        abstract public void executaAcao(RAM ram);       
    }
}
