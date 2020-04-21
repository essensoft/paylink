using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMallScanpurchasePreorderQueryResponse.
    /// </summary>
    public class KoubeiMallScanpurchasePreorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 预订单信息
        /// </summary>
        [JsonPropertyName("advance_order")]
        public AdvanceOrder AdvanceOrder { get; set; }
    }
}
