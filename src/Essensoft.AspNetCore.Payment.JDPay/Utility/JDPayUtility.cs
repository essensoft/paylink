using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using Microsoft.AspNetCore.Http;

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

        internal static bool HasTextXmlContentType(this HttpRequest request)
        {
            // Content-Type: text/xml
            MediaTypeHeaderValue.TryParse(request.ContentType, out var contentType);
            return contentType != null && contentType.MediaType.Equals("text/xml", StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// 尝试将对象实例转换成目标类型
        /// </summary>
        /// <typeparam name="T">对象实例类型</typeparam>
        /// <typeparam name="R">目标类型</typeparam>
        /// <param name="Object">对象实例</param>
        /// <param name="DefaultValue">默认值</param>
        /// <returns>转换后类型</returns>
        internal static object TryTo(this object Object, Type destinationType)
        {
            try
            {
                if (Object == null || Convert.IsDBNull(Object))
                {
                    return GetDefault(destinationType);
                }

                if (Object as string != null)
                {
                    var ObjectValue = Object as string;
                    if (destinationType.IsEnum)
                    {
                        return Enum.Parse(destinationType, ObjectValue, true);
                    }

                    if (string.IsNullOrEmpty(ObjectValue))
                    {
                        return GetDefault(destinationType);
                    }
                }
                if (Object as IConvertible != null)
                {
                    var destination =
                       destinationType.IsGenericType && destinationType.GetGenericTypeDefinition() == typeof(Nullable<>) ?
                           Nullable.GetUnderlyingType(destinationType) : destinationType;
                    return Convert.ChangeType(Object, destination);
                }
                if (destinationType.IsAssignableFrom(Object.GetType()))
                {
                    return Object;
                }

                var Converter = TypeDescriptor.GetConverter(Object.GetType());
                if (Converter.CanConvertTo(destinationType))
                {
                    return Converter.ConvertTo(Object, destinationType);
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
