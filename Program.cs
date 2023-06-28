using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ListaLigada> hash = new List<ListaLigada>();

            //6 espacios

            ListaLigada Posicion0 = new ListaLigada("0");
            ListaLigada Posicion1 = new ListaLigada("1");
            ListaLigada Posicion2 = new ListaLigada("2");
            ListaLigada Posicion3 = new ListaLigada("3");
            ListaLigada Posicion4 = new ListaLigada("4");
            ListaLigada Posicion5 = new ListaLigada("5");

            hash.Add(Posicion0);
            hash.Add(Posicion1);
            hash.Add(Posicion2);
            hash.Add(Posicion3);
            hash.Add(Posicion4);
            hash.Add(Posicion5);

            int SumaASCII(string entrada)
            {
                int suma = 0;
                foreach (var x in entrada)
                {
                    suma += (int)x;
                }
                return suma;
            }

            int GetIndex(string entrada)
            {

                int indice = SumaASCII(entrada) % 6;
                return indice;
            }
            hash.ElementAt(GetIndex("coc@da")).Agregar("coc@da");
            hash.ElementAt(GetIndex("Burrito")).Agregar("Burrito");
            hash.ElementAt(GetIndex("Machaca")).Agregar("Machaca");
            hash.ElementAt(GetIndex("Horchata")).Agregar("Horchata");
            hash.ElementAt(GetIndex("Churro")).Agregar("Churro");
            hash.ElementAt(GetIndex("Ice-cream")).Agregar("Ice-cream");
           

        }
    }
}
