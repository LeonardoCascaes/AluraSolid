using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;
using System.Linq;
namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class CategoriaDaoComEfCore : ICategoriaDao
    {
        private readonly AppDbContext _context;

        public CategoriaDaoComEfCore()
        {
            _context = new AppDbContext();
        }

        public void Incluir(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
        }

        public IEnumerable<Categoria> BuscarCategorias()
        {
            return _context.Categorias.ToList();
        }

        public Categoria BuscarPorId(int id)
        {
            return _context.Categorias.FirstOrDefault(c => c.Id == id);
        }

        public void Alterar(Categoria categoria)
        {
            _context.Update(categoria);
            _context.SaveChanges();
        }

        public void Excluir(Categoria categoria)
        {
            _context.Remove(categoria);
            _context.SaveChanges();
        }
    }
}