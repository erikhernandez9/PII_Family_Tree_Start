using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1, new Persona("Fernando", 20));
            Node n2 = new Node(2, new Persona("Fernando", 19));
            Node n3 = new Node(3, new Persona("Fernando", 18));
            Node n4 = new Node(4, new Persona("Fernando", 14));
            Node n5 = new Node(5, new Persona("Fernando", 14));
            Node n6 = new Node(6, new Persona("Fernando", 16));
            Node n7 = new Node(7, new Persona("Fernando", 12));
            Node n8 = new Node(8, new Persona("Fernando", 10));

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            n6.AddChildren(n8);

            // visitar el árbol aquí
        }
    }
}
