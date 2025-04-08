using System.Net;
using System;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    // Zad 2
    // Stwórz własny wyjątek NegativeNumberException, który będzie rzucany, gdy użytkownik poda liczbę ujemną.
    // InvalidEmailException, który będzie wyrzucany gdy wpisany email jest nieprawidłowy.
    // InvalidPhoneNumberException, który będzie rzucany gdy numer telefonu nie jest w formacie 000 - 000 - 000 lub innym prawidłowym.
    // Program powinien demonstrować obsługę stworoznych wyjątków, przypadki brzegowe gdy dane wyjątki wystepują.

    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message) { }
    }

    public class InvalidEmailException : Exception
    {
        public InvalidEmailException(string message) : base(message) { }
    }
    public class InvalidPhoneNumberException : Exception
    {
        public InvalidPhoneNumberException(string message) : base(message) { }
    }

    public static void Main(string[] args)
    {
        // Zad 1
        // Napisz program, który prosi użytkownika o wprowadzenie dwóch liczb całkowitych.
        // Następnie program wykonuje dzielenie jednej liczby przez drugą i wyświetla wynik.
        // Jakie wyjątki mogą wystapić w czasie działania programu?
        // Obsłuż wystepujące wyjątki wyświetlając stosowne komunikaty w konsoli oraz dajac użytkownikowi mozliwość poprawy błędów.

        //try
        //{
        //    Console.Write("Podaj liczbę a: ");
        //    int a = int.Parse(Console.ReadLine());

        //    Console.Write("Podaj liczbę b: ");
        //    int b = int.Parse(Console.ReadLine());

        //    int result = a / b;
        //    Console.WriteLine($"Wynik dzielenia {a} przez {b} to: {result}");
        //}
        //catch (DivideByZeroException)
        //{
        //    Console.WriteLine("Błąd: Nie można dzielić przez zero!");
        //}
        //catch (FormatException)
        //{ 
        //    Console.WriteLine("Wprowadzono niepoprawny format liczby! Podaj liczby całkowite.");
        //}

        // Zad 2 Test:

        try
        {
            Console.WriteLine("Podaj liczbe: ");
            int a = int.Parse(Console.ReadLine());
            if (a < 0) throw new NegativeNumberException("Liczba nie może być ujemna!");

            Console.WriteLine("Podaj email: ");
            string email = Console.ReadLine();
            if (!email.Contains("@") || !email.Contains(".")) throw new InvalidEmailException("Niepoprawny format emaila!");

            Console.WriteLine("Podaj numer telefonu: ");
            string phoneNumber = Console.ReadLine();
            if (!Regex.IsMatch(phoneNumber, @"^\d{3}-\d{3}-\d{3}$")) throw new InvalidPhoneNumberException("Niepoprawny format numeru telefonu!");

            Console.WriteLine("Wszystkie dane są poprawne.");
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine($"Błąd liczby: {ex.Message}");
        }
        catch (InvalidEmailException ex)
        {
            Console.WriteLine($"Błąd emaila: {ex.Message}");
        }
        catch (InvalidPhoneNumberException ex)
        {
            Console.WriteLine($"Błąd numeru telefonu: {ex.Message}");
        }

        // Zad 3
        // Zasymuluj zapytania pod odpowiednie endpointy oraz obsłuż wyjątki(301, 404, 500) w zależności od kodu błędu:
        // 301 wyświetl w konsoli - Błąd: Przekierowanie(301) - Zasób został przeniesiony.
        // 404 wyświetl w konsoli - Błąd: Zasób nie znaleziony(404).
        // 500 wyświetl w konsoli - Błąd: Błąd serwera(500).
        // Proszę spróbować ponownie później.

        Console.Write("Podaj endpoint (np. /moved, /notfound, /ok, /error): ");
        string url = Console.ReadLine();

        try
        {
            HttpResponseMessage response = SimulateHttpRequest(url);
            Console.WriteLine($"✅ Odpowiedź OK: {(int)response.StatusCode} - {response.StatusCode}");
        }
        catch (HttpRequestException ex) when (ex.Message.Contains("301"))
        {
            Console.WriteLine("❌ Błąd: Przekierowanie (301) - Zasób został przeniesiony.");
        }
        catch (HttpRequestException ex) when (ex.Message.Contains("404"))
        {
            Console.WriteLine("❌ Błąd: Zasób nie znaleziony (404).");
        }
        catch (HttpRequestException ex) when (ex.Message.Contains("500"))
        {
            Console.WriteLine("❌ Błąd: Błąd serwera (500).\nProszę spróbować ponownie później.");
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"❌ Inny błąd HTTP: {ex.Message}");
        }

    }
    

    public static HttpResponseMessage SimulateHttpRequest(string url)
    {
        if (url == "/moved")
        {
            throw new HttpRequestException("301 - Moved Permanently");
        }
        else if (url == "/notfound")
        {
            throw new HttpRequestException("404 - Not Found");
        }
        else if (url == "/ok")
        {
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }
        else
        {
            throw new HttpRequestException("500 - Internal Server Error");
        }
    }
}