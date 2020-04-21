using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetReverseGoodsItem Data Structure.
    /// </summary>
    public class AssetReverseGoodsItem : AlipayObject
    {
        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 阶段
        /// </summary>
        [JsonPropertyName("phase")]
        public string Phase { get; set; }

        /// <summary>
        /// 逆向申请单ID
        /// </summary>
        [JsonPropertyName("reverse_apply_order_id")]
        public string ReverseApplyOrderId { get; set; }

        /// <summary>
        /// 逆向申请单明细ID
        /// </summary>
        [JsonPropertyName("reverse_apply_order_item_id")]
        public string ReverseApplyOrderItemId { get; set; }

        /// <summary>
        /// 标识类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 申请输入信息
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
