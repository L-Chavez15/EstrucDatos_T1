
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
                Console.Write("------------------------------\n");
                Console.WriteLine("1. INGRESAR CAJA");
                Console.WriteLine("2. MOSTRAR");
                Console.WriteLine("3. INVENTARIO FINAL");
                Console.WriteLine("4. BUSCAR");
                Console.WriteLine("0. SALIR");
                Console.Write("------------------------------\n");


                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Caja c = new Caja();

                        Console.Write("Descripcion:");
                        c.Descripcion = Console.ReadLine();

                        Console.Write("Peso:");
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
                        while (a != null)
                        {
                            if (a.Peso >= 50)
                            {
                                pesadas.Insertar(a);
                            }
                            else
                            {
                                livianas.Insertar(a);
                            }
                            a = pl.Desapilar();
                        }
                        
                        Console.WriteLine("CAJAS PESADAS: ");
                        Console.ResetColor();
                        pesadas.MostrarL();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Cajas Livianas: ");

                        pesadas.MostrarL();
                        livianas.MostrarL(); 

                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Write("Código a buscar: ");
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
