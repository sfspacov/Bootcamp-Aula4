namespace ConsoleApp2
{
    public class BancoDeDados<T> where T : class
    {
        public void Salvar(T objeto)
        {
            //Conecta com banco de dados
            //Salva o objeto no banco de dados
        }
    }

    public class ClasseGenerica<T> where T : Pessoa
    {
        public void MetodoQualquer(T objeto)
        {
        }
    }
}
