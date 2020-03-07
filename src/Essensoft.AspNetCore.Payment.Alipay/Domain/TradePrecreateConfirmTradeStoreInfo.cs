using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TradePrecreateConfirmTradeStoreInfo Data Structure.
    /// </summary>
    public class TradePrecreateConfirmTradeStoreInfo : AlipayObject
    {
        /// <summary>
        /// 店铺所在城市id
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 店铺所在城市简体中文名
        /// </summary>
        [JsonPropertyName("city_name_sc")]
        public string CityNameSc { get; set; }

        /// <summary>
        /// 店铺ID(外标)
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 店铺MCC
        /// </summary>
        [JsonPropertyName("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
