namespace ServicoEnderecos.Core.Entities;

public class Regiao
{
    public Regiao(int id, string sigla, string nome)
    {
        Id = id;
        Sigla = sigla;
        Nome = nome;
    }

    public int Id { get; private set; }
    public string Sigla { get; private set; }
    public string Nome { get; private set; }
}