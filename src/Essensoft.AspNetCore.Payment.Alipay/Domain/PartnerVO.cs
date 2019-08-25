using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PartnerVO Data Structure.
    /// </summary>
    [Serializable]
    public class PartnerVO : AlipayObject
    {
        /// <summary>
        /// 生效状态，EFFECTIVE：生效，INVALID：失效。
        /// </summary>
        [JsonProperty("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonProperty("partner_name")]
        public string PartnerName { get; set; }

        /// <summary>
        /// 商户简码
        /// </summary>
        [JsonProperty("short_code")]
        public string ShortCode { get; set; }
    }
}
