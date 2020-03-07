using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMallScanpurchaseUserpreorderQueryModel Data Structure.
    /// </summary>
    public class KoubeiMallScanpurchaseUserpreorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 预订单编号
        /// </summary>
        [JsonPropertyName("advance_order_id")]
        public string AdvanceOrderId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
