using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace FormGanado.Clases.Registro
{
    internal class DatosRegistros
    {
        private string ruta = @"C:\Datos\registrosGanado.json";
        private List<Ganado> ganados;

        public DatosRegistros() {
            DeserializeJson();
        }

        public List<Ganado> Ganados { get => ganados; set => ganados = value; }

        //Obteniendo los datos
        private void DeserializeJson() {
            string datosJson = File.ReadAllText(this.ruta);
            if (datosJson != "") this.ganados = JsonConvert.DeserializeObject<List<Ganado>>(datosJson);
        }
    }
}
