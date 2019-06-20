using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetReverseGoodsItem Data Structure.
    /// </summary>
    [Serializable]
    public class AssetReverseGoodsItem : AlipayObject
    {
        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 阶段
        /// </summary>
        [JsonProperty("phase")]
        public string Phase { get; set; }

        /// <summary>
        /// 逆向申请单ID
        /// </summary>
        [JsonProperty("reverse_apply_order_id")]
        public string ReverseApplyOrderId { get; set; }

        /// <summary>
        /// 逆向申请单明细ID
        /// </summary>
        [JsonProperty("reverse_apply_order_item_id")]
        public string ReverseApplyOrderItemId { get; set; }

        /// <summary>
        /// 标识类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 申请输入信息
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
