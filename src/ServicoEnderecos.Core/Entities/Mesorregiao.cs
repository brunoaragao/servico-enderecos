namespace ServicoEnderecos.Core.Entities;

public class Mesorregiao
{
    public Mesorregiao(int id, string nome, int ufId)
    {
        Id = id;
        Nome = nome;
        UFId = ufId;
    }

    public int Id { get; private set; }
    public string Nome { get; private set; }
    public int UFId { get; private set; }
    public UF? UF { get; private set; }
}
