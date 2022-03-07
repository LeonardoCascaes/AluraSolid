using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ICommand<T> where T : class
    {
        void Incluir(T obj);
        void Alterar(T obj);
        void Remover(T obj);
    }
}
