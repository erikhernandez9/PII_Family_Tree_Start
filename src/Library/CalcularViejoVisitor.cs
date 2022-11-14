using System;
namespace Library;

public class CalcularViejoVisitor : Visitor
{
    public override void Visit(Persona person)
    {
        string total = person.masViejo();
        Console.WriteLine($"El mas viejo es {total}");
    }

    public override void Visit(Node node)
    {
        int total = node.masGrande();
        Console.WriteLine($"El mas viejo es {total}");
    }
}