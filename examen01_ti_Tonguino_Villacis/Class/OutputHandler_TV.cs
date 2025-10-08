namespace ConsoleApp1.Class
{
    // 🔹 Clase responsable de mostrar resultados (SRP)
    public class OutputHandler_TV
    {
        public void MostrarResultado_TV(string a, string b, string resultado)
        {
            Console.WriteLine("\n=== RESULTADO DE LA SUMA ===");
            Console.WriteLine($"A:     {a}");
            Console.WriteLine($"B:   + {b}");
            Console.WriteLine($"----------------------------");
            Console.WriteLine($"SUMA:  {resultado}");
        }
    }
}