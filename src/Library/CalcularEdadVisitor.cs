using System;
namespace Library;

public class CalcularEdadVisitor : Visitor
{
    public override void Visit(Persona person)
    {
        int total = person.edadTotal();
        Console.WriteLine($"La suma total de edades es {total}");
    }

    public override void Visit(Node node)
    {
        int total = node.TotalNumero();
        Console.WriteLine($"La suma total de edades es {total}");
    }
}