using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelShopSyncModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelShopSyncModel : AlipayObject
    {
        /// <summary>
        /// 地图可以搜索的到的店铺详细地址。对于线下店铺，地址为必填，线上店铺为非必填。
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 店铺品牌logo图片url
        /// </summary>
        [JsonPropertyName("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 店铺营业时间,线下店铺该字段必填。线上店铺非必填。
        /// </summary>
        [JsonPropertyName("business_hours")]
        public List<BusinessHour> BusinessHours { get; set; }

        /// <summary>
        /// 国家简码,参考标准 ISO 3166-1 alpha-2 code
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// 店铺配送费,币种遵循 ISO 4217 标准，金额数值为正整数且精确到货币最小单位
        /// </summary>
        [JsonPropertyName("delivery_fee")]
        public Amount DeliveryFee { get; set; }

        /// <summary>
        /// 外链地址,可以是许可范围内的支付宝小程序地址，H5链接等。
        /// </summary>
        [JsonPropertyName("external_link_url")]
        public string ExternalLinkUrl { get; set; }

        /// <summary>
        /// 店铺起送费用,币种遵循 ISO 4217 标准，金额数值为正整数且精确到货币最小单位
        /// </summary>
        [JsonPropertyName("fee")]
        public Amount Fee { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 收单报备的二级商户id
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 外部店铺ID，与appId一起构成店铺的唯一性。
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 收单报备的pid
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 优惠促销文案列表,可传入一个或多个
        /// </summary>
        [JsonPropertyName("promotion_text")]
        public string PromotionText { get; set; }

        /// <summary>
        /// 推荐标识。Y:代表推荐,N代表不置顶推荐。当同一个外铺平台中的店铺以列表形式露出时，推荐标识为Y的店铺排序会有权重提升
        /// </summary>
        [JsonPropertyName("recommend")]
        public string Recommend { get; set; }

        /// <summary>
        /// 业务场景，可传入一个或多个,该字段用来标识商品的适用业务场景。
        /// </summary>
        [JsonPropertyName("scenarios")]
        public List<string> Scenarios { get; set; }

        /// <summary>
        /// 店铺头图链接地址
        /// </summary>
        [JsonPropertyName("shop_logo_photo")]
        public string ShopLogoPhoto { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺标签
        /// </summary>
        [JsonPropertyName("shop_tags")]
        public List<string> ShopTags { get; set; }

        /// <summary>
        /// 店铺状态。NORMAL:正常运营; CLOSED: 店铺关闭
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 收单报备的店铺id
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }
    }
}
