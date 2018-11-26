using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherAuthSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherAuthSendModel : AlipayObject
    {
        /// <summary>
        /// 外部业务订单号，用于幂等控制
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 经过用户授权过后的发券码
        /// </summary>
        [JsonProperty("send_code")]
        [XmlElement("send_code")]
        public string SendCode { get; set; }

        /// <summary>
        /// 券模板ID
        /// </summary>
        [JsonProperty("template_id")]
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
