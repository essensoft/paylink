using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateSecondaryOperationDTO Data Structure.
    /// </summary>
    public class TemplateSecondaryOperationDTO : AlipayObject
    {
        /// <summary>
        /// 是否进行核销。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("need_write_off")]
        public bool NeedWriteOff { get; set; }

        /// <summary>
        /// 辅助核销区标题文案，支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 辅助核销区跳转链接，需要带上http、https、alipays等协议头。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
