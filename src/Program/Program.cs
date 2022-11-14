using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);
            Node n8 = new Node(8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            n6.AddChildren(n8);

            Persona p1 = new Persona("Erik", 20);
            Persona p2 = new Persona("Fernando", 18);
            Persona p3 = new Persona("Fernandooo", 17);
            Persona p4 = new Persona("Fernando", 15);
            Persona p5 = new Persona("Fernando", 15);
            Persona p6 = new Persona("Fernando", 14);
            Persona p7 = new Persona("Fernando", 16);
            Persona p8 = new Persona("Fernando", 13);

            p1.AddChildren(p2);
            p1.AddChildren(p3);

            p2.AddChildren(p4);
            p2.AddChildren(p5);

            p3.AddChildren(p6);
            p3.AddChildren(p7);

            p6.AddChildren(p8);

            CalcularEdadVisitor edad = new CalcularEdadVisitor();
            CalcularLargoVisitor largo = new CalcularLargoVisitor();
            CalcularViejoVisitor viejo = new CalcularViejoVisitor();

            edad.Visit(p1);
            edad.Visit(n1);

            largo.Visit(p1);

            viejo.Visit(p1);
            viejo.Visit(n1);


            // visitar el árbol aquí
        }
    }
}
