using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoTemplateCreateResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoTemplateCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 模板id，创建成功有值
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
