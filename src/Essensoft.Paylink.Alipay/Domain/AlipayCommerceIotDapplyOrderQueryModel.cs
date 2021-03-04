using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrderQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotDapplyOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 物料申请单号
        /// </summary>
        [JsonPropertyName("asset_apply_order_id")]
        public string AssetApplyOrderId { get; set; }
    }
}
