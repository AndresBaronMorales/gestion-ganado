using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace FormGanado.Clases.ComboBox
{
    internal class GetDatosCbx
    {
        private string ruta = @"C:\Datos\registrosCbx.json";
        private DatosCbx datos;

        public GetDatosCbx() {
            DeserializeJson();
        }

        public DatosCbx Datos { get => datos;}

        //Obtener datos del json
        private void DeserializeJson() {
            string datosJson = File.ReadAllText(this.ruta);
            this.datos = JsonConvert.DeserializeObject<DatosCbx>(datosJson);
        }

        //Get Rancho
        public List<string> GetRanchos() {
            List<string> ranchos = new List<string>();
            this.datos.Ranchos.ForEach(rancho => ranchos.Add(rancho.Rancho));
            return ranchos;
        }

        //Get Propietario Rancho
        public List<string> GetRanchoPropietarios(string rancho)
        {
            List<string> propietarios = new List<string>();
            foreach (var ranchoNombre in this.datos.Ranchos)
            {
                if (ranchoNombre.Rancho == rancho) {
                    propietarios = ranchoNombre.Propietarios;
                }
            }
            return propietarios;
        }

        //Get tipo de ganado
        public List<string> GetGanadoTipo()
        {
            List<string> ganados = new List<string>();
            this.datos.Ganados.ForEach(ganado => ganados.Add(ganado.Tipo));
            return ganados;
        }

        //Get razas
        public List<string> GetGanadoRazas(string tipo)
        {
            List<string> razas = new List<string>();
            foreach (var tipoGanado in this.Datos.Ganados)
            {
                if (tipoGanado.Tipo == tipo) {
                    tipoGanado.Razas.ForEach(nombreRaza => razas.Add(nombreRaza.Nombre));
                }
            }
            return razas;
        }

        //Get valor de kilo raza
        public double GetGanadoRazaValor(string tipo,string razaNombre) {

            double valor = 0;

            foreach (var ganado in this.datos.Ganados)
            {
                if (ganado.Tipo == tipo) {
                    foreach (var raza in ganado.Razas)
                    {
                        if (raza.Nombre == razaNombre) {
                            valor = raza.Valor;
                        }
                    }
                }
            }
            return valor;        
        }
    }
}
