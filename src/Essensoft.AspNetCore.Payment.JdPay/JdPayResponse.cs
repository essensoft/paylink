using Essensoft.AspNetCore.Payment.JDPay.Domain;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.JDPay
{
    public abstract class JDPayResponse : JDPayObject
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [XmlIgnore]
        public string Body { get; set; }

        /// <summary>
        /// 原始参数
        /// </summary>
        [XmlIgnore]
        public JDPayDictionary Parameters { get; internal set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("version")]
        public string Version { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [XmlElement("merchant")]
        public string Merchant { get; set; }

        /// <summary>
        /// 门店号
        /// </summary>
        [XmlElement("device")]
        public string Device { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [XmlElement("result")]
        public Result Result { get; set; }

        /// <summary>
        /// 数据签名
        /// </summary>
        [XmlElement("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 加密报文
        /// </summary>
        [XmlElement("encrypt")]
        public string Encrypt { get; set; }
    }
}
