using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MedicalSvTpCardActionInfo Data Structure.
    /// </summary>
    public class MedicalSvTpCardActionInfo : AlipayObject
    {
        /// <summary>
        /// 模板消息中行动编码，动态参数信息  备注：行动点编码根据模板类型定义
        /// </summary>
        [JsonPropertyName("action_code")]
        public string ActionCode { get; set; }

        /// <summary>
        /// 模板消息中行动名称,开发者自定义
        /// </summary>
        [JsonPropertyName("action_name")]
        public string ActionName { get; set; }

        /// <summary>
        /// 模板消息中实际操作链接，开发者自定义
        /// </summary>
        [JsonPropertyName("action_url")]
        public string ActionUrl { get; set; }
    }
}
