using ProjetoFinalASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoFinalASP.DAL
{
    public class ClienteDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static List<Cliente> RetornarClientes()
        {
            return ctx.Clientes.ToList();
        }

        public static Cliente BuscarClientePorCpf(Cliente cliente)
        {
            return ctx.Clientes.FirstOrDefault(x => x.CpfCliente.Equals(cliente.CpfCliente));
        }

        public static Cliente BuscarEmpresaPorCnpj(Cliente cliente)
        {
            return ctx.Clientes.FirstOrDefault(x => x.CnpjEmpresa.Equals(cliente.CnpjEmpresa));
        }
        public static bool CadastrarCliente(Cliente cliente)
        {
            if (BuscarClientePorCpf(cliente) == null)
            {
                ctx.Clientes.Add(cliente);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }


        public static bool AlterarCliente(Cliente cliente)
        {
            if (ctx.Clientes.FirstOrDefault(x => x.CpfCliente.Equals(cliente.CpfCliente) &&
             x.idCliente != cliente.idCliente) == null)
            {
                ctx.Entry(cliente).State = EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static Cliente BuscarClientePorId(int id)
        {
            return ctx.Clientes.Find(id);
        }

        public static void RemoverClientes(int id)
        {
            ctx.Clientes.Remove(BuscarClientePorId(id));
            ctx.SaveChanges();
        }
    }
}