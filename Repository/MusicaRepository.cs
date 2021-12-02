using ProjectStipofy.Model;

namespace ProjectStipofy.Repository
{
    public class MusicaRepository : IListRepository<Musica>
    {

        public static Dictionary<Guid, Musica> musicas = new Dictionary<Guid, Musica>()
        {
            {Guid.Parse("1"), new Musica{ Id = Guid.Parse("1"), Genero=, Nome ="", Cantor="" } },
            {Guid.Parse("2"), new Musica{ Id = Guid.Parse("2"), Genero=, Nome ="", Cantor="" } },
            {Guid.Parse("3"), new Musica{ Id = Guid.Parse("3"), Genero=, Nome ="", Cantor="" } },
            {Guid.Parse("4"), new Musica{ Id = Guid.Parse("4"), Genero=, Nome ="", Cantor="" } },
            {Guid.Parse("5"), new Musica{ Id = Guid.Parse("5"), Genero=, Nome ="", Cantor="" } },
            {Guid.Parse("6"), new Musica{ Id = Guid.Parse("6"), Genero=, Nome ="", Cantor="" } },
            {Guid.Parse("7"), new Musica{ Id = Guid.Parse("7"), Genero=, Nome ="", Cantor="" } },
            {Guid.Parse("8"), new Musica{ Id = Guid.Parse("8"), Genero=, Nome ="", Cantor="" } },
            {Guid.Parse("9"), new Musica{ Id = Guid.Parse("9"), Genero=, Nome ="", Cantor="" } },
            {Guid.Parse("10"), new Musica{ Id = Guid.Parse("10"), Genero=, Nome ="", Cantor="" } }
        };

        public Task<List<Musica>> PlayList(string nome)
        {
            return Task.FromResult(musicas.Values.Where(musica => musica.Nome.Equals(musica))).ToList();
        }

        public Task<List<Musica>> BuscaGenero (Genero genero)
        {
            var retorno = new List<Musica>();

            foreach (var musica in musicas.Values)
            {
                if (musica.Genero == genero)
                {
                    retorno.Add(musica);
                }
            }

            return Task.FromResult(retorno);
        }

        public Task<List<Musica>> BuscarNome (string nome)
        {
            var retorno = new List<Musica>();

            foreach (var musica in musicas.Values)
            {
                if (musica.Nome.Equals(nome))
                    retorno.Add(musica);
            }

            return Task.FromResult(retorno);
        }

        public Task<List<Musica>> BuscarArtista(string cantor)
        {
            var retorno = new List<Musica>();

            foreach (var musica in musicas.Values)
            {
                if (musica.Cantor.Equals(cantor))
                {
                    retorno.Add(musica);
                }
            }
            return Task.FromResult(retorno);
        }
    }


}
