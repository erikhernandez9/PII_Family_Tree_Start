using System;
namespace Library;

public class CalcularLargoVisitor
{
    public void Visit(Persona person)
    {
        string total = person.nombreMasLargo();
        Console.WriteLine($"El nombre mas largo es {total}");
    }
}