using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceDataScenicSyncResponse.
    /// </summary>
    public class AlipayCommerceDataScenicSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 对应服务商请求中的outer_id
        /// </summary>
        [JsonPropertyName("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 对应服务商请求中的scenic_app_id
        /// </summary>
        [JsonPropertyName("scenic_app_id")]
        public string ScenicAppId { get; set; }

        /// <summary>
        /// 对应服务商请求中的scenic_id
        /// </summary>
        [JsonPropertyName("scenic_id")]
        public string ScenicId { get; set; }

        /// <summary>
        /// 出现异常 "同一个appId+outerId下不能对应两个景区" 时，才会有值，表示outer_id+scenic_app_id在支付宝域维护的景区ID
        /// </summary>
        [JsonPropertyName("zfb_scenic_id")]
        public string ZfbScenicId { get; set; }
    }
}
