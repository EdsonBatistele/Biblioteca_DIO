using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_DIO.Interface;


namespace Biblioteca_DIO
{
    public class BibliotecaFilmes : IBiblioteca<Filme>
    {
        private readonly List<Filme> _listaFilmes = new List<Filme>();

        public void Alterar(int id, Filme entidade)
        {
            var index = _listaFilmes.FindIndex(a => a.Id == id);
            _listaFilmes[index] = entidade;
        }

        public void Excluir(int id)
        {
            _listaFilmes.RemoveAll(a => a.Id == id);
        }

        public void Inserir(Filme entidade)
        {
            _listaFilmes.Add(entidade);
        }

        public List<Filme> Listar()
        {
            return _listaFilmes.ToList();
        }

        public int ProximoId()
        {
            var ultimoFilmePersistido = _listaFilmes.LastOrDefault();
            return ultimoFilmePersistido == null ? 1 : ultimoFilmePersistido.Id + 1;
        }

        public Filme RetornarPorId(int id)
        {
            return _listaFilmes.FirstOrDefault(a => a.Id == id);
        }
    }
}
