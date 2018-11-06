using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProductSignStatusInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ProductSignStatusInfo : AlipayObject
    {
        /// <summary>
        /// 产品编码
        /// </summary>
        [JsonProperty("product_code")]
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("product_name")]
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// none:未签约，表示还没有签约该产品  valid:已生效，表示合约已经生效，不需要再签约了  restrictValid:受限生效，表示合约已经生效，但是资料不全，功能受限  audit:审核中，已经有合约在审核中，请等待审核完成  waitConfirm:待商户确认协议，合约已经审核通过，需要商户确认后合约才生效  auditReject:审核未通过  invalid:合约失效，曾经签过合约，但已经失效了，可以重新发起签约  restrictInvalid:受限失效，受限合约失效了
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
