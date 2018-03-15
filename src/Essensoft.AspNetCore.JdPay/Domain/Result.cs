using System.Xml.Serialization;

namespace Essensoft.AspNetCore.JdPay.Domain
{
    [XmlRoot("result")]
    public class Result
    {
        [XmlElement("code")]
        public string Code { get; set; }

        [XmlElement("desc")]
        public string Desc { get; set; }
    }
}
