using Newtonsoft.Json;
using System.IO;

namespace FormGanado.Clases.Registro
{
    internal class RegistroGanado
    {
        private string ruta = @"C:\Datos\registrosGanado.json";
        private Ganado ganado;

        public RegistroGanado(Ganado ganado) {
            this.ganado = ganado;
            RegistrarGanado();
        }

        public Ganado Ganado { get => ganado; set => ganado = value; }

        private void RegistrarGanado(){
            string registroJson = JsonConvert.SerializeObject(this.ganado);
            string datosRegistrados = File.ReadAllText(this.ruta);
            
            if (datosRegistrados == "") datosRegistrados = "[]";
            if (datosRegistrados == "[]")
            {
                datosRegistrados = datosRegistrados.Insert(datosRegistrados.Length - 1, registroJson);
            }
            else {
                datosRegistrados = datosRegistrados.Insert(datosRegistrados.Length - 1, $",{registroJson}");
            }

            File.WriteAllText(this.ruta, datosRegistrados);
        }
    }
}
