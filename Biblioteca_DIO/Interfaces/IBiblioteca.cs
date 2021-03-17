using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_DIO.Interface
{
    interface IBiblioteca<T>
    {
        List<T> Listar();
        T RetornarPorId(int id);
        void Inserir(T entidade);
        void Excluir(int id);
        void Alterar(int id, T entidade);
        int ProximoId();
    }
}
