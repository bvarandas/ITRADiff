using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GI.Integracao.SecureClient.Domain.Models.TRA
{
    public class ITRA : DAT
    {
        public ITRABase.Header Header { get { return GetHeader(); } set {  } }
        public List<ITRABase.Body> Body { get { return GetBody(); } set { } }
        public ITRABase.Trailer Trailer { get { return GetTrailer(); } set { } }

        public ITRA()
        {
            Header = new ITRABase.Header();
            Body = new List<ITRABase.Body>();
            Trailer = new ITRABase.Trailer();

            this.NomeArquivoResposta = "PTRA";
            this.NomeArquivoRespostaErros = "ETRA";
        }

        private ITRABase.Header GetHeader()
        {
            var retorno = new ITRABase.Header();
            
            retorno.TipoRegistro        = TextoHeader.Substring(1, 2);
            retorno.CodigoArquivo       = TextoHeader.Substring(3, 4);
            retorno.CodigoUsuario       = TextoHeader.Substring(7, 4);
            retorno.CodigoOrigem        = TextoHeader.Substring(11, 4);
            retorno.CodigoDestino       = TextoHeader.Substring(15, 8);
            retorno.DataGeracaoArquivo  = TextoHeader.Substring(23, 8);
            retorno.DataMovimento       = TextoHeader.Substring(31, 8);
            retorno.Reserva             = TextoHeader.Substring(50, 62);

            return retorno;
        }

        private List<ITRABase.Body> GetBody()
        {
            var retorno = new List<ITRABase.Body>();
            
            var lines = TextoBody.Split('\r');

            foreach (string item in lines)
            {
                var line = new ITRABase.Body();
                line.SeuNumero                      = item.Substring(2,9);
                line.CodigoClienteCedenteDigito     = item.Substring(11,8);
                line.CodigoCarteiraCedenteDigito    = item.Substring(19,5);
                line.CodigoUsuarioDigito            = item.Substring(24,6);
                line.CodigoClienteDigito            = item.Substring(30,10);
                line.CodigoCarteiraDigito           = item.Substring(40,5);
                line.CodigoIsin                     = item.Substring(45,12);
                line.DistribuicaoCodigoIsin         = item.Substring(57,3);
                line.Quantidade                     = item.Substring(60,15);
                line.MotivoTransferencia            = item.Substring(75,3);
                line.TipoTransferencia              = item.Substring(78,1);
                line.TipoAtivo                      = item.Substring(79,1);
                line.Reserva                        = item.Substring(80,20);

                retorno.Add(line);
            }

            return retorno;
        }
        private ITRABase.Trailer GetTrailer()
        {
            var retorno = new ITRABase.Trailer();

            retorno.TipoRegistro        = TextoTrailer.Substring(01,02);
            retorno.CodigoArquivo       = TextoTrailer.Substring(3,4);
            retorno.CodigoUsuario       = TextoTrailer.Substring(7,4);
            retorno.CodigoOrigem        = TextoTrailer.Substring(11,4);
            retorno.CodigoDestino       = TextoTrailer.Substring(15,8);
            retorno.DataGeracaoArquivo  = TextoTrailer.Substring(23,8);
            retorno.TotalRegistros      = TextoTrailer.Substring(31,9);
            retorno.Reserva             = TextoTrailer.Substring(40,61);

            return retorno;
        }

    }

    public class DAT
    {
        public string NomeArquivoResposta { get; set; }
        public string NomeArquivoRespostaErros { get; set; }
        public string TextoHeader { get; set; }
        public string TextoBody { get; set; }
        public string TextoTrailer { get; set; }
    }
}
