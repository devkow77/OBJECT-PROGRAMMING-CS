using System.Text;

class Program
{
    static void Main()
    {
        // Zad 1 Witaj, imię użytkownika 

        //Console.Write("Podaj imie: ");
        //string imie = Console.ReadLine();
        //Console.WriteLine($"Witaj, {imie}!");

        // Zad 2 Tabela studentów

        //string[] imiona = {"Kacper", "Jakub", "Mateusz"};
        //string[] nazwiska = {"Kowalski", "Kwasniak", "Pociecha"};
        //int[] nrAlbumow = {142532, 135736, 128927};

        //Console.WriteLine("+-----------+------------+----------+");
        //Console.WriteLine("| Imię      | Nazwisko   | Nr Albumu|");
        //Console.WriteLine("+-----------+------------+----------+");

        //for (int i = 0; i < imiona.Length; i++)
        //{
        //    Console.WriteLine($"| {imiona[i],-9} | {nazwiska[i],-10} | {nrAlbumow[i],-8} |");
        //}

        //Console.WriteLine("+-----------+------------+----------+");

        // Zad 3 Fibonacci Sequence

        //Console.WriteLine("Podaj N: ");
        //int N = Convert.ToInt16(Console.ReadLine());

        //static int Fibonacci(int N)
        //{
        //    if (N <= 1) return N;
        //    else return Fibonacci(N - 1) + Fibonacci(N - 2);
        //}

        //for(int i = 0; i < N + 1; i++)
        //{
        //    Console.WriteLine(Fibonacci(i));
        //}

        // Zad 4 Sprawdzanie liczby pierwszej

        //static Boolean czyLiczbaPierwsza(int n)
        //{
        //    for (int i = 2; i < Math.Sqrt(n); i++)
        //    {
        //        if (n % i == 0) return false;
        //    }

        //    return true;
        //}

        //Console.WriteLine("Podaj liczbe: ");
        //int n = Convert.ToInt16(Console.ReadLine());
        //Console.WriteLine($"Liczba {n} jest liczba pierwsza: {czyLiczbaPierwsza(n)}");

        // Zad 5 Rekurencyjne obliczanie silni

        //static int Factorial(int n)
        //{
        //    if (n == 1) return 1;
        //    if (n == 2) return 2;
        //    else return n * Factorial(n - 1);
        //}

        //Console.WriteLine("Podaj N: ");
        //int n = Convert.ToInt16(Console.ReadLine());
        //Console.WriteLine($"Silnia z {n} wynosi {Factorial(n)}");

        // Zad 6 Tablica - transpozycja macierzy

        //    Console.WriteLine("Podaj liczbe wierszy n: ");
        //    int n = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Podaj liczbe kolumn m: ");
        //    int m = int.Parse(Console.ReadLine());

        //    int[,] macierz = new int[n, m];

        //    Console.WriteLine("Podaj elementy macierzy:");
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //        {
        //            Console.Write($"Element [{i},{j}]: ");
        //            macierz[i, j] = int.Parse(Console.ReadLine());
        //        }
        //    }

        //    Console.WriteLine("Oryginalna macierz:");
        //    WyswietlMacierz(macierz, n, m);

        //    int[,] transponowana = TransponujMacierz(macierz, n, m);

        //    Console.WriteLine("Transponowana macierz:");
        //    WyswietlMacierz(transponowana, m, n);
        //}

        //static int[,] TransponujMacierz(int[,] macierz, int n, int m)
        //{
        //    int[,] transponowana = new int[m, n];
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //        {
        //            transponowana[j, i] = macierz[i, j];
        //        }
        //    }
        //    return transponowana;
        //}

        //static void WyswietlMacierz(int[,] macierz, int n, int m)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //        {
        //            Console.Write(macierz[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        // Zad 7 Anagramy

        //    Console.Write("Podaj pierwsze słowo: ");
        //    string slowo1 = Console.ReadLine().ToLower();

        //    Console.Write("Podaj drugie słowo: ");
        //    string slowo2 = Console.ReadLine().ToLower();

        //    if (CzyAnagram(slowo1, slowo2))
        //    {
        //        Console.WriteLine("Podane słowa są anagramami.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Podane słowa nie są anagramami.");
        //    }
        //}

        //static bool CzyAnagram(string a, string b)
        //{
        //   if (a.Length != b.Length)
        //        return false;

        //   for (int i = 0; i < a.Length; i++)
        //   {
        //        if (a[i] != b[a.Length - (1 + i)]) return false;
        //   }

        //   return true;

        // Zad 8 Kalkulator z obsługą podstawowych operacji

        //Console.WriteLine("Kalkulator prostych operacji");
        //Console.WriteLine("Wybierz operację:");
        //Console.WriteLine("1 - Dodawanie");
        //Console.WriteLine("2 - Odejmowanie");
        //Console.WriteLine("3 - Mnożenie");
        //Console.WriteLine("4 - Dzielenie");

        //Console.Write("Twój wybór: ");
        //int wybor = int.Parse(Console.ReadLine());

        //Console.Write("Podaj pierwszą liczbę: ");
        //double liczba1 = double.Parse(Console.ReadLine());

        //Console.Write("Podaj drugą liczbę: ");
        //double liczba2 = double.Parse(Console.ReadLine());

        //double wynik = 0;

        //switch (wybor)
        //{
        //    case 1:
        //        wynik = liczba1 + liczba2;
        //        Console.WriteLine($"Wynik: {liczba1} + {liczba2} = {wynik}");
        //        break;
        //    case 2:
        //        wynik = liczba1 - liczba2;
        //        Console.WriteLine($"Wynik: {liczba1} - {liczba2} = {wynik}");
        //        break;
        //    case 3:
        //        wynik = liczba1 * liczba2;
        //        Console.WriteLine($"Wynik: {liczba1} * {liczba2} = {wynik}");
        //        break;
        //    case 4:
        //        if (liczba2 != 0)
        //        {
        //            wynik = liczba1 / liczba2;
        //            Console.WriteLine($"Wynik: {liczba1} / {liczba2} = {wynik}");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Błąd: Dzielenie przez zero!");
        //        }
        //        break;
        //    default:
        //        Console.WriteLine("Niepoprawny wybór operacji.");
        //        break;
        //}

        // Zad 9 Konwersja liczby do zapisu binarnego

        //string DziesietnyNaBinarny(int liczba)
        //{
        //    if (liczba == 0) return "0";

        //    StringBuilder wynik = new StringBuilder();

        //    while (liczba > 0)
        //    {
        //        int reszta = liczba % 2;
        //        wynik.Insert(0, reszta); // Wstawiamy resztę na początek ciągu
        //        liczba /= 2; // Dzielenie całkowite
        //    }

        //    return wynik.ToString();
        //}

        //int liczbaDziesietna1 = 10;
        //string liczbaBinarna1 = DziesietnyNaBinarny(liczbaDziesietna1);
        //Console.WriteLine($"Liczba dziesiętna: {liczbaDziesietna1}, liczba binarna: {liczbaBinarna1}");

        //int liczbaDziesietna2 = 25;
        //string liczbaBinarna2 = DziesietnyNaBinarny(liczbaDziesietna2);
        //Console.WriteLine($"Liczba dziesiętna: {liczbaDziesietna2}, liczba binarna: {liczbaBinarna2}");

        //int liczbaDziesietna3 = 0;
        //string liczbaBinarna3 = DziesietnyNaBinarny(liczbaDziesietna3);
        //Console.WriteLine($"Liczba dziesiętna: {liczbaDziesietna3}, liczba binarna: {liczbaBinarna3}");

        // Zad 10 Sortowanie - algorytm bąbelkowy (Bubble Sort)

        //static void SortujBabelkowo(int[] tablica)
        //{
        //    int n = tablica.Length;
        //    bool zamiana;

        //    do
        //    {
        //        zamiana = false;
        //        for (int i = 0; i < n - 1; i++)
        //        {
        //            if (tablica[i] > tablica[i + 1])
        //            {
        //                // Zamiana elementów miejscami
        //                int temp = tablica[i];
        //                tablica[i] = tablica[i + 1];
        //                tablica[i + 1] = temp;
        //                zamiana = true;
        //            }
        //        }
        //        n--; // Zmniejszamy n, ponieważ ostatni element jest już posortowany
        //    } while (zamiana);
        //}

        //static void WyswietlTablice(int[] tablica)
        //{
        //    foreach (int element in tablica)
        //    {
        //        Console.Write(element + " ");
        //    }
        //    Console.WriteLine();
        //}

        //int[] tablica = { 64, 34, 25, 12, 22, 11, 90 };

        //Console.WriteLine("Tablica przed sortowaniem:");
        //WyswietlTablice(tablica);

        //SortujBabelkowo(tablica);

        //Console.WriteLine("\nTablica po sortowaniu:");
        //WyswietlTablice(tablica);

        // Zad 11 Liczenie wystąpień słów w tekście

        //static int PoliczWystapienia(string tekst, string slowo)
        //{
        //    if (string.IsNullOrEmpty(tekst) || string.IsNullOrEmpty(slowo))
        //    {
        //        return 0;
        //    }

        //    string tekstLowerCase = tekst.ToLower();
        //    string slowoLowerCase = slowo.ToLower();

        //    string[] slowa = tekstLowerCase.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

        //    int licznik = 0;
        //    foreach (string s in slowa)
        //    {
        //        if (s == slowoLowerCase)
        //        {
        //            licznik++;
        //        }
        //    }
        //    return licznik;
        //}

        //Console.WriteLine("Podaj tekst:");
        //string tekst = Console.ReadLine();

        //Console.WriteLine("Podaj słowo do wyszukania:");
        //string slowo = Console.ReadLine();

        //int liczbaWystapien = PoliczWystapienia(tekst, slowo);

        //Console.WriteLine($"Słowo '{slowo}' występuje {liczbaWystapien} razy.");

        // Zad 12 Szukaj największej i najmniejszej liczby w tablicy

        //Console.WriteLine("Podaj liczby oddzielone spacjami:");
        //string input = Console.ReadLine();

        //string[] liczbyStr = input.Split(' ');
        //int[] liczby = new int[liczbyStr.Length];

        //for (int i = 0; i < liczbyStr.Length; i++)
        //{
        //    if (int.TryParse(liczbyStr[i], out int liczba))
        //    {
        //        liczby[i] = liczba;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Nieprawidłowa liczba: {liczbyStr[i]}");
        //        return;
        //    }
        //}

        //if (liczby.Length == 0)
        //{
        //    Console.WriteLine("Nie podano żadnych liczb.");
        //    return;
        //}

        //int najmniejsza = liczby[0];
        //int najwieksza = liczby[0];

        //for (int i = 1; i < liczby.Length; i++)
        //{
        //    if (liczby[i] < najmniejsza)
        //    {
        //        najmniejsza = liczby[i];
        //    }
        //    if (liczby[i] > najwieksza)
        //    {
        //        najwieksza = liczby[i];
        //    }
        //}

        //Console.WriteLine($"Najmniejsza liczba: {najmniejsza}");
        //Console.WriteLine($"Największa liczba: {najwieksza}");
    }
}