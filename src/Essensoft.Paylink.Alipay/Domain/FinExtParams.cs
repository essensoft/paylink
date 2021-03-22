using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// FinExtParams Data Structure.
    /// </summary>
    public class FinExtParams : AlipayObject
    {
        /// <summary>
        /// 机构的appid
        /// </summary>
        [JsonPropertyName("inst_appid")]
        public string InstAppid { get; set; }

        /// <summary>
        /// isv编码
        /// </summary>
        [JsonPropertyName("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 返回的url
        /// </summary>
        [JsonPropertyName("page_return_url")]
        public string PageReturnUrl { get; set; }

        /// <summary>
        /// 订单来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 超时时间
        /// </summary>
        [JsonPropertyName("time_expire")]
        public string TimeExpire { get; set; }
    }
}
