namespace IntroController.Entidades
{

    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }


        public byte[]? foto { get; set; }

        //Conteudo é a foto transformada em string - BASE64 -> string
        public string? conteudo { get; set; }

    }


}
