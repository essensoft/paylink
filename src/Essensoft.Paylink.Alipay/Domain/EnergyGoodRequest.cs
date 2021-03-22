using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// EnergyGoodRequest Data Structure.
    /// </summary>
    public class EnergyGoodRequest : AlipayObject
    {
        /// <summary>
        /// 发放的能量
        /// </summary>
        [JsonPropertyName("full_energy")]
        public long FullEnergy { get; set; }

        /// <summary>
        /// item的类型
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("items")]
        public List<EnergyExtRequest> Items { get; set; }

        /// <summary>
        /// item的数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }
    }
}
