namespace ConsoleApp2
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Ano { get; set; }
    }

    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
    }

    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
    }
}
