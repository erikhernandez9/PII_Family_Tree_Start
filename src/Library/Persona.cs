using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library;
    public class Persona : PersonaOperations
    {
        public string Nombre {get; set;}
        public int Edad {get;set;}

        private List<Persona> children = new List<Persona>();

        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public int edadTotal ()
        {
            int totalEdades = this.Edad;
            foreach(Persona persona in this.children)
            {
                totalEdades += persona.Edad;
            }
            return totalEdades;
        }

        public string masViejo()
        {
            int viejo = this.Edad;
            string nombreMasViejo = this.Nombre;
            foreach (Persona persona in this.children)
            {
                if (persona.Edad > viejo)
                {
                    viejo = persona.Edad;
                    nombreMasViejo = persona.Nombre;
                }
            }
            return nombreMasViejo;
        }

        public string nombreMasLargo()
        {
            int largo = this.Nombre.Length;
            string nombreLargo = this.Nombre;

            foreach (Persona persona in this.children)
            {
                if (persona.Nombre.Length > largo)
                {
                    largo = persona.Nombre.Length;
                    nombreLargo = persona.Nombre;
                }
            }
            return nombreLargo;
        }

        public void AddChildren(Persona n)
        {
            this.children.Add(n);
        }

        public void Accept (CalcularEdadVisitor visitor)
        {
            visitor.Visit(this);
        }
        public void Accept (CalcularViejoVisitor visitor)
        {
            visitor.Visit(this);
        }
        public void Accept (CalcularLargoVisitor visitor)
        {
            visitor.Visit(this);
        }
    }