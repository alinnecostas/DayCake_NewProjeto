using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daycake
{
    public class ClienteItem
    {
        public int IDCliente { get; set; }
        public string nomeCliente { get; set; }

        public override string ToString()
        {
            return nomeCliente;
        }
    }
}