using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_DIO.Interface;


namespace Biblioteca_DIO
{
    public class BibliotecaDocumentarios : IBiblioteca<Documentario>
    {
        private readonly List<Documentario> _listaDocumentarios = new List<Documentario>();

        public void Alterar(int id, Documentario entidade)
        {
            var index = _listaDocumentarios.FindIndex(a => a.Id == id);
            _listaDocumentarios[index] = entidade;
        }

        public void Excluir(int id)
        {
            _listaDocumentarios.RemoveAll(a => a.Id == id);
        }

        public void Inserir(Documentario entidade)
        {
            _listaDocumentarios.Add(entidade);
        }

        public List<Documentario> Listar()
        {
            return _listaDocumentarios.ToList();
        }

        public int ProximoId()
        {
            var ultimoDocumentarioPersistido = _listaDocumentarios.LastOrDefault();
            return ultimoDocumentarioPersistido == null ? 1 : ultimoDocumentarioPersistido.Id + 1;
        }

        public Documentario RetornarPorId(int id)
        {
            return _listaDocumentarios.FirstOrDefault(a => a.Id == id);
        }
    }
}
