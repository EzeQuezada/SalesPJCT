using Sales.Core.Interfaces;
using Sales.Core.Models;
using Sales.Infraestructure.Context;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Entities;

namespace Sales.Infraestructure.Repositories
{
    public class CategoriaRepository :BaseRepository<Categoria>,ICategoriaRepository
    {
        private readonly SalesContext context;

        public CategoriaRepository(SalesContext context):base(context)
        {
            this.context = context;
        }

        public List<CategoriaModel> GetCategories()
        {
            throw new NotImplementedException();
        }
    }
}
