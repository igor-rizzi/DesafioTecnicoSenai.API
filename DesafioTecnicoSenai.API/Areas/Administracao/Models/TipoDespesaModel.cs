using System.ComponentModel.DataAnnotations;

namespace DesafioTecnicoSenai.API.Areas.Administracao.Models
{
    public class TipoDespesaModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Descricao { get; set; } = string.Empty;
    }
}
