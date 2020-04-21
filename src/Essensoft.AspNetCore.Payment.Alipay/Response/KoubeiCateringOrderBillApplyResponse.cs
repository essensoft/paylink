using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringOrderBillApplyResponse.
    /// </summary>
    public class KoubeiCateringOrderBillApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 是否需要重试
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }
}
