using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodsState Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsState : AlipayObject
    {
        /// <summary>
        /// 算法商品Id
        /// </summary>
        [JsonProperty("algorithm_goods_id")]
        public string AlgorithmGoodsId { get; set; }

        /// <summary>
        /// 商品所在层数
        /// </summary>
        [JsonProperty("floor")]
        public long Floor { get; set; }

        /// <summary>
        /// 已有商品左端坐标(单位:毫米)
        /// </summary>
        [JsonProperty("left_loc")]
        public long LeftLoc { get; set; }
    }
}
