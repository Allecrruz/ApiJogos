namespace ApiCatalogoJogos.Exception
{
    public class JogoNaoCadastradoExcepction : Exception
    {
        public JogoNaoCadastradoExcepction()
           : base  ("este jogo não está cadastrado")
        { }   
    }
}