namespace Library;

public interface PersonaOperations : NodeOperations
{
    void Accept (CalcularLargoVisitor visitor);
}