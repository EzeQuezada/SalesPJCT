using Sales.Core.Interfaces;
using Sales.Infraestructure.Context;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Entities;


namespace Sales.Infraestructure.Repositories
{
    public class TipoDocumentoVentaRepository : BaseRepository<TipoDocumentoVenta>
    ,ITipoDocumentoVenta
    {
        private readonly SalesContext context;

        public TipoDocumentoVentaRepository(SalesContext context): base(context)
        {
            this.context = context;
        }
    }
}
