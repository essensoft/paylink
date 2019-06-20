using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MallGoodsDetail Data Structure.
    /// </summary>
    [Serializable]
    public class MallGoodsDetail : AlipayObject
    {
        /// <summary>
        /// 商品描述信息
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// 商品的编号
        /// </summary>
        [JsonProperty("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品原价
        /// </summary>
        [JsonProperty("org_price")]
        public string OrgPrice { get; set; }

        /// <summary>
        /// 商品单价，单位为元
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品的展示地址
        /// </summary>
        [JsonProperty("show_url")]
        public string ShowUrl { get; set; }
    }
}
