namespace Primera_Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int edad;
            string edadTexto;

            Console.Write("Ingrese su nombre: ");

            nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
           
            apellido = Console.ReadLine();


            Console.Write("Ingrese su edad: ");

            edadTexto = Console.ReadLine();
            
            edad = int.Parse(edadTexto);


            // Console.WriteLine("bienvenido " + nombre  + " " + apellido + ", ud tiene : " + edad);

            //Console.WriteLine("Bienvendico {0} {1}, ud tiene: {2} edad " ,nombre,apellido,edad);

            Console.WriteLine($"bienvenido {nombre} {apellido} ud tiene : {edad} ");

        }
    }
}
