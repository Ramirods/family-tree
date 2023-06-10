using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;

        private List<Node> children = new List<Node>();


        public Persona persona;

        public int Number
        {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children
        {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number, string name, List<Node> childrens, Persona persona)
        {
            this.number = number;
            this.children = childrens;
            this.persona = persona;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

    }
}
