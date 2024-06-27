
using Sales.Core.Interfaces;
using Sales.Infraestructure.Context;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Entities;


namespace Sales.Infraestructure.Repositories
{
    public class NegocioRepository : BaseRepository<Negocio>, INegocioRepository
    {
        private readonly SalesContext context;

        public NegocioRepository(SalesContext context) : base(context)
        {
            this.context = context;
        }
    }
}
