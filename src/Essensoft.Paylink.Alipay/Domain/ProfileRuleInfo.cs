using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ProfileRuleInfo Data Structure.
    /// </summary>
    public class ProfileRuleInfo : AlipayObject
    {
        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 规则唯一id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonPropertyName("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 厂商id
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }
    }
}
