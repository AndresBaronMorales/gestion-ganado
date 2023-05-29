using System;

namespace FormGanado.Clases.Registro
{
    internal class Ganado
    {
        private string rancho;
        private string propietario;
        private string tipoGanado;
        private string raza;
        private string marquilla;
        private string descripcion;
        private string fechaNacimiento;
        private int edad;
        private double peso;
        private double valorKg;
        private double valor;
        private double ventaValorKgProcentaje;
        private double ventaGananciaPorKilo;
        private double ventaGananciaTotal;
        private double ventaTotalVenta;

        public Ganado(string rancho,string propietario,string tipoGanado,string raza,string marquilla,string descripcion,string fechaNacimiento,double peso,double valorKg,double ventaValorKgProcentaje) {
            this.rancho = rancho;
            this.propietario = propietario;
            this.tipoGanado = tipoGanado;
            this.raza = raza;
            this.marquilla = marquilla;
            this.descripcion = descripcion;
            this.fechaNacimiento = fechaNacimiento;
            this.edad = ClacularEdadAnios();
            this.peso = peso;
            this.valorKg = valorKg;
            this.valor = CalcularValor();
            this.ventaValorKgProcentaje = ventaValorKgProcentaje;
            this.ventaGananciaPorKilo = CalcularVentaGananciaKg();
            this.ventaGananciaTotal = CalcularVentaGananciaTotal();
            this.ventaTotalVenta = CalcularVentaTotal();
        }

        public string Rancho { get => rancho; set => rancho = value; }
        public string Propietario { get => propietario; set => propietario = value; }
        public string TipoGanado { get => tipoGanado; set => tipoGanado = value; }
        public string Raza { get => raza; set => raza = value; }
        public string Marquilla { get => marquilla; set => marquilla = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Peso { get => peso; set => peso = value; }
        public double ValorKg { get => valorKg; set => valorKg = value; }
        public double Valor { get => valor; set => valor = value; }
        public double VentaValorKgProcentaje { get => ventaValorKgProcentaje; set => ventaValorKgProcentaje = value; }
        public double VentaGananciaPorKilo { get => ventaGananciaPorKilo; set => ventaGananciaPorKilo = value; }
        public double VentaGananciaTotal { get => ventaGananciaTotal; set => ventaGananciaTotal = value; }
        public double VentaTotalVenta { get => ventaTotalVenta; set => ventaTotalVenta = value; }

        //Metodos
        private int ClacularEdadAnios() {
            TimeSpan diferencia = DateTime.Now - DateTime.Parse(this.fechaNacimiento);
            double anios = Math.Floor(diferencia.TotalDays / 365);

            return Convert.ToInt16(anios);
        }

        private double CalcularValor() {
            double valor = this.peso * this.valorKg;
            return valor;
        }

        private double CalcularVentaGananciaKg() {
            double gananciaKg = this.ventaValorKgProcentaje * this.valorKg / 100;
            return gananciaKg;
        }

        private double CalcularVentaGananciaTotal() {
            double gananciaTotal = this.peso * this.ventaGananciaPorKilo;
            return gananciaTotal;
        }

        private double CalcularVentaTotal() {
            double totalVenta = this.ventaGananciaTotal + this.valor;
            return totalVenta;
        }
    }
}
