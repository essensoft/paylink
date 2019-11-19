using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace Essensoft.AspNetCore.Payment.JDPay.Utility
{
    /// <summary>
    /// JDPay 工具类。
    /// </summary>
    public static class JDPayUtility
    {
        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="dictionary">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        public static string BuildQuery(IDictionary<string, string> dictionary)
        {
            var content = new StringBuilder();
            foreach (var iter in dictionary)
            {
                if (!string.IsNullOrEmpty(iter.Value))
                {
                    content.Append(iter.Key + "=" + WebUtility.UrlEncode(iter.Value) + "&");
                }
            }
            return content.ToString().Substring(0, content.Length - 1);
        }

#if NETCOREAPP3_0

        internal static bool HasTextXmlContentType(this Microsoft.AspNetCore.Http.HttpRequest request)
        {
            // Content-Type: text/xml
            System.Net.Http.Headers.MediaTypeHeaderValue.TryParse(request.ContentType, out var contentType);
            return contentType != null && contentType.MediaType.Equals("text/xml", StringComparison.OrdinalIgnoreCase);
        }

#endif

        /// <summary>
        /// 尝试将对象实例转换成目标类型
        /// </summary>
        /// <param name="obj">对象实例</param>
        /// <param name="destinationType">目的类型</param>
        /// <returns>转换后类型</returns>
        internal static object TryTo(this object obj, Type destinationType)
        {
            try
            {
                if (obj == null || Convert.IsDBNull(obj))
                {
                    return GetDefault(destinationType);
                }

                if (obj as string != null)
                {
                    var ObjectValue = obj as string;
                    if (destinationType.IsEnum)
                    {
                        return Enum.Parse(destinationType, ObjectValue, true);
                    }

                    if (string.IsNullOrEmpty(ObjectValue))
                    {
                        return GetDefault(destinationType);
                    }
                }
                if (obj as IConvertible != null)
                {
                    var destination =
                       destinationType.IsGenericType && destinationType.GetGenericTypeDefinition() == typeof(Nullable<>) ?
                           Nullable.GetUnderlyingType(destinationType) : destinationType;
                    return Convert.ChangeType(obj, destination);
                }
                if (destinationType.IsAssignableFrom(obj.GetType()))
                {
                    return obj;
                }

                var Converter = TypeDescriptor.GetConverter(obj.GetType());
                if (Converter.CanConvertTo(destinationType))
                {
                    return Converter.ConvertTo(obj, destinationType);
                }
            }
            catch { }

            return GetDefault(destinationType);
        }

        private static object GetDefault(Type type)
        {
            var defaultExpr = Expression.Default(type);
            return Expression.Lambda<Func<object>>(defaultExpr).Compile()();
        }

        public static string GetValue(XmlDocument doc, string name)
        {
            var nodeList = doc.GetElementsByTagName(name);
            if (nodeList != null && nodeList.Count > 0)
            {
                return nodeList[0].InnerText;
            }

            return string.Empty;
        }

        public static XmlDocument SortedDictionary2AllXml(JDPayDictionary dictionary)
        {
            var xmldoc = new XmlDocument();
            var xmldecl = xmldoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmldoc.AppendChild(xmldecl);
            SortedDictionary2Xml(xmldoc, dictionary);
            return xmldoc;
        }

        public static string SortedDictionary2XmlStr(JDPayDictionary dictionary)
        {
            var xmldoc = new XmlDocument();
            SortedDictionary2Xml(xmldoc, dictionary);
            return ConvertXmlToString(xmldoc);
        }

        public static void SortedDictionary2Xml(XmlDocument xmldoc, JDPayDictionary dictionary)
        {
            var xmlelem = xmldoc.CreateElement("", "jdpay", "");
            xmldoc.AppendChild(xmlelem);
            foreach (var iter in dictionary)
            {
                var xe = xmldoc.CreateElement(iter.Key);
                xe.InnerText = iter.Value;
                xmlelem.AppendChild(xe);
            }
        }

        public static string ConvertXmlToString(XmlDocument xmlDoc)
        {
            return FotmatXmlString(xmlDoc.OuterXml);
        }

        public static string FotmatXmlString(string xmlString)
        {
            xmlString = xmlString.Replace("\r", "");
            xmlString = xmlString.Replace("\n", "");
            xmlString = xmlString.Replace("\t", "");
            xmlString = Regex.Replace(xmlString, @">\s+<", "><");
            xmlString = Regex.Replace(xmlString, @"\s+/>", "/>");
            xmlString = xmlString.Replace("encoding=\"utf-8\"", "encoding=\"UTF-8\"");
            return xmlString;
        }
    }
}
