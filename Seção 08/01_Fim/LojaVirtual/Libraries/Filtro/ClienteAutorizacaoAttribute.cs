﻿using LojaVirtual.Libraries.Login;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace LojaVirtual.Libraries.Filtro
{
    /*
     * Tipos de Filtros:
     * - Autorização
     * - Recursos
     * - Ação
     * - Exceção
     * - Resultado
     */
    public class ClienteAutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        LoginCliente _loginCliente;

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _loginCliente = (LoginCliente)context.HttpContext.RequestServices.GetService(typeof(LoginCliente));

            Cliente cliente = _loginCliente.GetCLiente();

            if (cliente == null)
            {
                context.Result = new ContentResult() { Content = "Acesso Negado." };
            }
        }
    }
}
