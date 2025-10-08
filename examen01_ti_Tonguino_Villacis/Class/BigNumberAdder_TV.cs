using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Class;

// 🔹 Clase responsable de sumar grandes números (SRP)
public class BigNumberAdder_TV : IOperacion_TV
{
    public string Calcular_TV(string a, string b)
    {
        // Igualar la longitud de los números sin usar Math
        if (a.Length > b.Length)
            b = b.PadLeft(a.Length, '0');
        else if (b.Length > a.Length)
            a = a.PadLeft(b.Length, '0');

        string resultado = "";
        int acarreo = 0;

        // Recorremos desde el final hacia el inicio
        for (int i = a.Length - 1; i >= 0; i--)
        {
            int digA = a[i] - '0';
            int digB = b[i] - '0';
            int suma = digA + digB + acarreo;

            if (suma >= 10)
            {
                acarreo = 1;
                suma -= 10;
            }
            else
            {
                acarreo = 0;
            }

            resultado = suma.ToString() + resultado;
        }

        if (acarreo > 0)
            resultado = "1" + resultado;

        return resultado.TrimStart('0');
    }
}