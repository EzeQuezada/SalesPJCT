using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Infraestructure.Exceptions
{
    public class CategoriaDataException : Exception
    {
        public CategoriaDataException(string message): base(message)
        {
            //Logica para enviar el correo y loggear el error
        }
    }
}
