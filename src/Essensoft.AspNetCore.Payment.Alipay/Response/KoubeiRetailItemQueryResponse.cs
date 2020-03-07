using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailItemQueryResponse.
    /// </summary>
    public class KoubeiRetailItemQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 封面图url地址
        /// </summary>
        [JsonPropertyName("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonPropertyName("descriptions")]
        public List<RetailItemDescription> Descriptions { get; set; }

        /// <summary>
        /// 折扣比例，5折：0.5
        /// </summary>
        [JsonPropertyName("discount_rate")]
        public string DiscountRate { get; set; }

        /// <summary>
        /// 商品失效时间
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 商品生效时间
        /// </summary>
        [JsonPropertyName("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品状态，共有5个状态：INIT（初始状态）EFFECTIVE（生效）PAUSE（暂停）FREEZE(冻结)INVALID（失效）
        /// </summary>
        [JsonPropertyName("item_status")]
        public string ItemStatus { get; set; }

        /// <summary>
        /// 商品原价(减至券)。单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("original_amount")]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// 商品详情图片列表
        /// </summary>
        [JsonPropertyName("picture_list")]
        public List<string> PictureList { get; set; }

        /// <summary>
        /// 优惠价(减至券)。单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("reduce_to_amount")]
        public string ReduceToAmount { get; set; }

        /// <summary>
        /// 商品适用的门店信息列表
        /// </summary>
        [JsonPropertyName("shop_list")]
        public List<string> ShopList { get; set; }

        /// <summary>
        /// 适用的sku列表,最多支持800个SKU，超过返回为空
        /// </summary>
        [JsonPropertyName("sku_list")]
        public List<string> SkuList { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 券类型：CASH为代金券，DISCOUNT为折扣券;ALL为全场，SINGLE为单品
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 代金券金额：满100减30 => 30。单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("value_amount")]
        public string ValueAmount { get; set; }
    }
}
