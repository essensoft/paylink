using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoSignFlowQueryResponse.
    /// </summary>
    public class AlipayEcoSignFlowQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 文件主题
        /// </summary>
        [JsonPropertyName("business_scene")]
        public string BusinessScene { get; set; }

        /// <summary>
        /// 文件有效截止日期
        /// </summary>
        [JsonPropertyName("contract_validity")]
        public long ContractValidity { get; set; }

        /// <summary>
        /// 流程描述, 如果流程已拒签或已撤回, 并且存在拒签或撤回原因, 流程描述显示为原因, 否则默认为流程状态描述
        /// </summary>
        [JsonPropertyName("flow_desc")]
        public string FlowDesc { get; set; }

        /// <summary>
        /// 流程结束时间
        /// </summary>
        [JsonPropertyName("flow_end_time")]
        public long FlowEndTime { get; set; }

        /// <summary>
        /// 流程Id
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 流程开始时间
        /// </summary>
        [JsonPropertyName("flow_start_time")]
        public long FlowStartTime { get; set; }

        /// <summary>
        /// 流程状态,0-草稿 1-签署中 2-完成 3-撤销 4-终止 5-过期 6-删除 7-拒签
        /// </summary>
        [JsonPropertyName("flow_status")]
        public long FlowStatus { get; set; }

        /// <summary>
        /// 通知开发者地址
        /// </summary>
        [JsonPropertyName("notice_developer_url")]
        public string NoticeDeveloperUrl { get; set; }

        /// <summary>
        /// 签署有效截止日期
        /// </summary>
        [JsonPropertyName("sign_validity")]
        public long SignValidity { get; set; }

        /// <summary>
        /// 签署人列表及签署状态
        /// </summary>
        [JsonPropertyName("signers")]
        public List<FlowSigner> Signers { get; set; }
    }
}
