using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Pila
    {
        public Nodo cima = null;

        public void Apilar(Caja c)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato= c;

            if (cima==null)
            {
                cima = nuevo;
            }
            else
            {
                nuevo.siguiente=cima;
                cima = nuevo;
            }
        }
        public Caja Desapilar()
        {
            Caja dato = null;
            if (cima != null)
            {
                dato=cima.dato;
                cima=cima.siguiente;
            }
            return dato;
        }
        public void mostrar()
        {
            Nodo temp = cima;
            while(temp!=null)
            {
                Console.WriteLine(temp.dato);
                temp = temp.siguiente;
            }
        }
        public void Buscar(int bus)
        {
            Nodo temp = cima;
            while (temp != null)
            {
                if (temp.dato.Codigo==bus)
                {
                    Console.WriteLine(temp.dato);
                    return;
                }
                temp = temp.siguiente;
            }
            Console.WriteLine("CAJA NO ENCONTRADA");
        }

    }
}
