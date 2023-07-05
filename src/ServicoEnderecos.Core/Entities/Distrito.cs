namespace ServicoEnderecos.Core.Entities;

public class Distrito
{
    public Distrito(int id, string nome, int municipioId)
    {
        Id = id;
        Nome = nome;
        MunicipioId = municipioId;
    }

    public int Id { get; private set; }
    public string Nome { get; private set; }
    public int MunicipioId { get; private set; }
    public Municipio? Municipio { get; private set; }
}