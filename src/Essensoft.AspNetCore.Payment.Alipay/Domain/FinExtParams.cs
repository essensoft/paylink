using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FinExtParams Data Structure.
    /// </summary>
    public class FinExtParams : AlipayObject
    {
        /// <summary>
        /// 返回的url
        /// </summary>
        [JsonPropertyName("page_return_url")]
        public string PageReturnUrl { get; set; }

        /// <summary>
        /// 超时时间
        /// </summary>
        [JsonPropertyName("time_expire")]
        public string TimeExpire { get; set; }
    }
}
