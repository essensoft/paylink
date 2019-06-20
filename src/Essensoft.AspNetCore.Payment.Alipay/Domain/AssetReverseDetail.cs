using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetReverseDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AssetReverseDetail : AlipayObject
    {
        /// <summary>
        /// 退货数量
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 取消订单或退货唯一ID
        /// </summary>
        [JsonProperty("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 批次号
        /// </summary>
        [JsonProperty("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 物料状态
        /// </summary>
        [JsonProperty("goods_status")]
        public string GoodsStatus { get; set; }
    }
}
