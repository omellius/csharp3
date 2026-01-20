using Forelesning2;

while (true)
{
    Console.WriteLine("Skriv inn ID (eller exit for å avslutte):");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
    {
        Console.WriteLine("Slutt!");
        break;
    }

    int id = int.Parse(input);

    Console.WriteLine("Skriv inn navn:");
    string navn = Console.ReadLine();

    Person p = new Person();
    p.SetId(id);
    p.SetNavn(navn);
    p.VisInformasjon();
}
