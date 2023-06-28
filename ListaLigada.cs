using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    internal class ListaLigada
    {
        Nodo nodoInicial;


        public ListaLigada(string valor)
        {
            nodoInicial = new Nodo(valor);
        }
        public void Agregar(string valor)
        {
            Nodo nodoActual = nodoInicial;

            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;

            }
            
            nodoActual.Siguiente = new Nodo(valor);
        }
        
        public void Relacionar(ListaLigada vertice)
        {
            
            Agregar(vertice.nodoInicial.Valor);
            
        }

        

        
        /*
        public void Hasheo(ListaLigada vertice)
        {
            
            int index;
            byte[] bytes = Encoding.ASCII.GetBytes(vertice.nodoInicial.Valor);
        }
        */
    }
}
