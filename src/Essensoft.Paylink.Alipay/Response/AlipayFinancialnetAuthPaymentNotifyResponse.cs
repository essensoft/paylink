using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthPaymentNotifyResponse.
    /// </summary>
    public class AlipayFinancialnetAuthPaymentNotifyResponse : AlipayResponse
    {
        /// <summary>
        /// 响应结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 响应结果描述
        /// </summary>
        [JsonPropertyName("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 业务结果是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }
    }
}
