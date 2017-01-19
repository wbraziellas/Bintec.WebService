using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Bintec.WebService.Domain.DTO;
using Bintec.WebService.Controller;

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

        private XmlPorEmpresaController _selecionarRegistroXmlPorEmpresa;
        private XmlPorEmpresaController selecionarRegistroXmlPorEmpresa
        {
            get { return _selecionarRegistroXmlPorEmpresa ?? (_selecionarRegistroXmlPorEmpresa = new XmlPorEmpresaController()); }
        }

        #endregion

        [WebMethod]
        public List<XmlPorEmpresaDTO> SelecionarRegistroPorChaveDeAcesso(string chavedeacesso)
        {
            return selecionarRegistroXmlPorEmpresa.PorChaveDeAcesso(chavedeacesso);
        }
    }
}
