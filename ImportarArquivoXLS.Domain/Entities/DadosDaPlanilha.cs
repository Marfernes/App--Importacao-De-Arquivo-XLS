using System;
using System.ComponentModel.DataAnnotations;

namespace ImportarArquivoXLS.Domain
{
    public class DadosDaPlanilha
    {
        public DadosDaPlanilha()
        {

        }
        [Key]
        public Guid PagamentoID { get; set; }

        public string Documento { get; set; }

        public string Credor { get; set; }

        public string DocumentoCredor { get; set; }

        public string NumeroProcesso { get; set; }

        public string Finalidade { get; set; }

        public DateTime Data { get; set; }

        public string Status { get; set; }

        public string ValorPago { get; set; }

        public string Movimentacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public string CpfCnpjCessionario { get; set; }

        public string Cessionario { get; set; }
    }
}
