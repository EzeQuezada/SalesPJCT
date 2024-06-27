

namespace Sales.Core.Models
{
    public abstract class BaseModel
    {
        public string? Descripcion { get; set; }
        public bool EsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public DateTime FechaMod {  get; set; }
        public int IdUsuarioMod {  get; set; }

    }
}
