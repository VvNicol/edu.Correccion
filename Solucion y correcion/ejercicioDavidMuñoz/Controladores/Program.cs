namespace ejercicioNicole.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación.
    /// <author>dmp - 310124</author>
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo que contiene toda la aplicación.
        /// </summary>
        /// <author>dmp - 310124 </author>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Array de tipo string que contiene las palabras.
            string[] palabrasRandom = { "coche", "ordenador", "java" };

            //Copia de la clase para poder hacer que las palabras sean aleatorias
            Random rm = new Random();          

            //variable string en la cual la palabra se genera de forma aleatoria
            string palabraAleatoria = palabrasRandom[rm.Next(0, palabrasRandom.Length)];
         
            //Muestra la longitud de la palabra
            Console.WriteLine("Longitud de la palabra random: " + palabraAleatoria.Length);

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Tienes 5 intentos");
            Console.WriteLine("-------------------------------------------------------");
            

            //variable para controlar el bucle for
            int intentos = 5;

            //bucle for para controlar los intentos
            for(int i = 0; i < intentos;)
            {
                Console.WriteLine("Indique que palabra crees que es la que te ha tocado(todo en minuscula): ");
                string palabraUsuario = Console.ReadLine();
                
                //condicional que comprueba si la palabra introducida es la misma que la palabra
                // que se ha generado de manera aleatoria.
                if (palabraUsuario.Equals(palabraAleatoria))
                {
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Has ganado");
                    Console.WriteLine("-------------------------------------------------------");
                    return;
                }
                else
                {
                    i++;
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("No has acertado");
                    

                    //muestra los intentos que te quedan
                    Console.WriteLine("Tienes " + (intentos - i) + " " + "intentos");
                    Console.WriteLine("-------------------------------------------------------");
                }

            }
            //Una vez que termina el bucle te muestra este mensaje
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Has perdido");
            Console.WriteLine("La palabra es: " + palabraAleatoria);
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}