public class Program
{
    // Zad 1 Napisz funkcję, która zamienia wartości dwóch liczb przy użyciu ref.

    //static void Zamien(ref int a, ref int b)
    //{
    //    int temp = a;
    //    a = b;
    //    b = temp;
    //}

    // Zad 2 Napisz metodę, która próbuje zamienić tekst na liczbę całkowitą. Jeśli się nie uda, zwróci wartość domyślną 0.

    //static bool ParsujLiczbe(string input, out int liczba)
    //{
    //    return int.TryParse(input, out liczba);
    //}

    // Zad 3: Struktura Wektor3D

    //public struct Wektor3D
    //{
    //    public int x;
    //    public int y;
    //    public int z;

    //    public Wektor3D(int x, int y, int z)
    //    {
    //        this.x = x;
    //        this.y = y;
    //        this.z = z;
    //    }
    //}

    // Metoda obliczająca długość wektora
    //public static double DlugoscWektora(in Wektor3D w)
    //{
    //    return Math.Sqrt(Math.Pow(w.x, 2) + Math.Pow(w.y, 2) + Math.Pow(w.z, 2));
    //}

    // Zad 4 Napisz metodę, która oblicza średnią z dowolnej liczby podanych argumentów.

    //public static double Srednia(params int[] liczby)
    //{
    //    double suma = 0;
    //    double srednia = 0;

    //    foreach (int liczba in liczby)
    //    {
    //        suma += liczba;
    //    }

    //    srednia = suma / liczby.Length;
    //    return srednia;
    //}

    // Zad 5 Stwórz ref struct Macierz2x2, który przechowuje dwuwymiarową macierz i umożliwia operacje na niej bez kopiowania.

    //public ref struct Macierz2x2
    //{
    //    public double M11;
    //    public double M12;
    //    public double M21;
    //    public double M22;

    //    public Macierz2x2(double m11, double m12, double m21, double m22)
    //    {
    //        M11 = m11;
    //        M12 = m12;
    //        M21 = m21;
    //        M22 = m22;
    //    }

    //    public Macierz2x2 Transponuj()
    //    {
    //        return new Macierz2x2(M11, M12, M21, M22);
    //    }

    //    public override string ToString()
    //    {
    //        return $"[{M11}, {M12}]\n[{M21}, {M22}]";
    //    }
    //}

    // Zad 6 Napisz metodę, która zwraca referencję na największy element w tablicy i pozwala go zmienić.

    //public static ref int ZnajdzNajwiekszy(params int[] liczby)
    //{
    //    if (liczby == null || liczby.Length == 0)
    //    {
    //        throw new ArgumentException("Tablica nie moze byc pusta");
    //    }

    //    ref int max = ref liczby[0];

    //    for(int i = 1; i < liczby.Length; i++)
    //    {
    //        if (liczby[i] > max)
    //        {
    //            max = ref liczby[i];
    //        }
    //    }

    //    return ref max;
    //}

    // Zad 7 Napisz metodę, która rozszerza tablicę dynamicznie, dodając nowy element.
    //       Tablica powinna być przekazywana przez ref, aby zmiana była widoczna poza metodą.

    //public static void DodajElement(ref int[] tablica, int nowyElement)
    //{
    //    int[] nowaTablica = new int[tablica.Length + 1];

    //    for (int i = 0; i < tablica.Length; i++)
    //    {
    //        nowaTablica[i] = tablica[i];
    //    }

    //    nowaTablica[tablica.Length] = nowyElement;

    //    tablica = nowaTablica;
    //}

    // Zad 8 Metoda parsująca konfigurację

    //public static bool ParsujKonfiguracje(string[] linie, out Dictionary<string, string> config)
    //{
    //    config = new Dictionary<string, string>();

    //    foreach (var linia in linie)
    //    {
    //        // Pomijanie pustych linii
    //        if (string.IsNullOrWhiteSpace(linia))
    //            continue;

    //        // Próba podzielenia linii na klucz i wartość
    //        var czesci = linia.Split('=', 2); // Ograniczenie do dwóch elementów (klucz i wartość)

    //        // Sprawdzanie, czy linia jest poprawna (ma dokładnie 2 elementy)
    //        if (czesci.Length != 2 || string.IsNullOrWhiteSpace(czesci[0]) || string.IsNullOrWhiteSpace(czesci[1]))
    //        {
    //            config = null;
    //            return false; // Niepoprawny format, zwracamy false
    //        }

    //        // Dodanie do słownika, klucze są trimowane dla bezpieczeństwa
    //        config[czesci[0].Trim()] = czesci[1].Trim();
    //    }

