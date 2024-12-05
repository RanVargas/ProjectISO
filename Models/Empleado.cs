using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ProjectISO.Models
{
    public enum TipoPersona
    {
        Fisica = 0,
        Legal = 1,

    }
    [DataContract]
    public class Empleado
    {
        /*
         Id
	Nombre
	Cedula
	Depart
	Tip Persona
	Fecha Ing
	Estado

         */
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(13)]
        public string Cedula { get; set; }
        public TipoPersona TipoPersona { get; set; }
        [Required]
        public DateOnly FechaIngreso { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        
        public Empleado() { }
        public Empleado(int id, string nombre, string cedula, TipoPersona tipoPersona, DateOnly fechaIngreso, string estado, Departamento departamento)
        {
            Id = id;
            Nombre = nombre;
            Cedula = cedula;
            TipoPersona = tipoPersona;
            FechaIngreso = fechaIngreso;
            Estado = estado;
            Departamento = departamento;
        }
    }
}
