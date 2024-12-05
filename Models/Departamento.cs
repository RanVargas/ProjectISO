using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ProjectISO.Models
{
    [DataContract]
    public class Departamento
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
        public ICollection<Activo> Activos { get; set; }

        public Departamento(){ }

        public Departamento(int id, string descripcion, string estado, ICollection<Empleado> empleados, ICollection<Activo> activos)
        {
            Id = id;
            Descripcion = descripcion;
            Estado = estado;
            Empleados = empleados;
            Activos = activos;
        }
    }
}
