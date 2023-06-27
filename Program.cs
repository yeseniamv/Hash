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

        }
    }
}
