using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ICategoriaDao
    {
        void Alterar(Categoria categoria);
        IEnumerable<Categoria> BuscarCategorias();
        Categoria BuscarPorId(int id);
        void Excluir(Categoria categoria);
        void Incluir(Categoria categoria);
    }
}
