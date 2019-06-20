using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BkPosGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BkPosGoodsInfo : AlipayObject
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品金额
        /// </summary>
        [JsonProperty("goods_price")]
        public string GoodsPrice { get; set; }
    }
}
