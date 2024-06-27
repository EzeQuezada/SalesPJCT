
using Sales.Core.Core;


namespace Sales.Infraestructure.Entities;

public partial class Producto : BaseEntity
{
    public int Id { get; set; }

    public string? CodigoBarra { get; set; }

    public string? Marca { get; set; }

    public int? IdCategoria { get; set; }

    public int? Stock { get; set; }

    public string? UrlImagen { get; set; }

    public string? NombreImagen { get; set; }

    public decimal? Precio { get; set; }

    public virtual Categoria? IdCategoriaNavigation { get; set; }
}