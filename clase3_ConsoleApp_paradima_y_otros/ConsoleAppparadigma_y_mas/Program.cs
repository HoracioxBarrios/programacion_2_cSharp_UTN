using System;
using ClassLibrary;

namespace ConsoleAppparadigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Paradigma POO, ejemplo de class");

            Console.WriteLine("se crea una libreria de clases, dentro se crea la class CuentaBancaria");
            Console.WriteLine("debemos pararnos en el proyecto este de consola y hacer agregar ref de proyecto ");
            Console.WriteLine("de ese modo podemos hacer using ClassLibrearuy que es la libreria de clases con todo lo de dentro");
            Console.WriteLine("y en este proyecto en la class Program ejecutamos la instancia de la class CuentaBancaria y sus metodos");
            Console.WriteLine("ver codigo:\n\n");
            /*
            Un paradigma es una teoría o conjunto de teorías cuyo núcleo central se acepta 
            sin cuestionar y que suministra la base y modelo para resolver problemas y avanzar 
            en el conocimiento. 
            Un paradigma de programación define la forma, metodología o estilo con el que se 
            resolverá un problema utilizando un lenguaje de programación.
             
            ----------------------------------------------------------------------------------
            PROGRAMACION ORIENTADA A OBJETOS (POO) 

            La programación orientada a objetos es un modelo de programación 
            que utiliza una entidad llamada objeto. Con el cual podemos realizar una abstracción 
            del mundo real para la solución de problemas.
             
            Es un paradigma de programación que propone resolver problemas a través de 
            identificar objetos de la vida real, sus atributos (datos), su comportamiento 
            (acciones) y las relaciones de colaboración entre ellos.


            Ejemplo:
            */


            // Crear una instancia de CuentaBancaria
            CuentaBancaria miCuenta = new CuentaBancaria("1000", 1000);

            // Realizar operaciones en la cuenta
            miCuenta.Depositar(500);
            miCuenta.Extraer(200);

            // Obtener y mostrar el número de cuenta y saldo actual
            Console.WriteLine($"Número de cuenta: {miCuenta.ObtenerNumeroCuenta}");
            Console.WriteLine($"Saldo actual: {miCuenta.ObtenerSaldo}");

        }
    }
}
