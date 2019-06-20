using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetReverseItem Data Structure.
    /// </summary>
    [Serializable]
    public class AssetReverseItem : AlipayObject
    {
        /// <summary>
        /// 行为类型
        /// </summary>
        [JsonProperty("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 逆向申请单ID
        /// </summary>
        [JsonProperty("apply_order_id")]
        public string ApplyOrderId { get; set; }

        /// <summary>
        /// 逆向申请单明细ID
        /// </summary>
        [JsonProperty("apply_order_item_id")]
        public string ApplyOrderItemId { get; set; }

        /// <summary>
        /// returning goods info
        /// </summary>
        [JsonProperty("asset_reverse_goods_items")]
        public AssetReverseGoodsItem AssetReverseGoodsItems { get; set; }

        /// <summary>
        /// 取消订单或退货唯一Id
        /// </summary>
        [JsonProperty("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 退货数量
        /// </summary>
        [JsonProperty("count")]
        public string Count { get; set; }

        /// <summary>
        /// 物料ID
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 物料名
        /// </summary>
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 原申请单ID
        /// </summary>
        [JsonProperty("original_apply_order_id")]
        public string OriginalApplyOrderId { get; set; }

        /// <summary>
        /// 原配送单明细ID
        /// </summary>
        [JsonProperty("original_apply_order_item_id")]
        public string OriginalApplyOrderItemId { get; set; }

        /// <summary>
        /// 原配送单物料号
        /// </summary>
        [JsonProperty("original_delivery_assign_item_id")]
        public string OriginalDeliveryAssignItemId { get; set; }

        /// <summary>
        /// 用于标识该指令为中转或者配送至客户. 其他类型的配送指令为空值
        /// </summary>
        [JsonProperty("original_record_type")]
        public string OriginalRecordType { get; set; }

        /// <summary>
        /// 公司主体代码
        /// </summary>
        [JsonProperty("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 公司主体名
        /// </summary>
        [JsonProperty("ou_name")]
        public string OuName { get; set; }

        /// <summary>
        /// 逆向类型
        /// </summary>
        [JsonProperty("reverse_type")]
        public string ReverseType { get; set; }
    }
}
