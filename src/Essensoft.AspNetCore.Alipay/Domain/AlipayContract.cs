using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayContract Data Structure.
    /// </summary>
    public class AlipayContract : AlipayObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 订购的应用名称，有效时间。
        /// </summary>
        [JsonProperty("contract_content")]
        public string ContractContent { get; set; }

        /// <summary>
        /// 订购的失效时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 订购URL。在sign返回false时返回应用的订购地址，可以引导用户订购。
        /// </summary>
        [JsonProperty("page_url")]
        public string PageUrl { get; set; }

        /// <summary>
        /// 订购的生效时间
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 是否订购的标识。true：代表已订购。
        /// </summary>
        [JsonProperty("subscribe")]
        public bool Subscribe { get; set; }
    }
}
