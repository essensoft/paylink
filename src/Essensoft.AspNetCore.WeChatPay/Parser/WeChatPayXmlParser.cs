using Essensoft.AspNetCore.WeChatPay.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.WeChatPay.Parser
{
    public class WeChatPayXmlParser<T> : IWeChatPayParser<T> where T : WeChatPayObject
    {
        private static readonly Dictionary<Type, Dictionary<string, PropertyInfo>> DicProperties = new Dictionary<Type, Dictionary<string, PropertyInfo>>();

        public T Parse(string body)
        {
            if (string.IsNullOrEmpty(body))
                throw new ArgumentNullException(nameof(body));

            if (!DicProperties.ContainsKey(typeof(T))) DicProperties[typeof(T)] = GetPropertiesMap(typeof(T));

            var propertiesMap = DicProperties[typeof(T)];

            var result = (T)Activator.CreateInstance(typeof(T));

            result.Body = body;
            var parameters = (result as WeChatPayObject).Parameters;

            try
            {
                var doc = XDocument.Parse(body);
                foreach (var elm in doc.Root.Elements())
                {
                    parameters.Add(elm.Name.LocalName, elm.Value);
                    if (propertiesMap.ContainsKey(elm.Name.LocalName))
                        propertiesMap[elm.Name.LocalName].SetValue(result, elm.Value.TryTo(propertiesMap[elm.Name.LocalName].PropertyType));
                }
            }
            catch
            {
                // 解析XML出错
            }
            return result;
        }

        public T Parse(T result, string body)
        {
            if (string.IsNullOrEmpty(body))
                throw new ArgumentNullException(nameof(body));

            if (!DicProperties.ContainsKey(typeof(T))) DicProperties[typeof(T)] = GetPropertiesMap(typeof(T));

            var propertiesMap = DicProperties[typeof(T)];
            var parameters = (result as WeChatPayObject).Parameters;

            try
            {
                var doc = XDocument.Parse(body);
                foreach (var elm in doc.Root.Elements())
                {
                    parameters.Add(elm.Name.LocalName, elm.Value);
                    if (propertiesMap.ContainsKey(elm.Name.LocalName))
                        propertiesMap[elm.Name.LocalName].SetValue(result, elm.Value.TryTo(propertiesMap[elm.Name.LocalName].PropertyType));
                }
            }
            catch
            {
                // 解析XML出错
            }
            return result;
        }

        private Dictionary<string, PropertyInfo> GetPropertiesMap(Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));
            var propertiesMap = new Dictionary<string, PropertyInfo>();
            var query = from e in typeof(T).GetProperties()
                        where e.CanWrite && e.GetCustomAttributes(typeof(XmlElementAttribute), true).Any()
                        select new { Property = e, Element = e.GetCustomAttributes(typeof(XmlElementAttribute), true).OfType<XmlElementAttribute>().First() };
            foreach (var item in query)
                propertiesMap.Add(item.Element.ElementName, item.Property);

            return propertiesMap;
        }
    }
}
