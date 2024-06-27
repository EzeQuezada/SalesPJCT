
using Sales.Core.Core;
using System.ComponentModel.DataAnnotations;

namespace Sales.Infraestructure.Entities;

public partial class TipoDocumentoVenta:BaseEntity
{
    [Key]
    public int IdDocVenta { get; set; }
    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}