using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppIndustryApplyflowQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryApplyflowQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务能力码，标识业务场景
        /// </summary>
        [JsonPropertyName("ability_code")]
        public string AbilityCode { get; set; }

        /// <summary>
        /// 支付宝办理流水号，支持幂等
        /// </summary>
        [JsonPropertyName("apply_flow_no")]
        public string ApplyFlowNo { get; set; }

        /// <summary>
        /// 业务账户号，例如水费单号，手机号，电费号。没有唯一性要求。
        /// </summary>
        [JsonPropertyName("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 业务机构简称
        /// </summary>
        [JsonPropertyName("biz_inst")]
        public string BizInst { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 流水创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 办理流水最近修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 机构结果码
        /// </summary>
        [JsonPropertyName("org_result_code")]
        public string OrgResultCode { get; set; }

        /// <summary>
        /// 外部申请流水号
        /// </summary>
        [JsonPropertyName("out_apply_no")]
        public string OutApplyNo { get; set; }

        /// <summary>
        /// 业务结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果上下文，json格式
        /// </summary>
        [JsonPropertyName("result_context")]
        public string ResultContext { get; set; }

        /// <summary>
        /// 结果码描述文案
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 办理状态，SUCCESS：成功；FAILURE：失败；PROCESS：处理中
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
