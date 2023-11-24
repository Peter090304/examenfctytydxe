namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Persona> listaPersonas = new LinkedList<Persona>();

        
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese información para la persona {i + 1}:");

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                
                listaPersonas.AddLast(new Persona(nombre, edad));
            }

            Console.WriteLine("\nLista de personas:");
            foreach (var persona in listaPersonas)
            {
                Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
            }
        }

        public static Persona BuscarPersonaPorNombre(LinkedList<Persona> lista, string nombre)
        {
            foreach (var persona in lista)
            {
                if (persona.Nombre == nombre)
                {
                    return persona;
                }
            }
            return null;
        }

        public static int ObtenerPosicionPersona(LinkedList<Persona> lista, Persona persona)
        {
            int posicion = 1;
            foreach (var p in lista)
            {
                if (p == persona)
                {
                    return posicion;
                }
                posicion++;
            }
            return -1;
        }

        public static List<Persona> OrdenarListaPorEdad(LinkedList<Persona> lista)
        {
            return lista.OrderBy(p => p.Edad).ToList();
        }
    }
    
}


