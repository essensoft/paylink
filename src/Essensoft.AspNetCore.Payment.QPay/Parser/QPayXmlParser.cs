using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.QPay.Parser
{
    /// <summary>
    /// QPay XML 解释器。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QPayXmlParser<T> : IQPayParser<T> where T : QPayObject
    {
        public T Parse(string body)
        {
            T rsp = null;
            var parameters = new QPayDictionary();

            try
            {
                using (var sr = new StringReader(body))
                {
                    var xmldes = new XmlSerializer(typeof(T));
                    rsp = (T)xmldes.Deserialize(sr);
                }

                var doc = XDocument.Parse(body).Root;
                foreach (var xe in doc.Elements())
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
    }
}
