using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SecurityScene Data Structure.
    /// </summary>
    public class SecurityScene : AlipayObject
    {
        /// <summary>
        /// 接入渠道
        /// </summary>
        [JsonPropertyName("access_channel")]
        public string AccessChannel { get; set; }

        /// <summary>
        /// 事件信息
        /// </summary>
        [JsonPropertyName("ctu_params")]
        public string CtuParams { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 产品节点
        /// </summary>
        [JsonPropertyName("product_node")]
        public string ProductNode { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonPropertyName("security_scene_params")]
        public string SecuritySceneParams { get; set; }

        /// <summary>
        /// 系统名称
        /// </summary>
        [JsonPropertyName("system_name")]
        public string SystemName { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [JsonPropertyName("total_fee")]
        public string TotalFee { get; set; }
    }
}
