using System;
using System.IO;

public class Program
{
    // Metoda, która pozwala wyjść przez ESC
    private static string ReadLineWithEscape()
    {
        string input = "";
        while (true)
        {
            var key = Console.ReadKey(intercept: true); 

            if (key.Key == ConsoleKey.Escape) 
            {
                return null;
            }
            else if (key.Key == ConsoleKey.Enter) 
            {
                Console.WriteLine();
                return input;
            }
            else if (key.Key == ConsoleKey.Backspace && input.Length > 0)
            {
                input = input.Remove(input.Length - 1);
                Console.Write("\b \b");  
            }
            else if (!char.IsControl(key.KeyChar))  
            {
                input += key.KeyChar;
                Console.Write(key.KeyChar);  
            }
        }
    }

    public static void Main(string[] args)
    {
        // Zad 1
        // Napisz program, który zapisze do pliku tekstowego wynik.txt tekst który użytkownik wpisze w konsoli.
        // Program powinien działać do momentu wciśnięcia klawisza ESC.

        Console.WriteLine("Wpisz tekst, który będzie zapisany do pliku [ESC - wyjście]");
        string filePath = "wynik.txt";

        using (StreamWriter writer = new StreamWriter(filePath, append: true))
        {
            while (true)
            {
                string tekst = ReadLineWithEscape();  // Nasza własna metoda sprawdzająca ESC

                if (tekst == null)  // Jeśli wciśnięto ESC
                {
                    break;
                }

                if (!string.IsNullOrEmpty(tekst))
                {
                    writer.WriteLine(tekst);
                    writer.Flush();
                }
            }
            Console.WriteLine("Zakończono zapisywanie do pliku.");
        }

        // Zad 2
        // Napisz program, który odczytuje zawartość pliku wynik.txt i wyświetla ją na ekranie.

        string filePath = "wynik.txt";

        if (File.Exists(filePath))
        {
            Console.WriteLine($"Zawartosc pliku {filePath}:");
            using (StreamReader reader = new StreamReader(filePath))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        else
        {
            Console.WriteLine($"Plik {filePath} nie istnieje!");
        }

        Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();

        // Zad 3
        //Napisz program w języku C#, który skopiuje plik ze ścieżki podanej jako pierwszy argument do lokalizacji podanej jako drugi argument.
        // Program powinien obsługiwać wyjątki, takie jak:

        // Brak pliku źródłowego.
        // Brak uprawnień do odczytu / zapisu.
        // Przerwanie operacji przez użytkownika, jeśli plik docelowy już istnieje.
        // Program powinien przyjmować ścieżki do plików jako argumenty wiersza poleceń i informować użytkownika o sukcesie lub wystąpieniu błędu.

        if (args.Length != 2)
        {
            Console.WriteLine("Użycie: program.exe <plik_źródłowy> <plik_docelowy>");
            return;
        }

        string path1 = args[0];
        string path2 = args[1];

        try
        {
            if (!File.Exists(path1))
            {
                throw new FileNotFoundException($"Plik źródłowy {path1} nie istnieje.");
            }

            if (File.Exists(path2))
            {
                Console.WriteLine($"Plik docelowy {path2} już istnieje. Czy chcesz go nadpisać? (T/N)");
                var input = Console.ReadKey(true);

                if (input.Key != ConsoleKey.T)
                {
                    Console.WriteLine("Operacja została anulowana przez użytkownika.");
                    return;
                }
            }

            File.Copy(path1, path2, true);
            Console.WriteLine($"Plik został pomyślnie skopiowany z:\n{path1}\ndo:\n{path2}");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Błąd: Brak uprawnień do odczytu lub zapisu pliku.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Błąd I/O: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił nieoczekiwany błąd: {ex.Message}");
        }

        // Zad 4
        // Napisz program w języku C#, który zapisuje do pliku binarnego plik.bin różne typy danych, takie jak:
        // Liczba całkowita(int)
        // Liczba zmiennoprzecinkowa(double)
        // Pojedynczy znak(char)
        // Ciąg znaków(string) Następnie program powinien odczytać zapisane dane i wyświetlić je w konsoli.
        // Zapewnij obsługę wyjątków, aby program nie przerywał działania w przypadku błędów wejścia / wyjścia.

        string filePath = "plik.bin";

        int liczbaCalkowita = 42;
        double liczbaZmiennoprzecinkowa = 3.14159;
        char znak = 'A';
        string tekst = "Hello, world!";

        // Zapis do pliku binarnego
        try
        {
            Console.WriteLine("Rozpoczynanie zapisu do pliku binarnego...");
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(liczbaCalkowita);
                writer.Write(liczbaZmiennoprzecinkowa);
                writer.Write(znak);
                writer.Write(tekst);
                Console.WriteLine("Dane zostały zapisane do pliku binarnego.");
            }
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Brak uprawnień do zapisu: {ex.Message}");
            return;
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Blad zapisu do pliku: {ex.Message}");
            return;
        }

        // Odczyt z pliku binarnego
        try
        {
            Console.WriteLine("\nRozpoczynanie odczytu z pliku binarnego...");
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                int odczytanaInt = reader.ReadInt32();
                double odczytanaDouble = reader.ReadDouble();
                char odczytanyChar = reader.ReadChar();
                string odczytanyString = reader.ReadString();

                Console.WriteLine("\n📥 Odczytane dane z pliku binarnego:");
                Console.WriteLine($"Liczba całkowita: {odczytanaInt}");
                Console.WriteLine($"Liczba zmiennoprzecinkowa: {odczytanaDouble}");
                Console.WriteLine($"Znak: {odczytanyChar}");
                Console.WriteLine($"Tekst: {odczytanyString}");
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Plik nie znaleziony: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Blad odczytu z pliku: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystapil nieoczekiwany blad: {ex.Message}");
        }

        // Czekanie na naciśnięcie klawisza, aby nie zamknąć konsoli od razu
        Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadLine();
    }