using System;

namespace laboratorio1
{//cachipun
    class Program
    {
        static void Main(string[] args)
        {//constructor
            Persona jugador = new Persona("Bob", "Kunga");
            jugador.lanzar();
        }
        class Persona
        {
            //atributos
            private string Nombre;
            private string Apellido;
            public Persona(string name, string lastname)
            {
            Nombre = name;
            Apellido = lastname;
            }
            //metodo
            public void lanzar()
            {
                Random random = new Random();
                Console.WriteLine(random.Next(0, 3));
            }
        }
    }
}
