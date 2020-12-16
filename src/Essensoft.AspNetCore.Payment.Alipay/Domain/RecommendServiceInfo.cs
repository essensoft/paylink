using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RecommendServiceInfo Data Structure.
    /// </summary>
    public class RecommendServiceInfo : AlipayObject
    {
        /// <summary>
        /// 一级类目
        /// </summary>
        [JsonPropertyName("cate_1")]
        public string Cate1 { get; set; }

        /// <summary>
        /// 二级类目
        /// </summary>
        [JsonPropertyName("cate_2")]
        public string Cate2 { get; set; }

        /// <summary>
        /// 三级类目
        /// </summary>
        [JsonPropertyName("cate_3")]
        public string Cate3 { get; set; }

        /// <summary>
        /// 是否是首选项
        /// </summary>
        [JsonPropertyName("first_choose")]
        public bool FirstChoose { get; set; }

        /// <summary>
        /// 套餐最高价
        /// </summary>
        [JsonPropertyName("max_price")]
        public long MaxPrice { get; set; }

        /// <summary>
        /// 套餐最低价
        /// </summary>
        [JsonPropertyName("min_price")]
        public long MinPrice { get; set; }

        /// <summary>
        /// 服务推荐原因
        /// </summary>
        [JsonPropertyName("recommend_reason")]
        public string RecommendReason { get; set; }

        /// <summary>
        /// 店铺星级
        /// </summary>
        [JsonPropertyName("star")]
        public long Star { get; set; }
    }
}
