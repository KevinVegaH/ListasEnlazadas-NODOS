using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo
{
    class Lista
    {
        Nodo primero,ultimo; 

        public Lista(){
            primero = ultimo = null;
        } 

        public void Ingresar() 
        { 
            string nom;
            string id;
            Console.Clear(); 
            Console.WriteLine("Ingrese Datos "); 
            Console.WriteLine("**************"); 
            Console.Write("Ingrese Nombre: "); 
            nom = Console.ReadLine();
            Console.Write("Ingrese Identifiación: ");
            id = Console.ReadLine(); 
            Nodo i = new Nodo(nom, id);
            Insertar_Ultimo(i); 
        } 

        public void Mostrar() 
        { 
            Nodo i; 
            if (primero != null) { 

                i = primero; 

                while (i != null) { 
                    i.Mostrar(); 
                    i = i.sig; 
                } 
            } 

            else { 
            Console.WriteLine("lista vacia"); 
            } 

            Console.ReadLine(); 
        } 

        public Nodo Buscar(string b) 
        { 
            Nodo i; 
            i = primero; 

            while (i != null) 
            { 
                if (i.NOMBRE==b) 
                    return (i); 
                else 
                    i = i.sig; 
            } 
            return (null); 
        } 


        public void Insertar_Primero(Nodo i)
        {

            if (primero == null)
                primero = i;
            else
            {
                i.sig = primero;
                primero = i;
            }

        }

        private void Insertar_Ultimo(Nodo i)
        {
            if (primero == null)
                primero = i;
            else
                ultimo.sig = i;
                ultimo = i;
        }

        public void Borra_Posicion(int pos)
        {

            Nodo i, anterior;
            int cont = 0;

            i = primero;
            anterior = null;
            while (i != null)
            {
                if (pos == cont)
                {
                    if (anterior == null)
                    {
                        // Sucede cuando pos == 0 
                        primero = primero.sig;
                        // Osea se iguala el primero a Null ( Se borra)
                        i = null;
                    }
                    else
                    {
                        //
                        anterior.sig = i.sig;
                        i = null;
                    }

                }
                else
                {
                    // El anterior sería el primero
                    anterior = i;
                    // Ahora el primero apunta al siguiente
                    i = i.sig;

                    cont++;
                }
            }
        }
    }
}
