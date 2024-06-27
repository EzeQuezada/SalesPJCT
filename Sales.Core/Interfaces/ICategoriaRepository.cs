using Sales.Core.Core;
using Sales.Core.Models;
using Sales.Infraestructure.Entities;


namespace Sales.Core.Interfaces
{
    public interface ICategoriaRepository : IBaseRepository<Categoria>
    {
        List<CategoriaModel> GetCategories();

    }
}
