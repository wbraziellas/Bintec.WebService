using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Bintec.WebService.Domain.DTO;
using Bintec.WebService.Controller;
using System.Web.Script.Services;
using System.Net.Http;

namespace Bintec.WebService.Service
{
    /// <summary>
    /// Summary description for Servico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Servico : System.Web.Services.WebService
    {
        #region Propriedades

        private XmlPorEmpresaController _tabelaXmlPorEmpresa;
        private XmlPorEmpresaController tabelaXmlPorEmpresa
        {
            get { return _tabelaXmlPorEmpresa ?? (_tabelaXmlPorEmpresa = new XmlPorEmpresaController()); }
        }

        #endregion

        [WebMethod]        
        public List<XmlPorEmpresaDTO> SelecionarRegistroPorChaveDeAcesso(string chavedeacesso)
        {
            return tabelaXmlPorEmpresa.SelecionarPorChaveDeAcesso(chavedeacesso);
        }

        [WebMethod]        
        public string InserirRegistroPorChaveDeAcesso(XmlPorEmpresaDTO xmlPorEmpresa)
        {
            return tabelaXmlPorEmpresa.InserirRegistro(xmlPorEmpresa);
        }

        [WebMethod]
        public string AtualizarRegistroPorChaveDeAcesso(XmlPorEmpresaDTO xmlPorEmpresa)
        {
            return tabelaXmlPorEmpresa.AtualizarRegistro(xmlPorEmpresa);
        }
    }
}
