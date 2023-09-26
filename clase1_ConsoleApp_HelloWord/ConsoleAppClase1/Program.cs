namespace ConsoleAppClase1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(  "Hola Mundo, Hola cSharp");
            ////comentario de una linea
            ///*comentario multilinea 
            // * 
            // * cSharp es un lenguaje de fuerte tipado
            // * 
            // * Las sentencias terminan con ';' punto y coma
            // * 
            // * Se usan llaves '{}" para bloques de codigo
            // * 
            // * se usa parentesis '()' para estructuras (if, while, for, etc)
            // * 
            // * El scope de las variables cambia con lo que vimos en Python
            // * 
            // * 
            // */





            int x = 1;
            if (x == 1)
            {
                int a = 2;
                Console.WriteLine("'Dentro del 1er if' x == 1");
                if (a == 2)
                {
                    Console.WriteLine("'Dentro del 2do if' a == 2");
                }
            }

            //Console.WriteLine($"en este scope la variable a no existe{a}"); //use interpolacion de string, para ver el valor de 'a'
            Console.WriteLine("en este scope la variable a no existe");

            while (x < 10)
            {
                Console.WriteLine("PreIncremento '1' " + x); //1
                x++;
                Console.WriteLine("PreIncremento '2' " + x);//2
                ++x;
                Console.WriteLine("PosIncremento '1' " + x);//3 *tambien le suma uno, pero la dif es que primero le suma y despues lo muestra.

            }

        }
    }
}