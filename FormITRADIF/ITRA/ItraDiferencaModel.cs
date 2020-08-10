using GI.Integracao.SecureClient.Domain.Models.TRA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GI.Integracao.SecureClient.Domain.Models.TRA
{
    public class ItraDiferencaModel : ItraModel
    {
        public string Diferenca { get; set; }
        public ItraDiferencaModel(string diferenca, string codCliente, string codISIN, string quantidade) : base(codCliente, codISIN, quantidade)
        {
            Diferenca = diferenca;
        }

        
    }
}
