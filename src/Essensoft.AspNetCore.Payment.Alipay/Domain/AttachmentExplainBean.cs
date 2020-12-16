using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AttachmentExplainBean Data Structure.
    /// </summary>
    public class AttachmentExplainBean : AlipayObject
    {
        /// <summary>
        /// 页面展示的任务描（collect_attachement值为true时必填）
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 附件列表，用于定义每个附件code的描述及页面展示顺序
        /// </summary>
        [JsonPropertyName("details")]
        public List<DetailBean> Details { get; set; }

        /// <summary>
        /// 页面展示的任务标题（collect_attachement值为true时必填）
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
