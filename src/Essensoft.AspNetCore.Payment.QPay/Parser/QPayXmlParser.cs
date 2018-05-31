using System.Xml.Serialization;
using System;
using System.Xml.Linq;
using System.IO;

namespace Essensoft.AspNetCore.Payment.QPay.Parser
{
    public class QPayXmlParser<T> : IQPayParser<T> where T : QPayResponse
    {
        public T Parse(string body)
        {
            if (string.IsNullOrEmpty(body))
            {
                throw new ArgumentNullException(nameof(body));
            }

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
