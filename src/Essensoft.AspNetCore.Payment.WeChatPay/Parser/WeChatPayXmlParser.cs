using Newtonsoft.Json;
using System;
using System.Collections;
using System.Linq;
using System.Xml.Linq;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Parser
{
    public class WeChatPayXmlParser<T> : IWeChatPayParser<T> where T : WeChatPayResponse
    {
        public T Parse(string body)
        {
            if (string.IsNullOrEmpty(body))
                throw new ArgumentNullException(nameof(body));

            T rsp = null;
            var parameters = new WeChatPayDictionary();

            try
            {
                var doc = XDocument.Parse(body).Root;
                var text = doc.DescendantNodes().OfType<XText>().ToList();
                foreach (var t in text)
                {
                    parameters.Add(t.Parent.Name.LocalName, t.Value);

                    // 移除CData
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

        public T Parse(string body, string data)
        {
            if (string.IsNullOrEmpty(body))
                throw new ArgumentNullException(nameof(body));

            if (string.IsNullOrEmpty(data))
                throw new ArgumentNullException(nameof(data));

            T rsp = null;
            var parameters = new WeChatPayDictionary();

            try
            {
                var bodyDoc = XDocument.Parse(body).Element("xml");
                var dataDoc = XDocument.Parse(data).Element("root");
                bodyDoc.Add(dataDoc.Nodes());

                var text = bodyDoc.DescendantNodes().OfType<XText>().ToList();
                foreach (var t in text)
                {
                    parameters.Add(t.Parent.Name.LocalName, t.Value);
                    if (t is XCData)
                    {
                        t.Parent.Add(t.Value);
                        t.Remove();
                    }
                }

                var jsonText = JsonConvert.SerializeXNode(bodyDoc);
                var json = JsonConvert.DeserializeObject<IDictionary>(jsonText);
                if (json != null)
                {
                    // 忽略根节点的名称
                    foreach (var key in json.Keys)
                    {
                        var str = json[key].ToString();
                        if (!string.IsNullOrEmpty(str))
                        {
                            rsp = JsonConvert.DeserializeObject<T>(str);
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
                rsp.Body = data;

                rsp.Parameters = parameters;
            }

            return rsp;
        }
    }
}
