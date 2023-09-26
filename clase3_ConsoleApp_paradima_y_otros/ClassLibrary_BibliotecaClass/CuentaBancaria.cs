using System;

namespace ClassLibrary
{
    public class CuentaBancaria
    {
        // Atributos
        private string _numeroCuenta;
        private float _saldo = 0;

        // Constructor
        public CuentaBancaria(string numeroCuenta, float saldoInicial)
        {
            _numeroCuenta = numeroCuenta;
            _saldo = saldoInicial;
            ObtenerSaldo = saldoInicial;  // Inicializa la propiedad ObtenerSaldo
            ObtenerNumeroCuenta = numeroCuenta;  // Inicializa la propiedad ObtenerNumeroCuenta
        }


        // Método para obtener Dinero
        public void Extraer(float cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad a extraer debe ser mayor que 0");
            }
            else if (cantidad > _saldo)
            {
                Console.WriteLine("Fondos insuficientes");
            }
            else
            {
                _saldo -= cantidad;  // Resta la cantidad extraída al saldo
                Console.WriteLine($"Se ha extraído la cantidad {cantidad} y el nuevo saldo es {_saldo}");
            }
        }

        // Método para depositar dinero
        public void Depositar(float cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad a depositar debe ser mayor que 0");
            }
            else
            {
                _saldo += cantidad;  // Suma la cantidad depositada al saldo
                Console.WriteLine($"Se ha depositado {cantidad} y el nuevo saldo es {_saldo}");
            }
        }

        // Propiedades para obtener el saldo actual y el número de cuenta
        public float ObtenerSaldo { get; }
        public string ObtenerNumeroCuenta { get; }
    }
}
