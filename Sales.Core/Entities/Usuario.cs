
using Sales.Core.Core;


namespace Sales.Infraestructure.Entities;

public partial class Usuario : PersonBase
{
    public int Id { get; set; }
    public int? IdRol { get; set; }
    public string? UrlFoto { get; set; }
    public string? NombreFoto { get; set; }
    public string? Clave { get; set; }
    public virtual Rol? IdRolNavigation { get; set; }
    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}