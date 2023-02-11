internal class Program
{
    private static void Main(string[] args)
    {
        /*
        3 Hacer un programa que muestre la hora
        del día en formato AM/FM seguida del
        año, el día y el mes actual.
        */
        DateTime tiempo = DateTime.Now;

        System.Console.WriteLine($"Mi tiempo en 24 horas y fecha: {tiempo} {tiempo.ToString("tt")}");
        Console.WriteLine($"Mi tiempo en 12 horas y fecha: {tiempo.ToString("dd/MM/yyyy hh:mm:ss tt")}");

        /* Hacer un programa que le solicite al
        usuario dos cadenas y luego las muestre
        en orden alfabético.
        */

        string[] cadenas = new string[2];

        for (int i = 0; i < cadenas.Length; i++)
        {
            System.Console.Write($"Ingrese la cadena de texto: ");
            cadenas[i] = Console.ReadLine();
        }
        Console.Clear();
        Array.Sort(cadenas);

        for (int i = 0; i < cadenas.Length; i++)
        {
            System.Console.WriteLine($"{i+1}: {cadenas[i]}");

        }





    }
}