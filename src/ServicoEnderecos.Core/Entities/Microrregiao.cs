namespace ServicoEnderecos.Core.Entities;

public class Microrregiao
{
    public Microrregiao(int id, string nome, int mesorregiaoId)
    {
        Id = id;
        Nome = nome;
        MesorregiaoId = mesorregiaoId;
    }

    public int Id { get; private set; }
    public string Nome { get; private set; }
    public int MesorregiaoId { get; private set; }
    public Mesorregiao? Mesorregiao { get; private set; }
}
