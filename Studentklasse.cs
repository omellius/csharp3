public class Student
{
    private string studentId;
    private string studentNavn;
    private decimal fag1;
    private decimal fag2;
    private decimal fag3;

    public Student(string id, string navn, decimal f1, decimal f2, decimal f3)
    {
        studentId = id;
        studentNavn = navn;
        fag1 = f1;
        fag2 = f2;
        fag3 = f3;
    }

    public void GetAggragate()
    {
        return fag1 + fag2 + fag3;
    }

    public decimal GetPercentage()
    {
        return (GetAggragate() / 60) * 100;
    }

Student s = new Student("S123", "Ola Nordmann", 18, 20, 15);

Console.WriteLine("Total Poengsum: " + s.GetAggragate());
Console.WriteLine("Prosentandel: " + s.GetPercentage());
