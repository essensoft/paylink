using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VehicleConditionInfo Data Structure.
    /// </summary>
    public class VehicleConditionInfo : AlipayObject
    {
        /// <summary>
        /// 车况类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 车况信息单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 车况属性值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
