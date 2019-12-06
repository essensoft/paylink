using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PointsExchangeInfo Data Structure.
    /// </summary>
    public class PointsExchangeInfo : AlipayObject
    {
        /// <summary>
        /// 兑换内容的ID
        /// </summary>
        [JsonPropertyName("ids")]
        public List<string> Ids { get; set; }

        /// <summary>
        /// 积分兑换内容的类型，比如券
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
