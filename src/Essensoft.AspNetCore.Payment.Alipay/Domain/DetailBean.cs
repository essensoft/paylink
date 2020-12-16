using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DetailBean Data Structure.
    /// </summary>
    public class DetailBean : AlipayObject
    {
        /// <summary>
        /// 自定义附件标识，后续下载附件使用此标识区分。
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 页面展示的附件中文描述（collectAttachement值为true时必填）
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 展示顺序（collectAttachement值为true时必填）
        /// </summary>
        [JsonPropertyName("order")]
        public long Order { get; set; }
    }
}
