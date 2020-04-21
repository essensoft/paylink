using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMallScanpurchasePreorderCancelModel Data Structure.
    /// </summary>
    public class KoubeiMallScanpurchasePreorderCancelModel : AlipayObject
    {
        /// <summary>
        /// 预订单编号
        /// </summary>
        [JsonPropertyName("advance_order_id")]
        public string AdvanceOrderId { get; set; }
    }
}
