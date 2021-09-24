namespace ApiCatalogoJogos.Exception
{
    public class JogoJaCadastradoException : Exception 
    {
        public JogoCadastradoException()
        : base ("este jogo já está cadastrado")
        { }
        
    }
}