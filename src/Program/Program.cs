using System;
using Library;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Node n1 = new Node(1);
            // Node n2 = new Node(2);
            // Node n3 = new Node(3);
            // Node n4 = new Node(4);
            // Node n5 = new Node(5);
            // Node n6 = new Node(6);
            // Node n7 = new Node(7);

            // n1.AddChildren(n2);
            // n1.AddChildren(n3);

            // n2.AddChildren(n4);
            // n2.AddChildren(n5);

            // n3.AddChildren(n6);
            // n3.AddChildren(n7);

            // // visitar el árbol aquí


            // ## Parte 2: Árbol genealógico

            // Crear en el `Program.cs` una estuctura de árbol de Personas para representar un árbol genealógico. Incluyan al menos 8 personas.
            Node n1 = new Node(1, "Juan", new List<Node>(), new Persona("Juan", 50));
            Node n2 = new Node(2, "Pedro", new List<Node>(), new Persona("Pedro", 30));
            Node n3 = new Node(3, "Maria", new List<Node>(), new Persona("Maria", 40));
            Node n4 = new Node(4, "Jose", new List<Node>(), new Persona("Jose", 20));
            Node n5 = new Node(5, "Ana", new List<Node>(), new Persona("Ana", 10));
            Node n6 = new Node(6, "Luis", new List<Node>(), new Persona("Luiasdasdads", 5));
            Node n7 = new Node(7, "Luisa", new List<Node>(), new Persona("Luisa", 2));
            Node n8 = new Node(8, "Carlos", new List<Node>(), new Persona("Carlos", 1));

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            n4.AddChildren(n8);

            // Crear un visitador que recorra el árbol y calcule la suma de las edades de todas las personas. 

            SumaEdadesVisitador visitador = new SumaEdadesVisitador();
            visitador.Visitar(n1);
            Console.WriteLine(visitador.ObtenerSumaEdades());

            MaximaEdadVisitador visitadorMaxEdad = new MaximaEdadVisitador();
            visitadorMaxEdad.Visitar(n1);
            int maxEdad = visitadorMaxEdad.ObtenerMaximaEdad();
            Console.WriteLine("Máxima edad entre los hijos: " + maxEdad);

            NombreMasLargoVisitador visitadorNombreLargo = new NombreMasLargoVisitador();
            visitadorNombreLargo.Visitar(n1);
            string nombreLargo = visitadorNombreLargo.ObtenerNombreMasLargo();
            Console.WriteLine("Nombre más largo: " + nombreLargo);


        }
    }
}
