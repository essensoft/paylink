using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoDocTemplateCreateModel Data Structure.
    /// </summary>
    public class AlipayEcoDocTemplateCreateModel : AlipayObject
    {
        /// <summary>
        /// 模版文件的md5值
        /// </summary>
        [JsonPropertyName("content_md_5")]
        public string ContentMd5 { get; set; }

        /// <summary>
        /// 目标文件的MIME类型
        /// </summary>
        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 是否需要转成pdf，如果模板文件为.doc/.docx 传true，为pdf传false
        /// </summary>
        [JsonPropertyName("convert_to_pdf")]
        public string ConvertToPdf { get; set; }

        /// <summary>
        /// 文件名称（必须带上文件扩展名如:.pdf,.doc,.docx，不然会导致后续发起流程校验异常）
        /// </summary>
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }
    }
}
