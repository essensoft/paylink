using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesLeadsShopleadsCreateModel Data Structure.
    /// </summary>
    public class KoubeiSalesLeadsShopleadsCreateModel : AlipayObject
    {
        /// <summary>
        /// 街道详细地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 分店名
        /// </summary>
        [JsonPropertyName("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 品牌id，请联系业务获取
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 叶子类目id，请联系业务获取
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 市级码
        /// </summary>
        [JsonPropertyName("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 营业执照上的公司、法人名称
        /// </summary>
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [JsonPropertyName("contacts_name")]
        public string ContactsName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonPropertyName("contacts_no")]
        public string ContactsNo { get; set; }

        /// <summary>
        /// 国家码
        /// </summary>
        [JsonPropertyName("country_id")]
        public string CountryId { get; set; }

        /// <summary>
        /// 区级码
        /// </summary>
        [JsonPropertyName("district_id")]
        public string DistrictId { get; set; }

        /// <summary>
        /// 扩展信息，JsonMap格式
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 主店名
        /// </summary>
        [JsonPropertyName("head_shop_name")]
        public string HeadShopName { get; set; }

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
        /// 备注信息
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 省、直辖市码
        /// </summary>
        [JsonPropertyName("province_id")]
        public string ProvinceId { get; set; }

        /// <summary>
        /// 工商注册时间
        /// </summary>
        [JsonPropertyName("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 调用方请求id，业务请求相同时应保持一致，用于幂等
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
