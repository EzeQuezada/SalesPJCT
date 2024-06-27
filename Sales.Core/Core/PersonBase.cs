

namespace Sales.Core.Core
{
    public abstract class PersonBase : BaseEntity
    {
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
    }
}
