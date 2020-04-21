using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetReverseItem Data Structure.
    /// </summary>
    public class AssetReverseItem : AlipayObject
    {
        /// <summary>
        /// 行为类型
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 逆向申请单ID
        /// </summary>
        [JsonPropertyName("apply_order_id")]
        public string ApplyOrderId { get; set; }

        /// <summary>
        /// 逆向申请单明细ID
        /// </summary>
        [JsonPropertyName("apply_order_item_id")]
        public string ApplyOrderItemId { get; set; }

        /// <summary>
        /// returning goods info
        /// </summary>
        [JsonPropertyName("asset_reverse_goods_items")]
        public AssetReverseGoodsItem AssetReverseGoodsItems { get; set; }

        /// <summary>
        /// 取消订单或退货唯一Id
        /// </summary>
        [JsonPropertyName("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 退货数量
        /// </summary>
        [JsonPropertyName("count")]
        public string Count { get; set; }

        /// <summary>
        /// 出货地址
        /// </summary>
        [JsonPropertyName("from_address")]
        public AssetDeliveryAddress FromAddress { get; set; }

        /// <summary>
        /// 物料ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 物料名
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 原申请单ID
        /// </summary>
        [JsonPropertyName("original_apply_order_id")]
        public string OriginalApplyOrderId { get; set; }

        /// <summary>
        /// 原配送单明细ID
        /// </summary>
        [JsonPropertyName("original_apply_order_item_id")]
        public string OriginalApplyOrderItemId { get; set; }

        /// <summary>
        /// 原配送单物料号
        /// </summary>
        [JsonPropertyName("original_delivery_assign_item_id")]
        public string OriginalDeliveryAssignItemId { get; set; }

        /// <summary>
        /// 用于标识该指令为中转或者配送至客户. 其他类型的配送指令为空值
        /// </summary>
        [JsonPropertyName("original_record_type")]
        public string OriginalRecordType { get; set; }

        /// <summary>
        /// 公司主体代码
        /// </summary>
        [JsonPropertyName("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 公司主体名
        /// </summary>
        [JsonPropertyName("ou_name")]
        public string OuName { get; set; }

        /// <summary>
        /// 逆向类型
        /// </summary>
        [JsonPropertyName("reverse_type")]
        public string ReverseType { get; set; }

        /// <summary>
        /// 目标地址
        /// </summary>
        [JsonPropertyName("to_address")]
        public AssetDeliveryAddress ToAddress { get; set; }
    }
}
