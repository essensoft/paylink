using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffLogisticsinstockSyncResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffLogisticsinstockSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 报错编码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 报错描述
        /// </summary>
        [JsonPropertyName("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 本次调用的requestId
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 调用是否成功（true/false）
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
