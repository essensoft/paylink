using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPassTemplateAddModel Data Structure.
    /// </summary>
    public class AlipayPassTemplateAddModel : AlipayObject
    {
        /// <summary>
        /// 模板内容信息，遵循JSON规范，详情参见tpl_content参数说明：https://opendocs.alipay.com/open/016d5g
        /// </summary>
        [JsonPropertyName("tpl_content")]
        public string TplContent { get; set; }

        /// <summary>
        /// 商户用于控制模版的唯一性。（可以使用时间戳保证唯一性）
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }
    }
}
