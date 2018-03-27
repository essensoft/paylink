using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtItem Data Structure.
    /// </summary>
    public class ExtItem : AlipayObject
    {
        /// <summary>
        /// 品牌编码
        /// </summary>
        [JsonProperty("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 品类编码
        /// </summary>
        [JsonProperty("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 入数，必须为整数
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; set; }

        /// <summary>
        /// 产地
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 商品条码
        /// </summary>
        [JsonProperty("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品图片url
        /// </summary>
        [JsonProperty("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 参考价格，单位（分），必须为整数
        /// </summary>
        [JsonProperty("price")]
        public long Price { get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [JsonProperty("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
