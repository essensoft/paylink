using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppProdmodeTasknodeQueryResponse.
    /// </summary>
    public class AlipayEbppProdmodeTasknodeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前任务最新更新时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 是否可以编辑所有
        /// </summary>
        [JsonPropertyName("is_edit_all")]
        public string IsEditAll { get; set; }

        /// <summary>
        /// 编辑结算部分
        /// </summary>
        [JsonPropertyName("is_edit_fund")]
        public string IsEditFund { get; set; }

        /// <summary>
        /// 审批节点编码
        /// </summary>
        [JsonPropertyName("node_code")]
        public string NodeCode { get; set; }

        /// <summary>
        /// 任务状态描述
        /// </summary>
        [JsonPropertyName("node_name")]
        public string NodeName { get; set; }

        /// <summary>
        /// 拒绝理由
        /// </summary>
        [JsonPropertyName("reject")]
        public string Reject { get; set; }

        /// <summary>
        /// 拒绝时间
        /// </summary>
        [JsonPropertyName("reject_time")]
        public string RejectTime { get; set; }
    }
}
