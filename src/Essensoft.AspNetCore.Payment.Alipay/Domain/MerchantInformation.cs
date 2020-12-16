using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantInformation Data Structure.
    /// </summary>
    public class MerchantInformation : AlipayObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 预收金额
        /// </summary>
        [JsonPropertyName("advance_amount")]
        public string AdvanceAmount { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonPropertyName("city_desc")]
        public string CityDesc { get; set; }

        /// <summary>
        /// 计收模式和结算方式
        /// </summary>
        [JsonPropertyName("collection_settlement")]
        public string CollectionSettlement { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [JsonPropertyName("country_desc")]
        public string CountryDesc { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [JsonPropertyName("district_desc")]
        public string DistrictDesc { get; set; }

        /// <summary>
        /// mcc码
        /// </summary>
        [JsonPropertyName("mcc_code")]
        public string MccCode { get; set; }

        /// <summary>
        /// mcc一级类目
        /// </summary>
        [JsonPropertyName("mcc_industry_one")]
        public string MccIndustryOne { get; set; }

        /// <summary>
        /// mcc二级类目
        /// </summary>
        [JsonPropertyName("mcc_industry_two")]
        public string MccIndustryTwo { get; set; }

        /// <summary>
        /// 上面名称
        /// </summary>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// mid
        /// </summary>
        [JsonPropertyName("mid")]
        public string Mid { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [JsonPropertyName("zip_code")]
        public string ZipCode { get; set; }
    }
}
