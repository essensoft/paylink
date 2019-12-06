using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotApplyorderStatusSyncModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotApplyorderStatusSyncModel : AlipayObject
    {
        /// <summary>
        /// 申请单状态
        /// </summary>
        [JsonPropertyName("apply_order_status")]
        public string ApplyOrderStatus { get; set; }

        /// <summary>
        /// 物料申请单号
        /// </summary>
        [JsonPropertyName("asset_apply_order_id")]
        public string AssetApplyOrderId { get; set; }
    }
}
