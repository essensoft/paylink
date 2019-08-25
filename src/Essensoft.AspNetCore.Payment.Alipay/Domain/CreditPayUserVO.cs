using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayUserVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayUserVO : AlipayObject
    {
        /// <summary>
        /// 支付宝UID
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 1.ALIPAY(支付宝)  2.TAOBAO(淘宝)  3.CBU(中文站)  4.ICBU(国际站)
        /// </summary>
        [JsonProperty("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点用户id
        /// </summary>
        [JsonProperty("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
