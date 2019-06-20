using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodsComponent Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsComponent : AlipayObject
    {
        /// <summary>
        /// 货品code
        /// </summary>
        [JsonProperty("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 货品名称
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 组成数量
        /// </summary>
        [JsonProperty("quantity")]
        public string Quantity { get; set; }
    }
}
