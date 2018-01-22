using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace DynamicMVC1.Controllers
{
    public class XMLResult : ActionResult
    {
        private Object _data;
        public XMLResult(Object data)
        {
            _data = data;
                
        }
        // GET: XMLResult
        [Authorize]
        public override void ExecuteResult(ControllerContext context)
        {
            var response = context.HttpContext.Response;
            response.ContentType = "text/xml";
            XmlSerializer serializer = new XmlSerializer(_data.GetType());
            serializer.Serialize(response.Output, _data);
        }
    }
}