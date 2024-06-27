using Sales.Core.Interfaces;
using Sales.Infraestructure.Context;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Entities;


namespace Sales.Infraestructure.Repositories
{
    public class RolRepository : BaseRepository<Rol>,IRolRepository
    {
        private readonly SalesContext context;

        public RolRepository(SalesContext context) : base(context)
        {
            this.context = context;
        }
    }
}
