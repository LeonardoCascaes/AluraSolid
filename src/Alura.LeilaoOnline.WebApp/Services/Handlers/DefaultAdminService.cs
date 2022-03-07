﻿using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Services.Handlers
{
    public class DefaultAdminService : IAdminService
    {
        private readonly ILeilaoDao _leilaoDao;
        private readonly ICategoriaDao _categoriaDao;

        public DefaultAdminService(ILeilaoDao leilaoDao, ICategoriaDao categoriaDao)
        {
            _leilaoDao = leilaoDao;
            _categoriaDao = categoriaDao;
        }

        public void CadastraCategoria(Categoria categoria)
        {
            _categoriaDao.Incluir(categoria);
        }


        public Categoria ConsultaCategoriaPorId(int id)
        {
            return _categoriaDao.BuscarPorId(id);
        }

        public IEnumerable<Categoria> ConsultaCategorias()
        {
            return _categoriaDao.BuscarCategorias();
        }
        public void ModificaCategoria(Categoria categoria)
        {
            _categoriaDao.Alterar(categoria);
        }
        public void RemoveCategoria(Categoria categoria)
        {
            _categoriaDao.Excluir(categoria);
        }
        public void CadastraLeilao(Leilao leilao)
        {
            _leilaoDao.Incluir(leilao);
        }

        public Leilao ConsultaLeilaoPorId(int id)
        {
            return _leilaoDao.BuscarPorId(id);
        }

        public IEnumerable<Leilao> ConsultaLeiloes()
        {
            return _leilaoDao.BuscarLeiloes();
        }

        public void ModificaLeilao(Leilao leilao)
        {
            _leilaoDao.Alterar(leilao);
        }

        public void RemoveLeilao(Leilao leilao)
        {
            if (leilao != null && leilao.Situacao != SituacaoLeilao.Pregao)
            {
                _leilaoDao.Excluir(leilao);
            }
        }

        public void IniciaPregaoDoLeilaoComId(int id)
        {
            var leilao = _leilaoDao.BuscarPorId(id);
            if (leilao != null && leilao.Situacao == SituacaoLeilao.Rascunho)
            {
                leilao.Situacao = SituacaoLeilao.Pregao;
                leilao.Inicio = DateTime.Now;
                _leilaoDao.Alterar(leilao);
            }
        }
        public void FinalizaPregaoDoLeilaoComId(int id)
        {
            var leilao = _leilaoDao.BuscarPorId(id);
            if (leilao != null && leilao.Situacao == SituacaoLeilao.Pregao)
            {
                leilao.Situacao = SituacaoLeilao.Finalizado;
                leilao.Termino = DateTime.Now;
                _leilaoDao.Alterar(leilao);
            }
        }
    }
}