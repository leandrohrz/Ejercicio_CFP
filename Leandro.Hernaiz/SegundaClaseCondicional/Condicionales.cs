namespace SegundaClaseCondicional
{
    internal class Condicionales
    {
        static void Main(string[] args)
        {
            int edad;
            string estCivil;
            string edadTexto;

            Console.Write("Ingrese su edad: ");

            edadTexto = Console.ReadLine();

            edad = int.Parse(edadTexto);

            Console.Write("Ingrese su estado civil: ");

            estCivil = Console.ReadLine();

            if (edad < 18 && estCivil == "casado")
            {
                Console.Write("Es muy pequeño para NO ser soltero");
            }






        }

    }
}

