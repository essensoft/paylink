using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TradePrecreateConfirmTradeStoreInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TradePrecreateConfirmTradeStoreInfo : AlipayObject
    {
        /// <summary>
        /// 店铺所在城市id
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 店铺所在城市简体中文名
        /// </summary>
        [JsonProperty("city_name_sc")]
        public string CityNameSc { get; set; }

        /// <summary>
        /// 店铺ID(外标)
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 店铺MCC
        /// </summary>
        [JsonProperty("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
