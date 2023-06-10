using System;

namespace Library
{
    public class SumaEdadesVisitador : IVisitador
    {
        private int sumaEdades;

        public void Visitar(Node node)
        {
            sumaEdades += node.persona.edad;
            foreach (var hijo in node.Children)
            {
                Visitar(hijo);
            }
        }

        public int ObtenerSumaEdades()
        {
            return sumaEdades;
        }
    }
}
