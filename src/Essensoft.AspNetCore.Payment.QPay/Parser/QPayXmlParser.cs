using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.QPay.Parser
{
    public class QPayXmlParser<T> : IQPayParser<T> where T : QPayObject
    {
        public T Parse(string body)
        {
            T result = null;
            var parameters = new QPayDictionary();

            try
            {
                var doc = XDocument.Parse(body).Root;
                foreach (var element in doc.Elements())
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

            result.ResponseBody = body;
            result.ResponseParameters = parameters;
            result.Execute();

            return result;
        }
    }
}
