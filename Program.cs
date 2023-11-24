using System.ComponentModel;

namespace ExamenU3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Listas li = new Listas();
            Persona persona = new Persona();
            Console.WriteLine("Ingrese el nombre");
            persona.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad");
            persona.Edad = Convert.ToInt32(Console.ReadLine());
            li.InsertarElemento(persona);

            Persona persona2 = new Persona();
            Console.WriteLine("Ingrese el nombre");
            persona2.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad");
            persona2.Edad = Convert.ToInt32(Console.ReadLine());
            li.InsertarElemento(persona2);

            Persona persona3 = new Persona();
            Console.WriteLine("Ingrese el nombre");
            persona3.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad");
            persona3.Edad = Convert.ToInt32(Console.ReadLine());
            li.InsertarElemento(persona3);

            // persona.Nombre = "Juan";
            //persona.Edad = 25;
            // Persona persona2 = new Persona();
            // persona2.Nombre = "María";
            //persona2.Edad = 35;
            //Persona persona3 = new Persona();
            //persona3.Nombre = "Pedro";
            //persona3.Edad = 10;
            //li.InsertarElemento(persona);
            //li.InsertarElemento(persona2);
            //li.InsertarElemento(persona3);
            li.ImprimirLista();

            li.BuscarNombre("Juan");

            li.ImprimirLista();
        }
    }
}