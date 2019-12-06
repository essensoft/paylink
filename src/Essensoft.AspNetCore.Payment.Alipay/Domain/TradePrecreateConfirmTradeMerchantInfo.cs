using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TradePrecreateConfirmTradeMerchantInfo Data Structure.
    /// </summary>
    public class TradePrecreateConfirmTradeMerchantInfo : AlipayObject
    {
        /// <summary>
        /// 商户所在的城市编码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 商户所在城市简体中文名
        /// </summary>
        [JsonPropertyName("city_name_sc")]
        public string CityNameSc { get; set; }

        /// <summary>
        /// 直连商户ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 直连商户MCC
        /// </summary>
        [JsonPropertyName("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 商户类型  企业取值：ENTERPRISE  个人取值：  PERSONAL  个体工商户取值：  PERSONAL_BUSINESS
        /// </summary>
        [JsonPropertyName("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 直连商户名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