    //    return true;
    //}

    // Zad 9 Zaimplementuj strukturę Macierz3x3, która przechowuje macierz 3x3 i posiada metodę Wyznacznik().
    // Skorzystaj z in, aby unikać niepotrzebnego kopiowania w funkcji liczącej wyznacznik.

    //public struct Macierz3x3
    //{
    //    public int a, b, c;
    //    public int d, e, f;
    //    public int g, h, i;

    //    public Macierz3x3(int a, int b, int c, int d, int e, int f, int g, int h, int i)
    //    {
    //        this.a = a;
    //        this.b = b;
    //        this.c = c;
    //        this.d = d;
    //        this.e = e;
    //        this.f = f;
    //        this.g = g;
    //        this.h = h;
    //        this.i = i;
    //    }
    //}

    //public static double Wyznacznik(in Macierz3x3 m)
    //{
    //    // Wyznacznik macierzy 3x3 = a(ei - fh) - b(di - fg) + c(dh - eg)
    //    double det = m.a * (m.e * m.i - m.f * m.h)
    //               - m.b * (m.d * m.i - m.f * m.g)
    //               + m.c * (m.d * m.h - m.e * m.g);
    //    return det;
    //}

    //public static (double srednia, double min, double max, double suma) Statystyki(params double[] liczby)
    //{
    //    if (liczby.Length == 0)
    //    {
    //        throw new ArgumentException("Musisz podać przynajmniej jedną liczbę.");
    //    }

    //    double suma = 0;
    //    double min = liczby[0];
    //    double max = liczby[0];

    //    foreach (var liczba in liczby)
    //    {
    //        suma += liczba;
    //        if (liczba < min) min = liczba;
    //        if (liczba > max) max = liczba;
    //    }

    //    double srednia = suma / liczby.Length;

    //    return (srednia, min, max, suma);
    //}

    static void Main()
    {
        // Zad 1: Test funkcji Zamien

        //int a = 5;
        //int b = 10;
        //Zamien(ref a, ref b);
        //Console.WriteLine($"{a}, {b}");

        // Zad 2: Test funkcji ParsujLiczbe

        //string input = "123";
        //if (ParsujLiczbe(input, out int liczba))
        //    Console.WriteLine($"Poprawnie sparsowano: {liczba}");
        //else
        //    Console.WriteLine("Nie udało się sparsować liczby.");

        // Zad 3: Test długości wektora

        //Wektor3D w = new Wektor3D(3, 4, 5);
        //Console.WriteLine(DlugoscWektora(in w));

        // Zad 4: Test obliczania średniej z dowolnej liczby arg

        //double wynik = Srednia(2, 4, 6, 8, 10);
        //Console.WriteLine(wynik);

        // Zad 5: Test na strukturze Macierz 2x2

        //Macierz2x2 m = new Macierz2x2(1, 2, 3, 4);
        //Macierz2x2 wynik = m.Transponuj();

        //Console.WriteLine("Macierz oryginalna:");
        //Console.WriteLine(m.ToString());

        //Console.WriteLine("\nMacierz transponowana:");
        //Console.WriteLine(wynik.ToString());

        // Zad 6: Test

        //int[] liczby = { 1, 5, 3, 9, 7 };
        //ref int max = ref ZnajdzNajwiekszy(liczby);
        //max = 100;
        //Console.WriteLine(string.Join(", ", liczby)); // 1, 5, 3, 100, 7

        // Zad 7: Test

        //int[] liczby = { 1, 2, 3 };
        //DodajElement(ref liczby, 4);
        //Console.WriteLine(string.Join(", ", liczby)); // 1, 2, 3, 4

        // Zad 8: Test

        //string[] linie = { "username=admin", "password=1234", "timeout=30" };

        //if (ParsujKonfiguracje(linie, out var config))
        //{
        //   Console.WriteLine(config["username"]); // admin
        //}
        //else
        //{
        //    Console.WriteLine("Nie udało się sparsować konfiguracji.");
        //}

        // Zad 9: Test

        //Macierz3x3 m = new Macierz3x3(1, 2, 3, 4, 5, 6, 7, 8, 9);

        //// Obliczamy wyznacznik
        //double det = Wyznacznik(in m);

        //// Wyświetlamy wynik
        //Console.WriteLine($"Wyznacznik macierzy: {det}");

        // Zad 10: Test

        //var (srednia, min, max, suma) = Statystyki(10, 20, 30, 40);
        //Console.WriteLine($"Średnia: {srednia}, Min: {min}, Max: {max}, Suma: {suma}");
    }
}