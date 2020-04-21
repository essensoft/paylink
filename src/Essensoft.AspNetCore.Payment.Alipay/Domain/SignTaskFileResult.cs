using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SignTaskFileResult Data Structure.
    /// </summary>
    public class SignTaskFileResult : AlipayObject
    {
        /// <summary>
        /// 业务初始化时传入的流水号
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 扩展参数信息，可根据不同接入方需求定制内容
        /// </summary>
        [JsonPropertyName("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 已签名文档列表
        /// </summary>
        [JsonPropertyName("signed_file_list")]
        public List<SignedFileInfo> SignedFileList { get; set; }

        /// <summary>
        /// 签约结果  1）FAIL | 解释：签约失败  2）SUCCESS | 解释：完成  3）PROCESS | 解释：签约中  4）EXPIRED | 解释：任务过期
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 签约任务编号
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
