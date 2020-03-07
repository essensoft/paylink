using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoLogisticsExpressPriceQueryResponse.
    /// </summary>
    public class AlipayEcoLogisticsExpressPriceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 续重价格（单位：元）
        /// </summary>
        [JsonPropertyName("extra_weight_price")]
        public string ExtraWeightPrice { get; set; }

        /// <summary>
        /// 续重单位（单位：克）
        /// </summary>
        [JsonPropertyName("extra_weight_unit")]
        public long ExtraWeightUnit { get; set; }

        /// <summary>
        /// 首重重量（单位：克）
        /// </summary>
        [JsonPropertyName("preset_weight")]
        public long PresetWeight { get; set; }

        /// <summary>
        /// 首重价格（单位：元）
        /// </summary>
        [JsonPropertyName("preset_weight_price")]
        public string PresetWeightPrice { get; set; }
    }
}
