using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContractApprovalInfoVO Data Structure.
    /// </summary>
    public class ContractApprovalInfoVO : AlipayObject
    {
        /// <summary>
        /// 审批附件url列表
        /// </summary>
        [JsonPropertyName("file_urls")]
        public List<string> FileUrls { get; set; }

        /// <summary>
        /// 审批环节
        /// </summary>
        [JsonPropertyName("node")]
        public string Node { get; set; }

        /// <summary>
        /// 审批时间（格式如：2019-08-08 10:00:00）
        /// </summary>
        [JsonPropertyName("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 审批人（姓名&花名）
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 审批意见
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 审批结果（待审核、通过、驳回）
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
