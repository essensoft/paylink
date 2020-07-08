using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Parser
{
    public class WeChatPayResponseXmlParser<T> where T : WeChatPayResponse
    {
        public T Parse(string body)
        {
            T result = null;
            var parameters = new WeChatPayDictionary();

            try
            {
                var bodyDoc = XDocument.Parse(body).Element("xml");
                foreach (var element in bodyDoc.Elements())
                {
                    parameters.Add(element.Name.LocalName, element.Value);
                }

                using (var sr = new StringReader(body))
                {
                    var xmldes = new XmlSerializer(typeof(T));
                    result = (T)xmldes.Deserialize(sr);
                }
            }
            catch { }

            if (result == null)
            {
                result = Activator.CreateInstance<T>();
            }

            result.Body = body;
            result.Parameters = parameters;
            result.Execute();

            return result;
        }
    }
}
