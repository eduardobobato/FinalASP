﻿using ProjetoFinalASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoFinalASP.DAL
{
    public class CategoriaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static List<Categoria> RetornarCategorias()
        {
            return ctx.Categorias.ToList();
        }

        public static bool CadastrarCategoria(Categoria categoria)
        {
            if (BuscarCategoriaPorNome(categoria) == null)
            {
                ctx.Categorias.Add(categoria);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static Categoria BuscarCategoriaPorNome(Categoria categoria)
        {
            return ctx.Categorias.FirstOrDefault(x => x.NomeCategoria.Equals(categoria.NomeCategoria));
        }

        public static void RemoverCategoria(int id)
        {
            ctx.Categorias.Remove(BuscarCategoriaPorId(id));
            ctx.SaveChanges();
        }

        public static Categoria BuscarCategoriaPorId(int? id)
        {
            return ctx.Categorias.Find(id);
        }

        public static bool AlterarCategoria(Categoria categoria)
        {
            if (ctx.Categorias.FirstOrDefault
                (x => x.NomeCategoria.Equals(categoria.NomeCategoria) &&
                x.idCategoria != categoria.idCategoria) == null)
            {
                ctx.Entry(categoria).State = EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            return false;
        }
    }
}