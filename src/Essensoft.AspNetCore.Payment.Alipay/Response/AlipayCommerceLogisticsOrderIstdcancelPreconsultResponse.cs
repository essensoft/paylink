using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsOrderIstdcancelPreconsultResponse.
    /// </summary>
    public class AlipayCommerceLogisticsOrderIstdcancelPreconsultResponse : AlipayResponse
    {
        /// <summary>
        /// 是否允许取消
        /// </summary>
        [JsonPropertyName("allow_cancel")]
        public bool AllowCancel { get; set; }
    }
}
