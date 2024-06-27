
using Sales.Core.Core;


namespace Sales.Infraestructure.Entities;

public partial class Venta : BaseEntity
{
    public int Id { get; set; }

    public string? NumeroVenta { get; set; }

    public int? IdTipoDocumentoVenta { get; set; }

    public int? IdUsuario { get; set; }

    public string? CocumentoCliente { get; set; }

    public string? NombreCliente { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? ImpuestoTotal { get; set; }

    public decimal? Total { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual TipoDocumentoVenta? IdTipoDocumentoVentaNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}