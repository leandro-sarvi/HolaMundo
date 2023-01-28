namespace HolaMundo
{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu nombre");
            //Console.Readline() lee la siguiente linea en consola
            String? nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido " + nombre);
            Console.WriteLine("Ingrese la hora: ");
            int? hora = int.Parse(Console.ReadLine());
            Console.WriteLine("La hora ingresada es " + hora);
        }
    }
}

