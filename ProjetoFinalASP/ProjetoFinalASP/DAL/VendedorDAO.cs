using ProjetoFinalASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoFinalASP.DAL
{
    public class VendedorDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public  static List<Vendedor> RetornarVendedores()
        {
            return ctx.Vendedores.ToList();
        }

        public  static Vendedor BuscarVendedorPorCpf(Vendedor vendedor)
        {
            return ctx.Vendedores.FirstOrDefault(x => x.CpfVendedor.Equals(vendedor.CpfVendedor));
        }

        public  static  bool CadastrarVendedor(Vendedor vendedor)
        {
            if(BuscarVendedorPorCpf(vendedor) == null)
            {
                ctx.Vendedores.Add(vendedor);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }


        public static  bool AlterarVendedor(Vendedor vendedor)
        {
            if (ctx.Vendedores.FirstOrDefault(x => x.CpfVendedor.Equals(vendedor.CpfVendedor) &&
             x.idVendedor != vendedor.idVendedor) == null)
            {
                ctx.Entry(vendedor).State = EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public  static Vendedor BuscarVendedorPorId(int id)
        {
            return ctx.Vendedores.Find(id);
        }

        public static void RemoverVendedor(int id)
        {
            ctx.Vendedores.Remove(BuscarVendedorPorId(id));
            ctx.SaveChanges();
        }
    }
}