using System;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Parser
{
    public class WeChatPayNotifyXmlParser<T> where T : WeChatPayNotify
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

        public T Parse(string body, string root)
        {
            T result = null;
            var newBody = string.Empty;
            var parameters = new WeChatPayDictionary();

            try
            {
                var bodyDoc = XDocument.Parse(body).Element("xml");
                var rootDoc = XDocument.Parse(root).Element("root");
                bodyDoc.Add(rootDoc.Nodes());
                newBody = bodyDoc.ToString();

                var sb = new StringBuilder();
                using (var writer = new StringWriter(sb))
                {
                    bodyDoc.Save(writer, SaveOptions.None);
                }

                foreach (var xe in bodyDoc.Elements())
                {
                    parameters.Add(xe.Name.LocalName, xe.Value);
                }

                using (var sr = new StringReader(sb.ToString()))
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

            result.Body = newBody;
            result.Parameters = parameters;
            result.Execute();

            return result;
        }
    }
}
