using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            short op; 
            string busca; 
            Nodo v; 
            Lista m = new Lista(); 
            do  { 
                Console.Clear(); 
                Console.WriteLine("\tLISTAS ENLAZADAS (NODOS) \n"); 
                Console.WriteLine("1. Ingresar Registro"); 
                Console.WriteLine("2. Mostrar Lista"); 
                Console.WriteLine("3. Buscar"); 
                Console.WriteLine("4. Eliminar"); 
                Console.WriteLine("5. Salir"); 
                Console.Write("Ingrese opción: "); 
                op = Convert.ToInt16(Console.ReadLine()); 

                switch (op)  { 

                    case 1: 
                        m.Ingresar(); 
                    break; 

                    case 2: 
                        Console.Clear(); 
                        m.Mostrar(); 
                    break; 

                    case 3: 
                        Console.Clear(); 

                        Console.Write("Ingrese valor a buscar: "); 
                        busca = Console.ReadLine(); 
                        v = m.Buscar(busca); 
                        if (v == null) 
                        Console.WriteLine("No existe un registro con esta identificación"); 
                        else 
                        { 
                        Console.WriteLine("Nodo encontrado"); 
                        v.Mostrar(); 
                        } 
                        Console.ReadLine(); 
                    break; 

                    case 4:
                        Console.Clear(); 

                        int pos;

                        Console.Write("Ingrese Posición a eliminar : ");
                        pos = Int32.Parse(Console.ReadLine());
                        m.Borra_Posicion(pos);

                    break;

                    default: Console.WriteLine("Proceso Terminado..."); 
                    break; 
                } 
            } while ((op > 0) && (op < 5)); 
        }
    }
}
