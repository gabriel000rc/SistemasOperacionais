using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorSemaforo
{
    public class RAM
    {
        public int[] espCritico = new int[1000];
        public int inicio = 0;
        public int fim = 0;

        public RAM()
        {
            for(int i=0; i < 1000; ++i)
            {
                this.espCritico[i] = 0;
                
            }

        }
        public void inserir(int valor)
        {
            this.espCritico[this.fim] = valor;
            this.fim++;
        }

        public void remover()
        {
            this.espCritico[this.inicio] = 0;
            this.inicio++;
            if (this.inicio == 1000) this.inicio = 0;
        }

        public void imprimir()
        {
            Console.Write("\nMemoria:\n");
            for(int i = 0; i < 1000; ++i)
            {
                if(i%100 == 0) Console.Write("\n");
                Console.Write("{0}", Convert.ToString(this.espCritico[i]));
                
            }
        }

    }
}
