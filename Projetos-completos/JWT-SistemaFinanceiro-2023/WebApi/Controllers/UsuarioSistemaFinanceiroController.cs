﻿using Domain.Interfaces.InterfaceServicos;
using Domain.Interfaces.ISistemaFinanceiro;
using Domain.Interfaces.IUsuarioSistemaFinanceiro;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsuarioSistemaFinanceiroController : ControllerBase
    {
        private readonly InterfaceUsuarioSistemaFinanceiro _InterfaceUsuarioSistemaFinanceiro;
        private readonly IUsuarioSistemaFinanceiroServico _IUsuarioSistemaFinanceiroServico;

        public UsuarioSistemaFinanceiroController(InterfaceUsuarioSistemaFinanceiro InterfaceUsuarioSistemaFinanceiro,
          IUsuarioSistemaFinanceiroServico IUsuarioSistemaFinanceiroServico)
        {
            _InterfaceUsuarioSistemaFinanceiro = InterfaceUsuarioSistemaFinanceiro;
            _IUsuarioSistemaFinanceiroServico = IUsuarioSistemaFinanceiroServico;
        }
        [HttpGet("/api/ListaUsuarioSistema")]
        [Produces("application/json")]
        public async Task<object> ListaSistemasUsuario(int idSistema)
        {
            return await _InterfaceUsuarioSistemaFinanceiro.ListarUsuariosSistema(idSistema);
        }
        [HttpPost("/api/CadastrarUsuarioNoSistema")]
        [Produces("application/json")]
        public async Task<object> CadastrarUsuarioNoSistema(int idSistema, string emailUsuario)
        {
            try
            {
                await _IUsuarioSistemaFinanceiroServico.CadastrarUsuarioNoSistema(
                    new Entities.Entidades.UsuarioSistemaFinanceiro
                    {
                        IdSistema = idSistema,
                        EmailUsuario = emailUsuario,
                        Administrador =  false,
                        SistemaAtual = true,
                    });
            }
            catch (Exception)
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }
        
        [HttpDelete("/api/DeleteUsuarioNoSistema")]
        [Produces("application/json")]
        public async Task<object> DeleteUsuarioNoSistema(int id)
        {
            try
            {
                var usuarioSistemaFinanceiro = await _InterfaceUsuarioSistemaFinanceiro.GetEntityById(id);
                await _InterfaceUsuarioSistemaFinanceiro.Delete(usuarioSistemaFinanceiro);
            }
            catch (Exception)
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }
    }
}
