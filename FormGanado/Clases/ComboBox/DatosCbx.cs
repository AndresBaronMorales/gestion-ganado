using System.Collections.Generic;

namespace FormGanado.Clases.ComboBox
{
    internal class DatosCbx
    {
        private List<RanchoCbx> ranchos;
        private List<GanadoCbx> ganados;

        public List<RanchoCbx> Ranchos { get => ranchos; set => ranchos = value; }
        public List<GanadoCbx> Ganados { get => ganados; set => ganados = value; }

        public DatosCbx() {}
    }
}
