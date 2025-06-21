﻿using DesafioTecnicoSenai.Application.Interfaces;

namespace DesafioTecnicoSenai.API.Areas.Administracao.Models
{
    public class CargoModel : IModel
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
    }
}
