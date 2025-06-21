﻿using DesafioTecnicoSenai.Domain.Common;
using DesafioTecnicoSenai.InfraData.Common.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnicoSenai.InfraData.Common.Repositories
{
    public class Repository<TEntity> : BaseRepository<TEntity> where TEntity : Entity
    {
        protected readonly DesafioTecnicoSenaiDbContext Context;

        public Repository(DesafioTecnicoSenaiDbContext context) : base(context)
        {
            Context = context;
        }
    }
}
