using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandDeliveryGoodsinfoSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandDeliveryGoodsinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 配送指令ID
        /// </summary>
        [JsonPropertyName("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 扩展信息，map的json String
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonPropertyName("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 发货标签，全局唯一
        /// </summary>
        [JsonPropertyName("send_goods_tag")]
        public string SendGoodsTag { get; set; }

        /// <summary>
        /// 标签类型
        /// </summary>
        [JsonPropertyName("tag_type")]
        public string TagType { get; set; }
    }
}
