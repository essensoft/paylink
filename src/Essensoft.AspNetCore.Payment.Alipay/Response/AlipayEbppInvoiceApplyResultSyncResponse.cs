using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceApplyResultSyncResponse.
    /// </summary>
    public class AlipayEbppInvoiceApplyResultSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 标注是否需要调用方重试。  当结果返回失败时（code 不等于 10000 且 msg 不等于 SUCCESS  ），如果该字段返回true表明该失败的情况通过重试补偿可解决，为false表明失败情况通过重试无法解决，可以停止重试，根据返回的错误码尝试解决。
        /// </summary>
        [JsonPropertyName("retry_flag")]
        public bool RetryFlag { get; set; }
    }
}
