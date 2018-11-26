using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherLiteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherLiteInfo : AlipayObject
    {
        /// <summary>
        /// 发券时间，格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("send_time")]
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 券状态，可枚举，分别为“可用”(ENABLED)和“不可用”(DISABLED)
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 券模板ID
        /// </summary>
        [JsonProperty("template_id")]
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券ID
        /// </summary>
        [JsonProperty("voucher_id")]
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
