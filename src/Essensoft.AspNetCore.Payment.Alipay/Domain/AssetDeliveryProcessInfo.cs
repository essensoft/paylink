using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetDeliveryProcessInfo Data Structure.
    /// </summary>
    public class AssetDeliveryProcessInfo : AlipayObject
    {
        /// <summary>
        /// 调拨指令ID
        /// </summary>
        [JsonPropertyName("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 对调拨指令的对应批次反馈
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("count")]
        public string Count { get; set; }

        /// <summary>
        /// 送货单编号
        /// </summary>
        [JsonPropertyName("delivery_process_no")]
        public string DeliveryProcessNo { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }
    }
}
