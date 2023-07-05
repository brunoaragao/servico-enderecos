namespace ServicoEnderecos.Core.Entities
{
    public class UF
    {
        public UF(int id, string sigla, string nome, int regiaoId)
        {
            Id = id;
            Sigla = sigla;
            Nome = nome;
            RegiaoId = regiaoId;
        }

        public int Id { get; private set; }
        public string Sigla { get; private set; }
        public string Nome { get; private set; }
        public int RegiaoId { get; private set; }
        public Regiao? Regiao { get; private set; }
    }

}
