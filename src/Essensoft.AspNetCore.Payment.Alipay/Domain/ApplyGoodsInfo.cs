using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApplyGoodsInfo Data Structure.
    /// </summary>
    public class ApplyGoodsInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝商品Id(国标码)
        /// </summary>
        [JsonPropertyName("alipay_goods_id")]
        public string AlipayGoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 备注说明
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 商品图片url1
        /// </summary>
        [JsonPropertyName("show_url_1")]
        public string ShowUrl1 { get; set; }

        /// <summary>
        /// 商品图片url2
        /// </summary>
        [JsonPropertyName("show_url_2")]
        public string ShowUrl2 { get; set; }

        /// <summary>
        /// 商品图片url3
        /// </summary>
        [JsonPropertyName("show_url_3")]
        public string ShowUrl3 { get; set; }

        /// <summary>
        /// 商品三维 (单位mm*mm*mm)
        /// </summary>
        [JsonPropertyName("three_dimension")]
        public string ThreeDimension { get; set; }

        /// <summary>
        /// 商品重量 (单位g)
        /// </summary>
        [JsonPropertyName("weight")]
        public string Weight { get; set; }
    }
}
