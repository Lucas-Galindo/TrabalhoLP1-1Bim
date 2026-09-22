using IntroAPI.Entidades;

namespace IntroAPI.Repository
{
    public class CidadeRepository
    {
        private readonly MySqlDbContext _context;

        public CidadeRepository(MySqlDbContext context)
        {
            _context = context;
        }

        public bool Importar(List<Cidade> cidade)
        {

            //Precisa ter um controle de transacao
           //Se der um erro, eu posso dar rollback, tem que dar commit
           
            bool sucesso = false;
            try
            {
                for(int linha = 0; linha < cidade.Count - 1; linha++)
                {

                }
            }
        }
    }
}
