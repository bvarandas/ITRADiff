using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GI.Integracao.SecureClient.Domain.Models.TRA
{
    public class PTRA : DAT
    {
        public PTRABase.Header Header { get { return GetHeader(); } set { } }
        public List<PTRABase.Body> Body { get { return GetBody(); } set { } }
        public PTRABase.Trailer Trailer { get { return GetTrailer(); } set { } }

        public PTRA()
        {
            Header = new PTRABase.Header();
            Body = new List<PTRABase.Body>();
            Trailer = new PTRABase.Trailer();

            //this.NomeArquivoResposta = "PTRA";
            //this.NomeArquivoRespostaErros = "ETRA";
        }

        public  PTRABase.Header GetHeader()
        {
            var retorno = new PTRABase.Header();

            retorno.TipoRegistro = TextoHeader.Substring(0, 2);
            retorno.CodigoArquivo = TextoHeader.Substring(2, 4);
            retorno.CodigoUsuario = TextoHeader.Substring(6, 4);
            retorno.CodigoOrigem = TextoHeader.Substring(10, 8);
            retorno.CodigoDestino = TextoHeader.Substring(18, 4);
            retorno.DataGeracaoArquivo = TextoHeader.Substring(22, 8);
            retorno.DataMovimento = TextoHeader.Substring(30, 8);
            retorno.Reserva = TextoHeader.Substring(38, 62);

            return retorno;
        }

        public List<PTRABase.Body> GetBody()
        {
            var retorno = new List<PTRABase.Body>();

            PTRABase.Body line = null;

            var lines = TextoBody.Split('\r');

            foreach (string item in lines)
            {
                if (item.Length < 3) continue;
                line = new PTRABase.Body();
                line.SeuNumero = item.Substring(3, 9);
                line.CodigoClienteCedenteDigito = item.Substring(12, 8);
                line.CodigoCarteiraCedenteDigito = item.Substring(20, 5);
                line.CodigoUsuarioDigito = item.Substring(25, 6);
                line.CodigoClienteDigito = item.Substring(31, 10);
                line.CodigoCarteiraDigito = item.Substring(41, 5);
                line.CodigoIsin = item.Substring(46, 12);
                line.DistribuicaoCodigoIsin = item.Substring(58, 3);
                line.Quantidade = item.Substring(61, 15);
                line.MotivoTransferencia = item.Substring(76, 3);
                line.TipoTransferencia = item.Substring(79, 1);
                line.NumeroMovimento = item.Substring(80, 9);
                line.TipoAtivo = item.Substring(89, 1);
                line.Reserva = item.Substring(90, 11);

                retorno.Add(line);
            }

            return retorno;
        }
        public  PTRABase.Trailer GetTrailer()
        {
            var retorno = new PTRABase.Trailer();

            retorno.TipoRegistro = TextoTrailer.Substring(0, 2);
            retorno.CodigoArquivo = TextoTrailer.Substring(2, 4);
            retorno.CodigoUsuario = TextoTrailer.Substring(6, 4);
            retorno.CodigoOrigem = TextoTrailer.Substring(10, 8);
            retorno.CodigoDestino = TextoTrailer.Substring(18, 4);
            retorno.DataGeracaoArquivo = TextoTrailer.Substring(22, 8);
            retorno.TotalRegistros = TextoTrailer.Substring(30, 9);
            retorno.Reserva = TextoTrailer.Substring(39, 61);

            return retorno;
        }
    }
}
