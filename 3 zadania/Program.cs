using System;

while (true)
{
    Console.Write("\n--- MENU ---\n1-Kalk, 2-Temp, 3-Srednia, 0-Exit\nWybór: ");
    string m = Console.ReadLine();
    if (m == "0") break;

    switch (m)
    {
        case "1": // Zadanie 1: Kalkulator
            Console.Write("A: "); double a = double.Parse(Console.ReadLine());
            Console.Write("Op (+,-,*,/): "); string op = Console.ReadLine();
            Console.Write("B: "); double b = double.Parse(Console.ReadLine());
            if (op == "+") Console.WriteLine($"Wynik: {a + b}");
            else if (op == "-") Console.WriteLine($"Wynik: {a - b}");
            else if (op == "*") Console.WriteLine($"Wynik: {a * b}");
            else if (op == "/") Console.WriteLine(b != 0 ? $"Wynik: {a / b}" : "Nie dziel przez 0!");
            break;

        case "2": // Zadanie 2 :Konwerter temperatury
            Console.Write("C->F (wpisz C) lub F->C (wpisz F): ");
            string k = Console.ReadLine().ToUpper();
            Console.Write("Temp: "); double t = double.Parse(Console.ReadLine());
            if (k == "C") Console.WriteLine($"{t * 1.8 + 32}°F");
            else if (k == "F") Console.WriteLine($"{(t - 32) / 1.8}°C");
            break;

        case "3": // Zadanie 3: Średnia ocen
            Console.Write("Ile ocen: ");
            int n = int.Parse(Console.ReadLine());
            double suma = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Ocena {i}: ");
                suma += double.Parse(Console.ReadLine());
            }
            double sr = suma / n;
            Console.WriteLine($"Średnia: {sr:F2}");
            Console.WriteLine(sr >= 3.0 ? "Uczeń zdał." : "Uczeń nie zdał.");
            break;
    }
}