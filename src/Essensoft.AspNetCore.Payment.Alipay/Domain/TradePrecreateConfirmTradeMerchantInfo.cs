using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TradePrecreateConfirmTradeMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TradePrecreateConfirmTradeMerchantInfo : AlipayObject
    {
        /// <summary>
        /// 商户所在的城市编码
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 商户所在城市简体中文名
        /// </summary>
        [JsonProperty("city_name_sc")]
        public string CityNameSc { get; set; }

        /// <summary>
        /// 直连商户ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 直连商户MCC
        /// </summary>
        [JsonProperty("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 商户类型  企业取值：ENTERPRISE  个人取值：  PERSONAL  个体工商户取值：  PERSONAL_BUSINESS
        /// </summary>
        [JsonProperty("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 直连商户名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
