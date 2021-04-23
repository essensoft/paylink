using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// DeviceServiceBaseVO Data Structure.
    /// </summary>
    public class DeviceServiceBaseVO : AlipayObject
    {
        /// <summary>
        /// 设备别名
        /// </summary>
        [JsonPropertyName("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 节点类型 0为网关设备。1.为mesh子设备。2为除网关类的其他直连设备。3为外设
        /// </summary>
        [JsonPropertyName("node_type")]
        public long NodeType { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 设备在线状态 0为离线。1为在线
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// xpId
        /// </summary>
        [JsonPropertyName("xp_id")]
        public string XpId { get; set; }
    }
}
