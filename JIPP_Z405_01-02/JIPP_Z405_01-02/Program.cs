using System;

class Program
{
    static void Main()
    {
        // Zadanie 2
        Console.WriteLine("Zadanie 2");
        Console.WriteLine("Podaj swoje imię:");
        var name = Console.ReadLine();
        Console.WriteLine("Hello " + name);
        Console.WriteLine();
        // Zadanie 3 - poprawiony kod
        Console.WriteLine("Zadanie 3");
        int result = 5 + 9;
        Console.WriteLine("Wynik: " + result);
        Console.WriteLine();

        //Operatory >>>>>>>>>>>>>>>>>>>>>>
        Console.WriteLine("Operatory ------------------------------------------------------------------------");

        // Operatory - Zadanie 1
        Console.WriteLine("Zadanie 1");
        int number = 10;
        float money = 20.5f;
        string text = "Cześć";
        bool isLogged = true;
        char myChar = 'A';
        decimal price = 99.99m;

        Console.WriteLine($"Number: {number}, Money: {money}, Text: {text}, IsLogged: {isLogged}, MyChar: {myChar}, Price: {price}");
        Console.WriteLine();
        // Operatory - Zadanie 2
        Console.WriteLine("Zadanie 2");
        string myAge = "Age: ";
        int wifeAge = 18;
        string result2 = myAge + wifeAge;
        Console.WriteLine(result2);
        Console.WriteLine();
        // Wniosek: Dodawanie stringa i liczby powoduje konkatenację, a nie sumowanie wartości liczbowych.

        // Operatory - Zadanie 3
        Console.WriteLine("Zadanie 3");
        bool isTrue = true;
        bool isFalse = false;
        bool isReallyTrue = true;

        bool and = isTrue && isFalse;
        bool or = isTrue || isReallyTrue;
        bool negative = !isFalse;

        Console.WriteLine($"AND: {and}, OR: {or}, NEGATIVE: {negative}");
        Console.WriteLine();
        // Operatory - Zadanie 4
        Console.WriteLine("Zadanie 4");
        int a = 5, b = 12;
        int add = a + b;
        int sub = a - b;
        int div = a / b;
        int mul = a * b;
        int mod = a % b;

        Console.WriteLine($"Add: {add}, Sub: {sub}, Div: {div}, Mul: {mul}, Mod: {mod}");

        // Operatory - Zadanie 5
        Console.WriteLine("Zadanie 5");
        string aa = "Ala ";
        string bb = "ma ";
        string cc = "kota.";
        string result3 = aa + bb + cc;

        Console.WriteLine(result3);
        Console.WriteLine();



        //Pętle >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Console.WriteLine("Instrukcje sterujące i pętle ------------------------------------------------------------------------");


        // Zadanie 1
        Console.WriteLine("Zadanie 1");
        int n1 = 10, n2 = 20;
        if (n1 > n2)
            Console.WriteLine($"{n1} jest większe od {n2}");
        else if (n1 < n2)
            Console.WriteLine($"{n1} jest mniejsze od {n2}");
        else
            Console.WriteLine($"{n1} jest równe {n2}");
        Console.WriteLine();

        // Zadanie 2 - pętla for
        Console.WriteLine("Zadanie 2-pętla for");
        for (int i = 0; i < 10; i++)
            Console.WriteLine("C#");
        Console.WriteLine();

        // Zadanie 2 - pętla while
        Console.WriteLine("Zadanie 2-pętla while");
        int count = 0;
        while (count < 10)
        {
            Console.WriteLine("C#");
            count++;
        }
        Console.WriteLine();

        // Zadanie 3
        Console.WriteLine("Zadanie 3");
        int n = 10;
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine($"{i} - Parzysta");
            else
                Console.WriteLine($"{i} - Nieparzysta");
        }
        Console.WriteLine();

        // Zadanie 4 
        Console.WriteLine("Zadanie 4");
        int stars = 5;
        for (int i = 1; i <= stars; i++)
        {
            for (int j = 0; j < i; j++)
                Console.Write("* ");
            Console.WriteLine();
        }

        // Zadanie 5
       
        Console.WriteLine("Zadanie 5");
        Console.Write("Podaj swoje otrzymane punkty brakut (0-100)");
        Console.WriteLine();
        int exam = int.Parse(Console.ReadLine());
        if (exam < 0 || exam > 100)
            Console.WriteLine("Wartość poza zakresem.");
        else if (exam <= 39)
            Console.WriteLine("Ocena Niedostateczna");
        else if (exam <= 54)
            Console.WriteLine("Ocena Dopuszczająca");
        else if (exam <= 69)
            Console.WriteLine("Ocena Dostateczna");
        else if (exam <= 84)
            Console.WriteLine("Ocena Dobra");
        else if (exam <= 98)
            Console.WriteLine("Ocena Bardzo Dobra");
        else
            Console.WriteLine("Ocena Celująca");
    }
}

  


