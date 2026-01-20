public class MatteKlasse
{
    public int Pluss(int a, int b)
    {
        return a + b;
    }

    public int Minus(int a, int b)
    {
        return a - b;
    }

    public int Gange(int a, int b)
    {
        return a * b;
    }

    public double Dele(int a, int b)
    {
        return a / b;
    }
}

MatteKlasse matte = new MatteKlasse();

Console.WriteLine("Skriv inn det første tallet")
int tall1 = int.Parse(Console.ReadLine());

Console.WriteLine("Skriv inn det andre tallet")
int tall2 = int.Parse(Console.ReadLine());

Console.WriteLine("Velg en operasjon: +, -, *, /");
string operasjon = Console.ReadLine();

int resultat = 0;

if (operasjon == "+")
    resultat = matte.Pluss(tall1, tall2);
else if (operasjon == "-")
    resultat = matte.Minus(tall1, tall2);
else if (operasjon == "*")
    resultat = matte.Gange(tall1, tall2);
else if (operasjon == "/")
    resultat = matte.Dele(tall1, tall2);

Console.WriteLine("Resultatet er: " + resultat);


