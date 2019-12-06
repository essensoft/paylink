using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetReverseDetail Data Structure.
    /// </summary>
    public class AssetReverseDetail : AlipayObject
    {
        /// <summary>
        /// 退货数量
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 取消订单或退货唯一ID
        /// </summary>
        [JsonPropertyName("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 批次号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 物料状态
        /// </summary>
        [JsonPropertyName("goods_status")]
        public string GoodsStatus { get; set; }
    }
}
