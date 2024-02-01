namespace edu.Adivina
{
    internal class Program
    {
        private static string jugadorLetra;

        static void Main(string[] args)
        {
            Console.WriteLine("Adivina la palabra por letras//juego del ahorcado");

            Random random = new Random();
            string[] palabras = { "misterio","palabra", "gafas" };
            int mIndex = random.Next(palabras.Length);
            string palabraSecreta = palabras[mIndex];
            int numletras = 0;

            int intentos = 6;

            for (int i = 0; i < palabraSecreta.Length; i++)
            {
                numletras ++;                         
            }

            Console.WriteLine("Comienza el juego");
            Console.WriteLine("La palabra oculta tiene " + numletras + " letras");

            string jugadorPalabra = Console.ReadLine();


            while (!jugadorPalabra.Equals(palabraSecreta) && intentos > 0)
            {
                Console.WriteLine("Quedan " + intentos + " intento");
                Console.WriteLine("Inténtalo de nuevo");
                jugadorPalabra = Console.ReadLine();
                intentos--;
            }
            if (intentos == 0)
            {
                Console.WriteLine("Has perdido. La palabra correcta era: " + palabraSecreta);
            }
            else
            {
                Console.WriteLine("Has ganado");
            }


        }
    }
}
