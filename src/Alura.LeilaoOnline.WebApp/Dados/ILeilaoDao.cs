using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        void Alterar(Leilao leilao);
        IEnumerable<Categoria> BuscarCategorias();
        IEnumerable<Leilao> BuscarLeiloes();
        Leilao BuscarPorId(int id);
        void Excluir(Leilao leilao);
        void Incluir(Leilao leilao);
    }
}
