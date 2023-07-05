namespace ServicoEnderecos.Core.Entities;

public class RegiaoImediata
{
    public RegiaoImediata(int id, string nome, int regiaoIntermediariaId)
    {
        Id = id;
        Nome = nome;
        RegiaoIntermediariaId = regiaoIntermediariaId;
    }

    public int Id { get; private set; }
    public string Nome { get; private set; }
    public int RegiaoIntermediariaId { get; private set; }
    public RegiaoIntermediaria? Regiaointermediaria { get; private set; }
}
