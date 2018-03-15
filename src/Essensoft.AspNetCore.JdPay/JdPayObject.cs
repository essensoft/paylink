using Essensoft.AspNetCore.JdPay.Domain;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.JdPay
{
    public abstract class JdPayObject
    {
        [XmlElement("version")]
        public string Version { get; set; }

        [XmlElement("merchant")]
        public string Merchant { get; set; }

        [XmlElement("device")]
        public string Device { get; set; }

        [XmlElement("sign")]
        public string Sign { get; set; }

        [XmlElement("result")]
        public Result Result { get; set; }

        [XmlElement("encrypt")]
        public string Encrypt { get; set; }

        [XmlIgnore]
        public string Body { get; set; }

    }
}
