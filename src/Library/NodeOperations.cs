namespace Library;

public interface NodeOperations
{
    void Accept (CalcularEdadVisitor visitor);
    void Accept (CalcularViejoVisitor visitor);
}