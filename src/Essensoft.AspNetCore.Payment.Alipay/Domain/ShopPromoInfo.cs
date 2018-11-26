using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopPromoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopPromoInfo : AlipayObject
    {
        /// <summary>
        /// 店铺跳转链接
        /// </summary>
        [JsonProperty("action_param")]
        [XmlElement("action_param")]
        public string ActionParam { get; set; }

        /// <summary>
        /// 店铺地址
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonProperty("brand_name")]
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 城市id
        /// </summary>
        [JsonProperty("city_id")]
        [XmlElement("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 菜系
        /// </summary>
        [JsonProperty("cuisine")]
        [XmlElement("cuisine")]
        public string Cuisine { get; set; }

        /// <summary>
        /// 预留扩展信息
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 是否有优惠
        /// </summary>
        [JsonProperty("has_hui")]
        [XmlElement("has_hui")]
        public string HasHui { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonProperty("head_shop_name")]
        [XmlElement("head_shop_name")]
        public string HeadShopName { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonProperty("latitude")]
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonProperty("longitude")]
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 人气分
        /// </summary>
        [JsonProperty("popularity")]
        [XmlElement("popularity")]
        public string Popularity { get; set; }

        /// <summary>
        /// 人气等级
        /// </summary>
        [JsonProperty("popularity_level")]
        [XmlElement("popularity_level")]
        public string PopularityLevel { get; set; }

        /// <summary>
        /// 人均消费
        /// </summary>
        [JsonProperty("price_average")]
        [XmlElement("price_average")]
        public string PriceAverage { get; set; }

        /// <summary>
        /// 前台一级类目列表
        /// </summary>
        [JsonProperty("root_display_category_info")]
        [XmlElement("root_display_category_info")]
        public string RootDisplayCategoryInfo { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonProperty("shop_id")]
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺logo图
        /// </summary>
        [JsonProperty("shop_logo_url")]
        [XmlElement("shop_logo_url")]
        public string ShopLogoUrl { get; set; }

        /// <summary>
        /// 店铺详细名称
        /// </summary>
        [JsonProperty("shop_name")]
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 推荐语
        /// </summary>
        [JsonProperty("shop_recommend_one_tag_compose")]
        [XmlElement("shop_recommend_one_tag_compose")]
        public string ShopRecommendOneTagCompose { get; set; }

        /// <summary>
        /// 店铺券信息
        /// </summary>
        [JsonProperty("voucher_info_list")]
        [XmlArray("voucher_info_list")]
        [XmlArrayItem("promo_voucher_info")]
        public List<PromoVoucherInfo> VoucherInfoList { get; set; }
    }
}
