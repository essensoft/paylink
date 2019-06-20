using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDetail : AlipayObject
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品价格，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量。目前仅支持整数，若需要传小数，请咨询支付宝小二或接口owner
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }
    }
}
