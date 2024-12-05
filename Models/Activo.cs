using System.Runtime.Serialization;

namespace ProjectISO.Models
{
	[DataContract]
    public class Activo
    {
		public int Id { get; set; }
		public string Descripcion { get; set; }
        public Departamento Departamento { get; set; }
		public int DepartamentoId { get; set; }
		public TipoDeActivo TipoDeActivo { get; set; }
		public string CuentaCompra {  get; set; }
		public string CuentaDepresiacion { get; set; }
		public string Estado { get; set; }
		public DateOnly FechaRegistro { get; set; }
		public double ValorCompra { get; set; }
		public double DepresiacionAcumulada { get; set; }
		public double TiempoDepresiacion { get; set; }

        public Activo() { }

        public Activo(int id, string descripcion, Departamento departamento, int departamentoId, TipoDeActivo tipoDeActivo, string cuentaCompra, string cuentaDepresiacion, string estado, DateOnly fechaRegistro, double valorCompra, double depresiacionAcumulada, double tiempoDepresiacion)
        {
            Id = id;
            Descripcion = descripcion;
            Departamento = departamento;
            DepartamentoId = departamentoId;
            TipoDeActivo = tipoDeActivo;
            CuentaCompra = cuentaCompra;
            CuentaDepresiacion = cuentaDepresiacion;
            Estado = estado;
            FechaRegistro = fechaRegistro;
            ValorCompra = valorCompra;
            DepresiacionAcumulada = depresiacionAcumulada;
            TiempoDepresiacion = tiempoDepresiacion;
        }
    }
}
