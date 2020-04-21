using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PoiQueryResult Data Structure.
    /// </summary>
    public class PoiQueryResult : AlipayObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 英文地址
        /// </summary>
        [JsonPropertyName("address_en")]
        public string AddressEn { get; set; }

        /// <summary>
        /// 当地地址
        /// </summary>
        [JsonPropertyName("address_local")]
        public string AddressLocal { get; set; }

        /// <summary>
        /// 备用号码
        /// </summary>
        [JsonPropertyName("alternative_phone")]
        public string AlternativePhone { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        [JsonPropertyName("bios")]
        public string Bios { get; set; }

        /// <summary>
        /// 品牌信息
        /// </summary>
        [JsonPropertyName("brand_info")]
        public StructureBrandInfo BrandInfo { get; set; }

        /// <summary>
        /// 服务时间
        /// </summary>
        [JsonPropertyName("business_hour")]
        public string BusinessHour { get; set; }

        /// <summary>
        /// 类目
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 商圈
        /// </summary>
        [JsonPropertyName("commercial_circle")]
        public string CommercialCircle { get; set; }

        /// <summary>
        /// 人均消费
        /// </summary>
        [JsonPropertyName("consumption")]
        public string Consumption { get; set; }

        /// <summary>
        /// 国家码
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [JsonPropertyName("country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("extend_map")]
        public string ExtendMap { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("lng")]
        public string Lng { get; set; }

        /// <summary>
        /// 当地语言
        /// </summary>
        [JsonPropertyName("local_language")]
        public string LocalLanguage { get; set; }

        /// <summary>
        /// 本地名
        /// </summary>
        [JsonPropertyName("local_name")]
        public string LocalName { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [JsonPropertyName("main_phone")]
        public string MainPhone { get; set; }

        /// <summary>
        /// 地名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        [JsonPropertyName("name_alias")]
        public string NameAlias { get; set; }

        /// <summary>
        /// 英文名
        /// </summary>
        [JsonPropertyName("name_en")]
        public string NameEn { get; set; }

        /// <summary>
        /// 下线详细原因
        /// </summary>
        [JsonPropertyName("offline_reason_detail")]
        public string OfflineReasonDetail { get; set; }

        /// <summary>
        /// poi状态
        /// </summary>
        [JsonPropertyName("open_status")]
        public long OpenStatus { get; set; }

        /// <summary>
        /// 开放时间
        /// </summary>
        [JsonPropertyName("open_time")]
        public string OpenTime { get; set; }

        /// <summary>
        /// 操作类型(0:新增 1:更新)
        /// </summary>
        [JsonPropertyName("operator_type")]
        public long OperatorType { get; set; }

        /// <summary>
        /// 图片地址(,分隔多张)
        /// </summary>
        [JsonPropertyName("photo_urls")]
        public List<string> PhotoUrls { get; set; }

        /// <summary>
        /// poiId(飞猪端poiId)
        /// </summary>
        [JsonPropertyName("poi_id")]
        public long PoiId { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 推荐信息
        /// </summary>
        [JsonPropertyName("recommend_infos")]
        public string RecommendInfos { get; set; }

        /// <summary>
        /// 认领主账号id
        /// </summary>
        [JsonPropertyName("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 服务详情
        /// </summary>
        [JsonPropertyName("service_info")]
        public StructureServiceInfo ServiceInfo { get; set; }

        /// <summary>
        /// 支付宝店铺id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺类型
        /// </summary>
        [JsonPropertyName("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 外部源唯一id
        /// </summary>
        [JsonPropertyName("source_biz_id")]
        public string SourceBizId { get; set; }

        /// <summary>
        /// 中台门店id
        /// </summary>
        [JsonPropertyName("store_id")]
        public long StoreId { get; set; }

        /// <summary>
        /// 子账号id
        /// </summary>
        [JsonPropertyName("sub_seller_id")]
        public long SubSellerId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonPropertyName("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// 交通
        /// </summary>
        [JsonPropertyName("transport")]
        public string Transport { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }

        /// <summary>
        /// 视频url
        /// </summary>
        [JsonPropertyName("video_url")]
        public string VideoUrl { get; set; }

        /// <summary>
        /// 外部url
        /// </summary>
        [JsonPropertyName("web_site_url")]
        public string WebSiteUrl { get; set; }
    }
}
