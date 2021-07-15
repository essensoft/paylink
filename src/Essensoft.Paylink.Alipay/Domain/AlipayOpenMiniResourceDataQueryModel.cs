using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniResourceDataQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniResourceDataQueryModel : AlipayObject
    {
        /// <summary>
        /// 插件appId
        /// </summary>
        [JsonPropertyName("plugin_id")]
        public string PluginId { get; set; }

        /// <summary>
        /// 数据日期，格式为yyyyMMdd
        /// </summary>
        [JsonPropertyName("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 创建流量位时返回的流量位id
        /// </summary>
        [JsonPropertyName("resource_id")]
        public string ResourceId { get; set; }
    }
}
