class Program
{

    static void Main(string[] args)
    {
        string tekst = "";
        string koniec = "quit";
        while(tekst !=koniec)
        {
            Console.WriteLine("Wprowadz tekst: ");
            tekst = Console.ReadLine();
        }

    }
}