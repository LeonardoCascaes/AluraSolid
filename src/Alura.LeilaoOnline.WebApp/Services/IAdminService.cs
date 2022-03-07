using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Services
{
    public interface IAdminService
    {
        Categoria ConsultaCategoriaPorId(int id);
        IEnumerable<Categoria> ConsultaCategorias();
        void CadastraLeilao(Leilao leilao);
        Leilao ConsultaLeilaoPorId(int id);
        IEnumerable<Leilao> ConsultaLeiloes();
        void ModificaLeilao(Leilao leilao);
        void RemoveLeilao(Leilao leilao);
        void IniciaPregaoDoLeilaoComId(int id);
        void FinalizaPregaoDoLeilaoComId(int id);
    }
}
