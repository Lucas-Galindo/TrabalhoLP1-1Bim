namespace IntroAPI.Entidades
{
    public class Cidade
    {
        public int _id { get; set; }
        public string _nome { get; set; }
        public string _uf {  get; set; }
        public int _ibge { get; set; }
        public decimal? _latitude { get; set; }
        public decimal? _longitude { get; set; }

    }
}
