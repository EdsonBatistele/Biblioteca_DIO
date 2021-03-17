using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_DIO.Interface;


namespace Biblioteca_DIO
{
    public class BibliotecaSeries : IBiblioteca<Serie>
    {
        private readonly List<Serie> _listaSeries = new List<Serie>();

        public void Alterar(int id, Serie entidade)
        {
            var index = _listaSeries.FindIndex(a => a.Id == id);
            _listaSeries[index] = entidade;
        }

        public void Excluir(int id)
        {
            _listaSeries.RemoveAll(a => a.Id == id);
        }

        public void Inserir(Serie entidade)
        {
            _listaSeries.Add(entidade);
        }

        public List<Serie> Listar()
        {
            return _listaSeries.ToList();
        }

        public int ProximoId()
        {
            var ultimaSeriePersistida = _listaSeries.LastOrDefault();
            return ultimaSeriePersistida == null ? 1 : ultimaSeriePersistida.Id + 1;
        }

        public Serie RetornarPorId(int id)
        {
            return _listaSeries.FirstOrDefault(a => a.Id == id);
        }
    }
}
