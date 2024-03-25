using System.ComponentModel.Design;

namespace Lamparitas
{
    internal class Lamparitas
    {
        static void Main(string[] args)
        {
            string marca;
            string cantidadTexto;
            int cantidad;
            int totalSinDesc;
            int totalConDesc;
            int totalMasIngBru;
            int ingresosBrutos;
            int valor;
            int descuento;

            valor = 150;
            Console.WriteLine("Ingrese marca de lamparita ");

            marca = Console.ReadLine();

            Console.WriteLine("Cantidad de lamparitas ");

            cantidadTexto = Console.ReadLine();

            cantidad = int.Parse(cantidadTexto);

            totalSinDesc = cantidad * valor;

            if (cantidad >= 6)
            {
                descuento = (int)(totalSinDesc * 0.50);
            }
            else
                if (cantidad = 5) 
            {
                descuento = (int)(totalSinDesc * 0.30);
            }else
                if (marca = "argentina luz")
            {
                descuento = (int)(totalSinDesc * 0.30);

            }else
            
       
        }
    }
}
