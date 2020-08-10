using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GI.Integracao.SecureClient.Domain.Models.TRA
{
    public class ItraModel
    {
        public ItraModel(string codCliente, string codISIN, string quantidade)
        {
            CodCliente = codCliente;
            CodISIN = codISIN;
            Quantidade = quantidade;
        }

        public string CodCliente { get; set; }
        public string CodISIN { get; set; }
        public string Quantidade { get; set; }
    }
}
