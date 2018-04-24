using Essensoft.AspNetCore.Payment.JDPay.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.JDPay.Response
{
    [XmlRoot("jdpay")]
    public class JDPayQueryRefundResponse : JDPayResponse
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
        /// 门店号
        /// </summary>
        [XmlElement("device")]
        public string Device { get; set; }

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

        /// <summary>
        /// 明细列表
        /// </summary>
        [XmlArray("refList")]
        [XmlArrayItem("refund")]
        public List<Refund> RefundList { get; set; }
    }
}
