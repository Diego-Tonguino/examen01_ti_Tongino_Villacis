using ConsoleApp1.Interfaces;
using ConsoleApp1.Class;

namespace ConsoleApp1
{

    // 🔹 Clase principal (usa inyección de dependencias → DIP)
    public class Program
    {
        static void Main(string[] args)
        {
            InputHandler_TV input = new InputHandler_TV();
            OutputHandler_TV output = new OutputHandler_TV();

            // Inyección de dependencia → clase depende de la abstracción (IOperacion_MV), no de la implementación concreta
            IOperacion_TV suma = new BigNumberAdder_TV();

            Console.WriteLine("=== SUMADOR DE GRANDES NÚMEROS ===\n");

            string A = input.LeerNumero_TV("Ingrese el número A: ");
            string B = input.LeerNumero_TV("Ingrese el número B: ");

            string resultado = suma.Calcular_TV(A, B);
            output.MostrarResultado_TV(A, B, resultado);

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}