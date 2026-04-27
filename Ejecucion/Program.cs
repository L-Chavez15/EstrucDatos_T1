
using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecucion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila pl = new Pila();
            Lista pesadas = new Lista();
            Lista livianas = new Lista();
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Ingresar caja");
                Console.WriteLine("2. Mostrar pila");
                Console.WriteLine("3. Inventario final");
                Console.WriteLine("4. Buscar en inventario");
                Console.WriteLine("0. Salir");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Caja c = new Caja();

                        Console.WriteLine("Descripcion:");
                        c.Descripcion = Console.ReadLine();

                        Console.WriteLine("Peso:");
                        c.Peso = double.Parse(Console.ReadLine());

                        pl.Apilar(c);
                        Console.WriteLine("Caja agregada");
                        Console.ReadKey();
                        break;

                    case 2:
                        pl.mostrar();
                        Console.ReadKey();
                        break;

                    case 3:
                        
                        Console.WriteLine("Procesando inventario...");
                        Caja a = pl.Desapilar();
                        if (a.Peso>=50)
                        {
                            pesadas.Insertar(a);
                        }
                        else
                        {
                            livianas.Insertar(a);
                        }
                        Console.WriteLine("CAJAS PESADAS: ");
                        pesadas.MostrarL();

                        Console.WriteLine("Cajas Livianas: ");
                        livianas.MostrarL();
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Código a buscar:");
                        int cod = int.Parse(Console.ReadLine());

                        Console.WriteLine("Buscando en pesadas...");
                        pesadas.Buscar(cod);

                        Console.WriteLine("Buscando en livianas...");
                        livianas.Buscar(cod);

                        Console.ReadKey();
                        break;
                }

            } while (op!=0);

        }
    }
}
