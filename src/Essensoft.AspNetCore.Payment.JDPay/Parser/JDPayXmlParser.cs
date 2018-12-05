using System;
using System.IO;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.JDPay.Parser
{
    /// <summary>
    /// JDPay XML 解释器。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JDPayXmlParser<T> : IJDPayParser<T> where T : JDPayObject
    {
        public T Parse(string body)
        {
            T rsp = null;

            try
            {
                using (var sr = new StringReader(body))
                {
                    var xmldes = new XmlSerializer(typeof(T));
                    rsp = (T)xmldes.Deserialize(sr);
                }
            }
            catch
            { }

            if (rsp == null)
            {
                rsp = Activator.CreateInstance<T>();
            }

            if (rsp != null)
            {
                rsp.Body = body;
            }

            return rsp;
        }
    }
}
