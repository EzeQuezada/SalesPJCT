
using Sales.Core.Core;

namespace Sales.Infraestructure.Entities;

public partial class RolMenu:BaseEntity
{
    public int Id { get; set; }
    public int? IdRol { get; set; }
    public int? IdMenu { get; set; }
    public virtual Menu IdMenuNavigation { get; set; }
    public virtual Rol IdRolNavigation { get; set; }
}