using Microsoft.EntityFrameworkCore;

using ServicoEnderecos.Core.Entities;
using ServicoEnderecos.Core.Interfaces;

namespace ServicoEnderecos.Infra.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Distrito> Distritos => Set<Distrito>();

    public DbSet<Mesorregiao> Mesorregioes => Set<Mesorregiao>();

    public DbSet<Microrregiao> Microrregioes => Set<Microrregiao>();

    public DbSet<Municipio> Municipios => Set<Municipio>();

    public DbSet<Regiao> Regioes => Set<Regiao>();

    public DbSet<RegiaoImediata> RegioesImediatas => Set<RegiaoImediata>();

    public DbSet<RegiaoIntermediaria> RegioesIntermediaras => Set<RegiaoIntermediaria>();

    public DbSet<UF> UFs => Set<UF>();
}