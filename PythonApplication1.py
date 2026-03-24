while True:
    print("\n--- MENU ---\n1-Kalk, 2-Temp, 3-Srednia, 0-Exit")
    m = input("Wybór: ")

    if m == "0": break

    if m == "1": # Zadanie 1: Kalkulator
        a = float(input("A: "))
        op = input("Op (+,-,*,/): ")
        b = float(input("B: "))
        if op == "+": print(f"Wynik: {a + b}")
        elif op == "-": print(f"Wynik: {a - b}")
        elif op == "*": print(f"Wynik: {a * b}")
        elif op == "/": print(f"Wynik: {a / b}" if b != 0 else "Nie dziel przez 0!")

    elif m == "2": # Zadanie 2: Temperatura
        k = input("C->F (wpisz C) lub F->C (wpisz F): ").upper()
        t = float(input("Temp: "))
        if k == "C": print(f"{t * 1.8 + 32}°F")
        elif k == "F": print(f"{(t - 32) / 1.8}°C")

    elif m == "3": # Zadanie 3: Średnia ocen
        n = int(input("Ilosc ocen: "))
        suma = 0
        for i in range(n):
            suma += float(input(f"Ocena {i+1}: "))
        sr = suma / n
        print(f"Średnia: {sr:.2f}")
        print("Uczeń zdał." if sr >= 3.0 else "Uczeń nie zdał.")
