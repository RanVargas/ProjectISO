using System.Runtime.Serialization;

namespace ProjectISO.Models
{
    [DataContract]
    public class TipoDeActivo
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public Activo Activo { get; set; }
        public int ActivoId { get; set; }
    }
}
