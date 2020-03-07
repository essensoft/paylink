using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AttachmentExplain Data Structure.
    /// </summary>
    public class AttachmentExplain : AlipayObject
    {
        /// <summary>
        /// 允许上传更多附件。开启后，除了“附件列表”中指定的内容，签署人可自由上传之多10张图片。默认值为false
        /// </summary>
        [JsonPropertyName("allow_more_uploads")]
        public bool AllowMoreUploads { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 附件列表
        /// </summary>
        [JsonPropertyName("details")]
        public List<Detail> Details { get; set; }

        /// <summary>
        /// 附件标题（collect_attachement值为true时必填
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
