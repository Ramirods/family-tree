namespace Library
{
    public class MaximaEdadVisitador : IVisitador
    {
        private int maximaEdad;

        public void Visitar(Node node)
        {
            if (node.Children.Count == 0 && node.persona.edad > maximaEdad)
            {
                maximaEdad = node.persona.edad;
            }
            else
            {
                foreach (var hijo in node.Children)
                {
                    Visitar(hijo);
                }
            }
        }

        public int ObtenerMaximaEdad()
        {
            return maximaEdad;
        }
    }

}
