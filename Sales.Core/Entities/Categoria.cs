

using Sales.Core.Core;
using System.ComponentModel.DataAnnotations;

namespace Sales.Infraestructure.Entities;

public partial class Categoria:BaseEntity
{
    [Key]
    public int CategoriaId { get; set; }
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}