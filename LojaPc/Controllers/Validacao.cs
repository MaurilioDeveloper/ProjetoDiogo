using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaPc.Controllers
{
    public class Validacao
    {
        private static string ComputadorSessao = "COMPUTADOR_ID";

        //public static string ReturnComputadorId()
        //{
        //    if (HttpContext.Current.Session[ComputadorSessao] == null)
        //    {
        //        Guid guid = Guid.NewGuid();
        //        HttpContext.Current.Session[ComputadorSessao] = guid.ToString();
        //    }
        //    return HttpContext.Current.Session[ComputadorSessao].ToString();
        //}

        public static void SetSessionId(int id)
        {
            HttpContext.Current.Session[ComputadorSessao] = id;
        }

        public static string GetSessionId()
        {
            return HttpContext.Current.Session[ComputadorSessao] != null ? HttpContext.Current.Session[ComputadorSessao].ToString() : null;
        }
    }
}