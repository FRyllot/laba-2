using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите текущую температуру (°C): ");
        string input = Console.ReadLine();

        int temperature = int.Parse(input);

        if (temperature < 0)
        {
            Console.WriteLine("Холодно, надень куртку.");
        }
        else
        {
            Console.WriteLine("Тепло, можно гулять.");
        }
    }
}
