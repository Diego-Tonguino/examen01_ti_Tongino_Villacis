namespace ConsoleApp1.Class;

// 🔹 Clase responsable de capturar los datos (SRP)
public class InputHandler_TV
{
    public string LeerNumero_TV(string mensaje)
    {
        string numero;
        do
        {
            Console.Write(mensaje);
            numero = Console.ReadLine()?.Trim() ?? "";

            if (!EsValido_TV(numero))
            {
                Console.WriteLine("Ingrese un número válido entre 1 y 10^200.");
            }

        } while (!EsValido_TV(numero));

        return numero;
    }

    private bool EsValido_TV(string numero)
    {
        if (string.IsNullOrEmpty(numero)) return false;
        if (numero.Length > 200) return false;
        foreach (char c in numero)
            if (!char.IsDigit(c)) return false;
        return true;
    }
}