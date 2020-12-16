using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateStyleDTO Data Structure.
    /// </summary>
    public class TemplateStyleDTO : AlipayObject
    {
        /// <summary>
        /// 卡券整体背颜色，用RGB值以rgb(X,X,X)形式表示。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("background_color")]
        public string BackgroundColor { get; set; }
    }
}
