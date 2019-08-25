using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesLeadsShopleadsCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiSalesLeadsShopleadsCreateModel : AlipayObject
    {
        /// <summary>
        /// 街道详细地址
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 分店名
        /// </summary>
        [JsonProperty("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 品牌id，请联系业务获取
        /// </summary>
        [JsonProperty("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 叶子类目id，请联系业务获取
        /// </summary>
        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 市级码
        /// </summary>
        [JsonProperty("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 营业执照上的公司、法人名称
        /// </summary>
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [JsonProperty("contacts_name")]
        public string ContactsName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonProperty("contacts_no")]
        public string ContactsNo { get; set; }

        /// <summary>
        /// 国家码
        /// </summary>
        [JsonProperty("country_id")]
        public string CountryId { get; set; }

        /// <summary>
        /// 区级码
        /// </summary>
        [JsonProperty("district_id")]
        public string DistrictId { get; set; }

        /// <summary>
        /// 扩展信息，JsonMap格式
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 主店名
        /// </summary>
        [JsonProperty("head_shop_name")]
        public string HeadShopName { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 省、直辖市码
        /// </summary>
        [JsonProperty("province_id")]
        public string ProvinceId { get; set; }

        /// <summary>
        /// 工商注册时间
        /// </summary>
        [JsonProperty("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 调用方请求id，业务请求相同时应保持一致，用于幂等
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
