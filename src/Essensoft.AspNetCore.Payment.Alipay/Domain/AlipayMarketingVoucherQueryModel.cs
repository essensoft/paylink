using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherQueryModel : AlipayObject
    {
        /// <summary>
        /// 券ID(券唯一标识, 发券接口返回参数)
        /// </summary>
        [JsonProperty("voucher_id")]
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
