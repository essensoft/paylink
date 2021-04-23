using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// RecommendGoods Data Structure.
    /// </summary>
    public class RecommendGoods : AlipayObject
    {
        /// <summary>
        /// 商品barcode
        /// </summary>
        [JsonPropertyName("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 行业商品goodsCode
        /// </summary>
        [JsonPropertyName("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 推荐排名
        /// </summary>
        [JsonPropertyName("rank")]
        public string Rank { get; set; }

        /// <summary>
        /// 推荐商品使用货道数
        /// </summary>
        [JsonPropertyName("recommend_channels_count")]
        public string RecommendChannelsCount { get; set; }

        /// <summary>
        /// 推荐商品数量
        /// </summary>
        [JsonPropertyName("recommend_goods_count")]
        public string RecommendGoodsCount { get; set; }

        /// <summary>
        /// 商品推荐理由
        /// </summary>
        [JsonPropertyName("recommend_reason")]
        public string RecommendReason { get; set; }
    }
}
