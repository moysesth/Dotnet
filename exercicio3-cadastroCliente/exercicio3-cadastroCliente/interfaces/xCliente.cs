using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.interfaces
{
    internal interface xCliente
    {
        int IdCliente { get; set; }
        string NomeCliente { get; set; }
        string DocumentoCliente { get; set; }
        string TipoCliente { get; set; }
    }
}
