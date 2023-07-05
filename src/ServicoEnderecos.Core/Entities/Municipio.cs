namespace ServicoEnderecos.Core.Entities;

public class Municipio
{
    public Municipio(int id, string nome, int microrregiaoId, int regiaoimediataId)
    {
        Id = id;
        Nome = nome;
        MicrorregiaoId = microrregiaoId;
        RegiaoimediataId = regiaoimediataId;
    }

    public int Id { get; private set; }
    public string Nome { get; private set; }
    public int MicrorregiaoId { get; private set; }
    public int RegiaoimediataId { get; private set; }
    public Microrregiao? Microrregiao { get; private set; }
    public RegiaoImediata? Regiaoimediata { get; private set; }
}
