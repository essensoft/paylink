using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniTemplatemessageUsertemplateApplyResponse.
    /// </summary>
    public class AlipayOpenMiniTemplatemessageUsertemplateApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 开发者申请的模板id号，使用该模板id号，开发者可以调用alipay.open.app.mini.templatemessage.send接口进行模板消息发送
        /// </summary>
        [JsonPropertyName("user_template_id")]
        public string UserTemplateId { get; set; }
    }
}
