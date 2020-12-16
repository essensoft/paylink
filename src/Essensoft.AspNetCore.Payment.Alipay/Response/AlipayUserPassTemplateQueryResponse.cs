using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserPassTemplateQueryResponse.
    /// </summary>
    public class AlipayUserPassTemplateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 基础属性
        /// </summary>
        [JsonPropertyName("evoucher_info")]
        public TemplateEvoucherDTO EvoucherInfo { get; set; }

        /// <summary>
        /// 文件属性
        /// </summary>
        [JsonPropertyName("file_info")]
        public TemplateFileDTO FileInfo { get; set; }

        /// <summary>
        /// 图片属性
        /// </summary>
        [JsonPropertyName("image")]
        public TemplateImageDTO Image { get; set; }

        /// <summary>
        /// 商户属性
        /// </summary>
        [JsonPropertyName("merchant")]
        public TemplateMerchantDTO Merchant { get; set; }

        /// <summary>
        /// 渠道属性
        /// </summary>
        [JsonPropertyName("platform")]
        public TemplatePlatformDTO Platform { get; set; }

        /// <summary>
        /// 样式属性
        /// </summary>
        [JsonPropertyName("style")]
        public TemplateStyleDTO Style { get; set; }
    }
}
