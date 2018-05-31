using System;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Parser
{
    public class WeChatPayXmlParser<T> : IWeChatPayParser<T> where T : WeChatPayResponse
    {
        public T Parse(string body)
        {
            if (string.IsNullOrEmpty(body))
            {
                throw new ArgumentNullException(nameof(body));
            }

            T rsp = null;
            var parameters = new WeChatPayDictionary();

            try
            {
                using (var sr = new StringReader(body))
                {
                    var xmldes = new XmlSerializer(typeof(T));
                    rsp = (T)xmldes.Deserialize(sr);
                }

                var bodyDoc = XDocument.Parse(body).Element("xml");
                foreach (var xe in bodyDoc.Elements())
                {
                    parameters.Add(xe.Name.LocalName, xe.Value);
                }
            }
            catch { }

            if (rsp == null)
            {
                rsp = Activator.CreateInstance<T>();
            }

            if (rsp != null)
            {
                rsp.Body = body;

                rsp.Parameters = parameters;

                rsp.Execute();
            }

            return rsp;
        }

        public T Parse(string body, string data)
        {
            if (string.IsNullOrEmpty(body))
            {
                throw new ArgumentNullException(nameof(body));
            }

            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            T rsp = null;
            var parameters = new WeChatPayDictionary();

            try
            {
                var bodyDoc = XDocument.Parse(body).Element("xml");
                var rootDoc = XDocument.Parse(data).Element("root");
                bodyDoc.Add(rootDoc.Nodes());

                var sb = new StringBuilder();
                using (var writer = new StringWriter(sb))
                {
                    bodyDoc.Save(writer, SaveOptions.None);
                }

                using (var sr = new StringReader(sb.ToString()))
                {
                    var xmldes = new XmlSerializer(typeof(T));
                    rsp = (T)xmldes.Deserialize(sr);
                }

                foreach (var xe in bodyDoc.Elements())
                {
                    parameters.Add(xe.Name.LocalName, xe.Value);
                }
            }
            catch { }

            if (rsp == null)
            {
                rsp = Activator.CreateInstance<T>();
            }

            if (rsp != null)
            {
                rsp.Body = data;

                rsp.Parameters = parameters;

                rsp.Execute();
            }

            return rsp;
        }
    }
}
