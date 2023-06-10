namespace Library

{
    public class NombreMasLargoVisitador : IVisitador
    {
        private string nombreMasLargo = "";

        public void Visitar(Node node)
        {
            if (node.persona.nombre.Length > nombreMasLargo.Length)
            {
                nombreMasLargo = node.persona.nombre;
            }

            foreach (var hijo in node.Children)
            {
                Visitar(hijo);
            }
        }

        public string ObtenerNombreMasLargo()
        {
            return nombreMasLargo;
        }
    }
}