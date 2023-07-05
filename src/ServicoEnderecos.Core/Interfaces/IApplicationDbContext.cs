using Microsoft.EntityFrameworkCore;

using ServicoEnderecos.Core.Entities;

namespace ServicoEnderecos.Core.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Distrito> Distritos { get; }

    DbSet<Mesorregiao> Mesorregioes { get; }

    DbSet<Microrregiao> Microrregioes { get; }

    DbSet<Municipio> Municipios { get; }

    DbSet<Regiao> Regioes { get; }

    DbSet<RegiaoImediata> RegioesImediatas { get; }

    DbSet<RegiaoIntermediaria> RegioesIntermediaras { get; }

    DbSet<UF> UFs { get; }
}