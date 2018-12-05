using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.JDPay.Utility;

namespace Essensoft.AspNetCore.Payment.JDPay.Parser
{
    /// <summary>
    /// JDPay 字典解释器。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JDPayDictionaryParser<T> where T : JDPayNotify
    {
        private static readonly Dictionary<Type, Dictionary<string, PropertyInfo>> DicProperties = new Dictionary<Type, Dictionary<string, PropertyInfo>>();

        public T Parse(JDPayDictionary dic)
        {
            if (dic == null || dic.Count == 0)
            {
                throw new ArgumentNullException(nameof(dic));
            }

            if (!DicProperties.ContainsKey(typeof(T)))
            {
                DicProperties[typeof(T)] = GetPropertiesMap(typeof(T));
            }

            var propertiesMap = DicProperties[typeof(T)];

            var rsp = Activator.CreateInstance<T>();

            foreach (var item in dic)
            {
                if (propertiesMap.ContainsKey(item.Key))
                {
                    propertiesMap[item.Key].SetValue(rsp, item.Value.TryTo(propertiesMap[item.Key].PropertyType));
                }
            }

            if (rsp != null)
            {
                rsp.Parameters = dic;
            }

            return rsp;
        }

        private Dictionary<string, PropertyInfo> GetPropertiesMap(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            var propertiesMap = new Dictionary<string, PropertyInfo>();
            var query = from e in typeof(T).GetProperties()
                        where e.CanWrite && e.GetCustomAttributes(typeof(XmlElementAttribute), true).Any()
                        select new { Property = e, Element = e.GetCustomAttributes(typeof(XmlElementAttribute), true).OfType<XmlElementAttribute>().First() };
            foreach (var item in query)
            {
                propertiesMap.Add(item.Element.ElementName, item.Property);
            }

            return propertiesMap;
        }
    }
}
