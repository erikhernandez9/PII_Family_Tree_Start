using System.Text;
namespace Library;
public abstract class Visitor
{ 
    public abstract void Visit(Node node);
    public abstract void Visit(Persona person);
}