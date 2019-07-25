using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetDeliveryProcessInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssetDeliveryProcessInfo : AlipayObject
    {
        /// <summary>
        /// 调拨指令ID
        /// </summary>
        [JsonProperty("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 对调拨指令的对应批次反馈
        /// </summary>
        [JsonProperty("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("count")]
        public string Count { get; set; }

        /// <summary>
        /// 送货单编号
        /// </summary>
        [JsonProperty("delivery_process_no")]
        public string DeliveryProcessNo { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }
    }
}
