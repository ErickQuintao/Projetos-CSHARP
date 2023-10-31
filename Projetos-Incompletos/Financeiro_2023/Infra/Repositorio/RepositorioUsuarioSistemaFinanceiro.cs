using Domain.Interfaces.IUsuarioSistemaFinanceiro;
using Entities.Entidades;
using Infra.Repositorio.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioUsuarioSistemaFinanceiro : RepositoryGenerics<UsuarioSistemaFinanceiro>, InterfaceUsuarioSistemaFinanceiro
    {
        Task<IList<UsuarioSistemaFinanceiro>> InterfaceUsuarioSistemaFinanceiro.ListarUsuariosSistema(int IdSistema)
        {
            throw new NotImplementedException();
        }

        Task<UsuarioSistemaFinanceiro> InterfaceUsuarioSistemaFinanceiro.ObterUsuarioPorEmail(string emailUsuario)
        {
            throw new NotImplementedException();
        }

        Task InterfaceUsuarioSistemaFinanceiro.RemoveUsuarios(List<UsuarioSistemaFinanceiro> usuarios)
        {
            throw new NotImplementedException();
        }
    }
}
