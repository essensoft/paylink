using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.JDPay.Domain;

namespace Essensoft.AspNetCore.Payment.JDPay.Response
{
    [XmlRoot("jdpay")]
    public class JDPayCancelUserRelationResponse : JDPayResponse
    {
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
        /// 数据签名
        /// </summary>
        [XmlElement("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [XmlElement("result")]
        public Result Result { get; set; }
    }
}
