using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainArAdmitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainArAdmitQueryModel : AlipayObject
    {
        /// <summary>
        /// 协议产品码
        /// </summary>
        [JsonProperty("ar_pd_code")]
        public string ArPdCode { get; set; }

        /// <summary>
        /// 请求幂等控制ID
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonProperty("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 站点，目前只支持ALIPAY
        /// </summary>
        [JsonProperty("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点ID
        /// </summary>
        [JsonProperty("site_user_id")]
        public string SiteUserId { get; set; }

        /// <summary>
        /// 场景来源
        /// </summary>
        [JsonProperty("trade_source")]
        public string TradeSource { get; set; }
    }
}
