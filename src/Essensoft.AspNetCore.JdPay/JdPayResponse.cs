using Essensoft.AspNetCore.JdPay.Domain;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.JdPay
{
    [XmlRoot("jdpay")]
    public class JdPayResponse
    {
        [XmlElement("version")]
        public string Version { set; get; }

        [XmlElement("merchant")]
        public string Merchant { set; get; }

        [XmlElement("device")]
        public string Device { set; get; }

        [XmlElement("sign")]
        public string Sign { set; get; }

        [XmlElement("result")]
        public Result Result { set; get; }

        [XmlElement("encrypt")]
        public string Encrypt { set; get; }

        [XmlIgnore]
        public string Body { get; set; }
    }
}
