using ApiCatalogoJogos.Exception;
namespace ApiCatalogoJogos.Services
{
    public class JogoService : IJogoService
    {
        private readonly IjogoRepository _jogoRepository;

        public JogoService(IjogoRepository jogoRepository)
        {

            _jogoRepository = jogoRepository;
        }

        public async Task<List<JogoViewModel>>Obter(int pagina int quantidade)
        {

            var jogo = await _jogoRepository.Obter(pagina,quantidade);

            return jogos.Select(jogo => new JogoViewModel 
            {
                Id =  jogo.Id,
                Nome = jogo.Nome,
                Produtora = jogo.Produtora,
                Preco = jogo.Preco
            } )  .ToList();


        }
        public async Task<JogoViewModel>Obter(Guid id)
        {

            var jogo = await _jogoRepository.Obter(id);

            if(jogo == null)
                return null;

            return new JogoViewModel
            {
                id = jogo.Id,
                Nome = jogo.Nome,
                Produtora = jogo.Produtora,
                Preco = jogo.Preco

            } ;   
        }

        public async Task<JogoViewModel> Inserir(JogoInputModel jogo)
        {

            var entidadeJogo = await _jogoRepository.Obter(jogo.Nome, jogo.Produtora);

            if (entidadeJogo.Count > 0 )
                throw new JogoCadastradoException();

             var JogoInsert = New Jogo
             {
                 Id = Guid.NewGuid(),
                 Nome = jogo.Nome,
                 Produtora = jogo.Produtora,
                 Preco = jogo.Preco

             }   ;

        }

        public async Task<JogoViewModel> Atualizar( Guid id, JogoInputModel jogo)
        {
            var entidadeJogo = await  _jogoRepository.Obter(id);

            if (entidadeJogo == null)
                throw new JogoNaoCadastradoException();

            entidadeJogo.Preco = preco;
             await  _jogoRepository.Atualizar(entidadeJogo);    
        }
         public  async Task Remover (Guid id)
         {
             var jogo = _jogoRepository.Obter(id);
             if (jogo == null)
                throw  new = JogoNaoCadastradoException();
            
            await _jogoRepository.Remover(id);


         }  

         public void Dispose()
         {
             _jogoRepository.Dispose();

         }
        



    }
}