using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseContentlibOfferSyncResponse.
    /// </summary>
    public class AlipaySocialBaseContentlibOfferSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 返回数据放在这里，使用json
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
