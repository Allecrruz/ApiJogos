namespace ApiCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100,MinimumLength = 3,ErrorMessage = "o nome do jogo deve conter entre 3 e 100 Caracteres")]

        public string Nome {get; set;}
        [Required]
        [StringLength (100,MinimumLength = 1,ErrorMessage = "o nome da produtora deve conter entre 3 e 100 Caracteres")]
    
        public string Produtora{ get ; set;}
        [Required]
        [Range (1,1000,MinimumLength = ErrorMessage = "")]

        public double Preco {get; set;}
    
    }    

}