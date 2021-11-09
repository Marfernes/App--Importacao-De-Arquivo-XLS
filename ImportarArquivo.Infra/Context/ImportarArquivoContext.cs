using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImportarArquivo.Infra.Context
{
    public class ImportarArquivoContext : DbContext
    {
        public IConfiguration _iconfiguration;
        protected ImportarArquivoContext(DbContextOptions<ImportarArquivoContext> options, IConfiguration configuration) : base(options)
        {
            _iconfiguration = configuration;
        }

    }
}
