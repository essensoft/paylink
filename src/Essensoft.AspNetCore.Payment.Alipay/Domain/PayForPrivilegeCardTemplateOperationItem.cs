using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PayForPrivilegeCardTemplateOperationItem Data Structure.
    /// </summary>
    public class PayForPrivilegeCardTemplateOperationItem : AlipayObject
    {
        /// <summary>
        /// 卡模板操作项的文本
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// 卡模板操作项的跳转链接
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
