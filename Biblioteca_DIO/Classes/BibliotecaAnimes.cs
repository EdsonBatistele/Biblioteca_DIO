using Biblioteca_DIO.Interface;
using System.Collections.Generic;
using System.Linq;


namespace Biblioteca_DIO
{
    public class BibliotecaAnimes : IBiblioteca<Anime>
    {
        private readonly List<Anime> _listaAnimes = new List<Anime>();

        public void Alterar(int id, Anime entidade)
        {
            var index = _listaAnimes.FindIndex(a => a.Id == id);
            _listaAnimes[index] = entidade;
        }

        public void Excluir(int id)
        {
            _listaAnimes.RemoveAll(a => a.Id == id);
        }

        public void Inserir(Anime entidade)
        {
            _listaAnimes.Add(entidade);
        }

        public List<Anime> Listar()
        {
            return _listaAnimes.ToList();
        }

        public int ProximoId()
        {
            var ultimoAnimePersistido = _listaAnimes.LastOrDefault();
            return ultimoAnimePersistido == null ? 1 : ultimoAnimePersistido.Id + 1;
        }

        public Anime RetornarPorId(int id)
        {
            return _listaAnimes.FirstOrDefault(a => a.Id == id);
        }
    }
}
