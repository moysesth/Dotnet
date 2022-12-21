using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cliente.interfaces;

namespace Cliente.entity
{
    internal class Clientes : xCliente
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string DocumentoCliente { get; set; }
        public string TipoCliente { get; set; }
    }
}
