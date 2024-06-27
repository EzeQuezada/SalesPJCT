
using Sales.Core.Core;
using System.ComponentModel.DataAnnotations;


namespace Sales.Infraestructure.Entities;

public partial class Rol : BaseEntity
{
    [Key]
    public int IdRol { get; set; }

    public virtual ICollection<RolMenu> RolMenus { get; set; } = new List<RolMenu>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}