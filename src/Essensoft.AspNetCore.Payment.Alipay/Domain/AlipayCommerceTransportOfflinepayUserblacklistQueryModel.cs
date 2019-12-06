using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayUserblacklistQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportOfflinepayUserblacklistQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户黑名单分页ID，1开始
        /// </summary>
        [JsonPropertyName("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 脱机交易用户黑名单分页页大小，最大页大小不超过1000
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
