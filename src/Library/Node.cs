using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node : NodeOperations
    {
        private int number;

        private List<Node> children = new List<Node>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number)
        {
            this.number = number;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public int TotalNumero()
        {
            int total = this.Number;
            foreach(Node node in this.Children)
            {
                total += node.number;
            }
            return total;
        }

        public int masGrande()
        {
            int grande = this.Number;
            foreach (Node node in this.children)
            {
                if (node.Number > grande)
                {
                    grande = node.Number;
                }
            }
            return grande;
        }
        public void Accept(CalcularEdadVisitor visitor)
        {
            visitor.Visit(this);
        }
        public void Accept(CalcularViejoVisitor visitor)
        {
            visitor.Visit(this);
        }   
    }
}
