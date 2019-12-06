using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrVehicledashboardQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCognitiveOcrVehicledashboardQueryModel : AlipayObject
    {
        /// <summary>
        /// 自定义场景字段，通过biz_name明确是那个场景，仪表板写死为 dashboard
        /// </summary>
        [JsonPropertyName("biz_name")]
        public string BizName { get; set; }

        /// <summary>
        /// 仪表盘图片base64编码后内容，大小限制在1.5M
        /// </summary>
        [JsonPropertyName("image_content")]
        public string ImageContent { get; set; }
    }
}
