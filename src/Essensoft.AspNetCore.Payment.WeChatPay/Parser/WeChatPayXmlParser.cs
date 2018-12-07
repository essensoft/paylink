using System;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Parser
{
    /// <summary>
    /// WeChatPay XML 解释器。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class WeChatPayXmlParser<T> : IWeChatPayParser<T> where T : WeChatPayObject
    {
        public T Parse(string body)
        {
            T result = null;
            var parameters = new WeChatPayDictionary();

            try
            {
                using (var sr = new StringReader(body))
                {
                    var xmldes = new XmlSerializer(typeof(T));
                    result = (T)xmldes.Deserialize(sr);
                }

                var bodyDoc = XDocument.Parse(body).Element("xml");
                foreach (var element in bodyDoc.Elements())
                {
                    parameters.Add(element.Name.LocalName, element.Value);
                }
            }
            catch { }

            if (result == null)
            {
                result = Activator.CreateInstance<T>();
            }

            if (result != null)
            {
                result.Body = body;

                result.Parameters = parameters;

                result.Execute();
            }

            return result;
        }

        public T Parse(string body, string data)
        {
            T result = null;
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
                    result = (T)xmldes.Deserialize(sr);
                }

                foreach (var xe in bodyDoc.Elements())
                {
                    parameters.Add(xe.Name.LocalName, xe.Value);
                }
            }
            catch { }

            if (result == null)
            {
                result = Activator.CreateInstance<T>();
            }

            if (result != null)
            {
                result.Body = data;

                result.Parameters = parameters;

                result.Execute();
            }

            return result;
        }
    }
}
