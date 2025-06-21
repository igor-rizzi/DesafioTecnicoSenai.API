using DesafioTecnicoSenai.Domain.Common;
using DesafioTecnicoSenai.Domain.Entities.Administracao;
using DesafioTecnicoSenai.Domain.Entities.Colaboradores;
using DesafioTecnicoSenai.Domain.Entities.Reembolsos.Enums;
using System.ComponentModel.DataAnnotations;

namespace DesafioTecnicoSenai.Domain.Entities.Reembolsos
{
    public class Reembolso : Entity
    {
        [Required]
        public string Titulo { get; set; } = null!;

        [Required]
        public string Descricao { get; set; } = null!;

        [Required]
        public decimal Valor { get; set; }

        [Required]
        public DateTime DataDespesa { get; set; }

        [Required]
        public string ComprovanteNomeArquivo { get; set; } = null!;

        [Required]
        public byte[] ComprovanteConteudo { get; set; } = null!;

        [Required]
        public string ComprovanteContentType { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public Status Status { get; set; } = Status.PendenteAprovacaoFinanceira;

        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        [Required]
        public long ColaboradorId { get; set; }

        [Required]
        public long TipoDespesaId { get; set; }

        public Colaborador Colaborador { get; set; } = null!;

        public TipoDespesa TipoDespesa { get; set; } = null!;
    }
}
