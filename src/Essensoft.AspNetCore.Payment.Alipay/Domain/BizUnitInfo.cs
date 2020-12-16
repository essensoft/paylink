using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BizUnitInfo Data Structure.
    /// </summary>
    public class BizUnitInfo : AlipayObject
    {
        /// <summary>
        /// 经营单元id，如店铺id
        /// </summary>
        [JsonPropertyName("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 经营单元名称，如店铺名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 经营单元类型，如口碑门店/集团统一门店等
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
