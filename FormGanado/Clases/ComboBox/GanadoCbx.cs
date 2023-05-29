using System.Collections.Generic;

namespace FormGanado.Clases.ComboBox
{
    internal class GanadoCbx
    {
        private string tipo;
        private List<RazaCbx> razas;

        public string Tipo { get => tipo; set => tipo = value; }
        public List<RazaCbx> Razas { get => razas; set => razas = value; }
    }
}
