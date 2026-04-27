using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Lista
    {
        public Nodo primero = null;

        public void Insertar(Caja p)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = p;

            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                Nodo temporal = primero;

                while (temporal.siguiente != null)
                {
                    temporal = temporal.siguiente;
                }
                temporal.siguiente = nuevo;
            }
        }
        public void MostrarL()
        {
            Nodo temp = primero;
            while (temp != null)
            {
                Console.WriteLine(temp.dato);
                temp = temp.siguiente;

            }
        }
        public void Buscar(int codigo)
        {
            Nodo temp = primero;

            while (temp != null)
            {
                if (temp.dato.Codigo == codigo)
                {
                    Console.WriteLine("ENCONTRADO:");
                    Console.WriteLine(temp.dato);
                    return;
                }
                temp = temp.siguiente;
            }
            Console.WriteLine("NO ENCONTRADO");
        }


    }
}
