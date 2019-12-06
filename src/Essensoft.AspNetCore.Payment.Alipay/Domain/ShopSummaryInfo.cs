using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopSummaryInfo Data Structure.
    /// </summary>
    public class ShopSummaryInfo : AlipayObject
    {
        /// <summary>
        /// 门店地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 分店名
        /// </summary>
        [JsonPropertyName("branch_shop_name")]
        public string BranchShopName { get; set; }

        /// <summary>
        /// 品牌名，不填写则默认为其它品牌
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 经营时间
        /// </summary>
        [JsonPropertyName("business_time")]
        public string BusinessTime { get; set; }

        /// <summary>
        /// 门店类目列表
        /// </summary>
        [JsonPropertyName("category_infos")]
        public List<ShopCategoryInfo> CategoryInfos { get; set; }

        /// <summary>
        /// 城市编码，国标码，详见国家统计局数据 <a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/AreaCodeList.zip">点此下载</a>
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// "0", "不展示"  "1", "展示"  "2", "后台强制不展示"  "3", "灰度展示状态"
        /// </summary>
        [JsonPropertyName("display_status")]
        public string DisplayStatus { get; set; }

        /// <summary>
        /// 区县编码，国标码，详见国家统计局数据 <a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/AreaCodeList.zip">点此下载</a>
        /// </summary>
        [JsonPropertyName("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 区县名称
        /// </summary>
        [JsonPropertyName("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 门店座机电话
        /// </summary>
        [JsonPropertyName("landline_no")]
        public string LandlineNo { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 门店logo图片
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// logo图片地址
        /// </summary>
        [JsonPropertyName("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 门店首图
        /// </summary>
        [JsonPropertyName("main_image")]
        public string MainImage { get; set; }

        /// <summary>
        /// 门店首图url地址
        /// </summary>
        [JsonPropertyName("main_image_url")]
        public string MainImageUrl { get; set; }

        /// <summary>
        /// 主门店名
        /// </summary>
        [JsonPropertyName("main_shop_name")]
        public string MainShopName { get; set; }

        /// <summary>
        /// 门店电话
        /// </summary>
        [JsonPropertyName("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 人均消费
        /// </summary>
        [JsonPropertyName("per_pay")]
        public string PerPay { get; set; }

        /// <summary>
        /// 门店所属商户pid
        /// </summary>
        [JsonPropertyName("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 省份编码，国标码，详见国家统计局数据 <a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/AreaCodeList.zip">点此下载</a>
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 身份名称
        /// </summary>
        [JsonPropertyName("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店状态，OPEN：营业中、PAUSE：暂停营业、FREEZE：已冻结、CLOSE:门店已关闭
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
