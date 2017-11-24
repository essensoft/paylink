using System.Xml.Serialization;

namespace Essensoft.AspNetCore.JdPay.Domain
{
    [XmlRoot("result")]
    public class Result
    {
        [XmlElement("code")]
        public string Code { set; get; }

        [XmlElement("desc")]
        public string Desc { set; get; }
    }
}
