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

            ListaLigada Valor1 = new ListaLigada("coc@da");
            ListaLigada Valor2 = new ListaLigada("Burrito");
            ListaLigada Valor3 = new ListaLigada("Machaca");
            ListaLigada Valor4 = new ListaLigada("Horchata");
            ListaLigada Valor5 = new ListaLigada("Churro");
            ListaLigada Valor6 = new ListaLigada("Ice-cream");

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
            hash.ElementAt(GetIndex("coc@da")).Relacionar(Valor1);
            hash.ElementAt(GetIndex("Burrito")).Relacionar(Valor2);
            hash.ElementAt(GetIndex("Machaca")).Relacionar(Valor3);
            hash.ElementAt(GetIndex("Horchata")).Relacionar(Valor4);
            hash.ElementAt(GetIndex("Churro")).Relacionar(Valor5);
            hash.ElementAt(GetIndex("Ice-cream")).Relacionar(Valor6);
            Console.ReadKey();

        }
    }
}
