using GI.Integracao.SecureClient.Domain.Models.TRA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormITRADIF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<ItraModel> ListaItraMacro = new List<ItraModel>();
        private List<ItraModel> ListaItraSistema = new List<ItraModel>();

        private void btnCarregarItraMacro_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            openFileDialogItraMacro.InitialDirectory = "C:\\BTC";
            openFileDialogItraMacro.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialogItraMacro.FilterIndex = 2;
            openFileDialogItraMacro.RestoreDirectory = true;

            if (openFileDialogItraMacro.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialogItraMacro.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialogItraMacro.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }

                this.ListaItraMacro = this.LeituraITRA(fileContent);

                lblItraMacroCarregado.Text = "Dados do ITRA da MACRO Caarregados com sucesso";
            }

        }

        private void btnCarregarItraSistema_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            openFileDialogItraSistema.InitialDirectory = "C:\\BTC";
            openFileDialogItraSistema.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialogItraSistema.FilterIndex = 2;
            openFileDialogItraSistema.RestoreDirectory = true;

            if (openFileDialogItraSistema.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialogItraSistema.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialogItraSistema.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }

                this.ListaItraSistema = this.LeituraITRA(fileContent);

                lblItraSistemaCarregado.Text = "Dados do ITRA do SISTEMA Caarregados com sucesso";
            }
        }

        private List<ItraModel> LeituraITRA(string content)
        {
            var retorno = new List<ItraModel>();
            try
            {
                ITRA itra = new ITRA();
                string[] lines = content.Split('\n');
                int i = 0;
                int total = lines.Length-2;

                string body = string.Empty;

                foreach (var line in lines)
                {
                    if (i == 0 || i == total)
                    {
                        i++;
                        continue;
                    }

                    if (line!= "")
                        body += line;

                    i++;
                }
                itra.TextoBody = body.Remove(body.Length-2, 2);
                var list = itra.Body;
                list.ForEach(it => {
                    retorno.Add(new ItraModel(it.CodigoClienteDigito.ToString(), it.CodigoIsin.ToString(), it.Quantidade.ToString()));
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retorno;
        }

        private void btnCompararItras_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ListaItraMacro == null || this.ListaItraMacro.Count == 0)
                {
                    MessageBox.Show("Por favor, carregar o ITRA da Macro", "Comparar arquivos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (this.ListaItraSistema == null || this.ListaItraSistema.Count == 0)
                {
                    MessageBox.Show("Por favor, carregar o ITRA da Sistema", "Comparar arquivos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var listIguais = this.ListaItraMacro.Intersect(this.ListaItraSistema, new ItraComparer());

                var sourceIguais = new BindingSource(listIguais, null);

                gridItraIguais.DataSource = sourceIguais;


                var listDiferencasSistema = this.ListaItraSistema.Except(this.ListaItraMacro, new ItraComparer()).ToList();
                var listDiferencasMacro = this.ListaItraMacro.Except(this.ListaItraSistema, new ItraComparer()).ToList();


                var listaDiferencas = new List<ItraDiferencaModel>();

                listDiferencasSistema.ForEach(l =>
                {
                    listaDiferencas.Add(new ItraDiferencaModel("Somente sistema", l.CodCliente, l.CodISIN, l.Quantidade));
                });

                listDiferencasMacro.ForEach(l =>
                {
                    listaDiferencas.Add(new ItraDiferencaModel("Somente macro", l.CodCliente, l.CodISIN, l.Quantidade));
                });

                var sourceDiferenca = new BindingSource(listaDiferencas, null);

                gridItraDiferentes.DataSource = sourceDiferenca;

                if (listaDiferencas.Count > 0)
                {

                    var listDuplicidade = (from a in listaDiferencas
                               group a by new { a.CodCliente, a.CodISIN } into g
                               select new
                               {
                                   g.Key.CodCliente,
                                   g.Key.CodISIN,
                                   myCount = g.Count()
                               }).ToList();

                    bool temDuplicidade = false;
                    bool temClienteAMais = false;
                    foreach (var dup in listDuplicidade)
                    {
                        if (dup.myCount > 1)
                        {
                            temDuplicidade = true;
                            continue;
                        }

                        if (dup.myCount > 0)
                        {
                            temClienteAMais = true;
                        }
                    }

                    if (temDuplicidade )
                    {
                        MessageBox.Show("Há diferenças em quantidades do mesmo cliente com o mesmo papel nos dois ITRAs. Verifcar se o MTM está atualizado ou Lista de Chamada de margem estão diferentes.", "Diferenças entre os arquivos foram encontradas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (temClienteAMais)
                    {
                        MessageBox.Show("Há divergencia na quantidade de clientes na planilha, verifique a lista de chamada de margem. Depedendo da diferença de horário que as chamadas de margem foram extraídas, é normal acontecer de existirem clientes a mais em um dos ITRAs. Normalmente, a chamada de margem mais nova, tem mais clientes", "Diferenças entre os arquivos foram encontradas",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    internal class ItraComparer : IEqualityComparer<ItraModel>
    {
        public bool Equals(ItraModel x, ItraModel y)
        {
            if (string.Equals(x.CodCliente, y.CodCliente, StringComparison.OrdinalIgnoreCase) && 
                 string.Equals( x.CodISIN, y.CodISIN , StringComparison.OrdinalIgnoreCase) &&
                 string.Equals(x.Quantidade, y.Quantidade, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }

        public int GetHashCode(ItraModel obj)
        {
            return obj.CodCliente.GetHashCode();
        }
    }
}
