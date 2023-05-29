using System.Collections.Generic;

namespace FormGanado.Clases.ComboBox
{
    internal class RanchoCbx
    {
        private string rancho;
        private List<string> propietarios;

        public string Rancho { get => rancho; set => rancho = value; }
        public List<string> Propietarios { get => propietarios; set => propietarios = value; }
    }
}
