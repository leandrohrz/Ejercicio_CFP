namespace stringEjercicio2
{
    internal class ejercicio2
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            string edadTexto;
            int edad;

            Console.WriteLine("Ingrese nombre:");

            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese apellido");

            apellido = Console.ReadLine();

            Console.WriteLine("Ingrese su edad:");

            edadTexto = Console.ReadLine();

            edad = int.Parse(edadTexto);

            Console.WriteLine($"Mi nombre es {nombre} {apellido} de {edad} años");

        }
    }
}
