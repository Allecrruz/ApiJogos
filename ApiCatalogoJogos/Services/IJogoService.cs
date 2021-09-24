namespace ApiCatalogoJogos.Services
{
    public interface IJogoService : IDisposable
    {
        Task<List<Jogo>> Obter(int pagina, int quantidade);

		Task<jogo> Obter(Guid Id);

		Task<List<jogo>> Obter(string nome, string produtora);

		Task Inserir(Jogo Jogo);

		Task Atualizar(Jogo Jogo);

		Task Remover(Guid Id);
    }
}