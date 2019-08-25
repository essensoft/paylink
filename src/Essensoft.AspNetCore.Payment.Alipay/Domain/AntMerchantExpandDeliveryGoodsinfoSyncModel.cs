using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandDeliveryGoodsinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandDeliveryGoodsinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 配送指令ID
        /// </summary>
        [JsonProperty("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 扩展信息，map的json String
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonProperty("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 发货标签，全局唯一
        /// </summary>
        [JsonProperty("send_goods_tag")]
        public string SendGoodsTag { get; set; }

        /// <summary>
        /// 标签类型
        /// </summary>
        [JsonProperty("tag_type")]
        public string TagType { get; set; }
    }
}
