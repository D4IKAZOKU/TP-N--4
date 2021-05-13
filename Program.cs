using System;

namespace TP_N___4
{
    class tp_4
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Persona
    {
        public Persona (int dni, string nombre, string apellido, string domicilio, string celular, string email)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.celular = celular;
            this.email = email;
        }

        public int dni {get; set;}
        public string nombre {get; set;}
        public string apellido {get; set;}
        public string domicilio {get; set;}
        public string celular {get; set;}
        public string email {get; set;}

        
    }

    class Actividad

    {
        public Actividad (string nombre, string tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
        }
        
        public string nombre {get; set;}
        public string tipo {get; set;}
    }
}
