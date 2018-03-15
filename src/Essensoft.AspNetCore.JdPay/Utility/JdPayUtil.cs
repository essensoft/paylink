using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.JdPay.Utility
{
    public class JdPayUtil
    {
        public static T Deserialize<T>(string xml)
        {
            try
            {
                using (var sr = new StringReader(xml))
                {
                    var xmldes = new XmlSerializer(typeof(T));
                    return (T)xmldes.Deserialize(sr);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
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

        public static XmlDocument SortedDictionary2AllXml(JdPayDictionary dic)
        {
            var xmldoc = new XmlDocument();
            var xmldecl = xmldoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmldoc.AppendChild(xmldecl);
            SortedDictionary2Xml(xmldoc, dic);
            return xmldoc;
        }

        public static string SortedDictionary2XmlStr(JdPayDictionary dic)
        {
            var xmldoc = new XmlDocument();
            SortedDictionary2Xml(xmldoc, dic);
            return ConvertXmlToString(xmldoc);
        }

        public static void SortedDictionary2Xml(XmlDocument xmldoc, JdPayDictionary dic)
        {
            var xmlelem = xmldoc.CreateElement("", "jdpay", "");
            xmldoc.AppendChild(xmlelem);
            foreach (var kv in dic)
            {
                var xe = xmldoc.CreateElement(kv.Key);
                xe.InnerText = kv.Value;
                xmlelem.AppendChild(xe);
            }
        }

        public static string ConvertXmlToString(XmlDocument xmlDoc)
        {
            var stream = new MemoryStream();
            var writer = new XmlTextWriter(stream, Encoding.UTF8)
            {
                Formatting = Formatting.Indented
            };
            xmlDoc.Save(writer);
            var sr = new StreamReader(stream, Encoding.UTF8);
            stream.Position = 0;
            var xmlString = sr.ReadToEnd();
            sr.Close();
            stream.Close();
            return FotmatXmlString(xmlString);
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
