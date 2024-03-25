namespace stringEjercicio1
{
    internal class ejercio1

    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;

            Console.WriteLine("Ingrese nombre:");

            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese apellido");

            apellido = Console.ReadLine();  

            Console.Write($"el nombre completo es {nombre} {apellido}");
        }
    }
}
