using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApplyGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ApplyGoodsInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝商品Id(国标码)
        /// </summary>
        [JsonProperty("alipay_goods_id")]
        public string AlipayGoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 备注说明
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 商品图片url1
        /// </summary>
        [JsonProperty("show_url_1")]
        public string ShowUrl1 { get; set; }

        /// <summary>
        /// 商品图片url2
        /// </summary>
        [JsonProperty("show_url_2")]
        public string ShowUrl2 { get; set; }

        /// <summary>
        /// 商品图片url3
        /// </summary>
        [JsonProperty("show_url_3")]
        public string ShowUrl3 { get; set; }

        /// <summary>
        /// 商品三维 (单位mm*mm*mm)
        /// </summary>
        [JsonProperty("three_dimension")]
        public string ThreeDimension { get; set; }

        /// <summary>
        /// 商品重量 (单位g)
        /// </summary>
        [JsonProperty("weight")]
        public string Weight { get; set; }
    }
}
