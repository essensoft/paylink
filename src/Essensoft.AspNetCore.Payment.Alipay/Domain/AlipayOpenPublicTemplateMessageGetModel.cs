using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicTemplateMessageGetModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicTemplateMessageGetModel : AlipayObject
    {
        /// <summary>
        /// 消息母板id，登陆生活号后台(fuwu.alipay.com)，点击菜单“模板消息”，点击“模板库”，即可看到相应模板的消息母板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
