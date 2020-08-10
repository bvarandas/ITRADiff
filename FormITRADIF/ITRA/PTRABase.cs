using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GI.Integracao.SecureClient.Domain.Models.TRA
{
    public class PTRABase
    {
        public class Header
        {

            public string TipoRegistro { get; set; } //2
            public string CodigoArquivo  { get; set; } //4
            public string CodigoUsuario { get; set; } //4
            public string CodigoOrigem { get; set; } //8
            public string CodigoDestino { get; set; } //4
            public string DataGeracaoArquivo { get; set; } //8 - AAAAMMDD
            public string DataMovimento { get; set; } //8 - AAAAMMDD
            public string Reserva { get; set; } //11

        }
        public class Body
        {
            public string TipoRegistro { get; set; } // 2
            public string SeuNumero { get; set; } // 9

            /*  Cedente  */
            public string CodigoClienteCedenteDigito { get; set; } // 8
            public string CodigoCarteiraCedenteDigito { get; set; } // 5

            /*  Cessionario  */
            public string CodigoUsuarioDigito { get; set; } // 6
            public string CodigoClienteDigito { get; set; } // 10
            public string CodigoCarteiraDigito { get; set; } // 5
            public string CodigoIsin { get; set; }          // 12
            public string DistribuicaoCodigoIsin { get; set; } // 3
            public string Quantidade { get; set; }   // 15
            public string MotivoTransferencia { get; set; } // 3
            public string TipoTransferencia { get; set; } // 1
            public string NumeroMovimento { get; set; } // 09 --->>>duplo comando
            public string TipoAtivo { get; set; } // 1
            public string Reserva { get; set; } // 11
        }

        public class Trailer
        {
            public string TipoRegistro { get; set; } //2
            public string CodigoArquivo { get; set; } //4
            public string CodigoUsuario { get; set; } //4
            public string CodigoOrigem { get; set; } //8
            public string CodigoDestino { get; set; } //4
            public string DataGeracaoArquivo { get; set; } //8 - AAAAMMDD
            public string TotalRegistros { get; set; } //8 - total de registros incluindo header and trailer
            public string Reserva { get; set; } //40
        }
    }
}
