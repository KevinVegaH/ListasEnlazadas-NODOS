using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo
{
    class Nodo
    {
        private string Nombre;
        private string id;

        public Nodo sig;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        public Nodo(string nombre, string id) { 
            this.Nombre = nombre;
            this.Id = id;
            this.sig = null; 
        }

        public void Mostrar() {
            Console.WriteLine("Nombre :" + this.Nombre + "\t" + "Identificación:  " + this.id);
        }

        public string NOMBRE {
            get { return (Nombre); } 
        } 
    }
}
