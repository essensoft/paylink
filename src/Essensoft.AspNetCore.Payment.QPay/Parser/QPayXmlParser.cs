using Newtonsoft.Json;
using System;
using System.Collections;
using System.Linq;
using System.Xml.Linq;

namespace Essensoft.AspNetCore.Payment.QPay.Parser
{
    public class QPayXmlParser<T> : IQPayParser<T> where T : QPayResponse
    {
        public T Parse(string body)
        {
            if (string.IsNullOrEmpty(body))
                throw new ArgumentNullException(nameof(body));

            T rsp = null;
            var parameters = new QPayDictionary();

            try
            {
                var doc = XDocument.Parse(body).Root;
                var text = doc.DescendantNodes().OfType<XText>().ToList();
                foreach (var t in text)
                {
                    parameters.Add(t.Parent.Name.LocalName, t.Value);
                    if (t is XCData)
                    {
                        t.Parent.Add(t.Value);
                        t.Remove();
                    }
                }

                var jsonText = JsonConvert.SerializeXNode(doc);
                var json = JsonConvert.DeserializeObject<IDictionary>(jsonText);
                if (json != null)
                {
                    // 忽略根节点的名称
                    foreach (var key in json.Keys)
                    {
                        var data = json[key].ToString();
                        if (!string.IsNullOrEmpty(data))
                        {
                            rsp = JsonConvert.DeserializeObject<T>(data);
                            break;
                        }
                    }

                }
            }
            catch { }

            if (rsp == null)
                rsp = Activator.CreateInstance<T>();

            if (rsp != null)
            {
                rsp.Body = body;

                rsp.Parameters = parameters;
            }

            return rsp;
        }
    }
}
