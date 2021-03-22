using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// IoTBPaaSMerchantOrderItemInfo Data Structure.
    /// </summary>
    public class IoTBPaaSMerchantOrderItemInfo : AlipayObject
    {
        /// <summary>
        /// 商品属性列表
        /// </summary>
        [JsonPropertyName("attrs")]
        public List<IoTBPaaSKeyValue> Attrs { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonPropertyName("item_num")]
        public string ItemNum { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        [JsonPropertyName("item_price")]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 商品规格列表
        /// </summary>
        [JsonPropertyName("specs")]
        public List<IoTBPaaSKeyValue> Specs { get; set; }
    }
}
