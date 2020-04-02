using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoDocTemplateCreateResponse.
    /// </summary>
    public class AlipayEcoDocTemplateCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 模板id（请记录模板ID（templateId），后续发起合同签署需要使用到）
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 文件直传地址，需要用此上传地址使用PUT方式上传文件，只有文件上传后模板才可用
        /// </summary>
        [JsonPropertyName("upload_url")]
        public string UploadUrl { get; set; }
    }
}
