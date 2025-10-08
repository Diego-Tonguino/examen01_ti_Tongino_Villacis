namespace examen01_ti_Tonguino_Villacis.Utilidades;

public class Program
{
    static void Main(string[] args)
    {
        EntradaSalida_TN io = new EntradaSalida_TN();
        string A = io.LeerNumero("A");
        string B = io.LeerNumero("B");

        IOperacion_TN operacion = new SumaGrande_TN();
        string resultado = operacion.Calcular(A, B);

        io.MostrarResultado(resultado);

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}
