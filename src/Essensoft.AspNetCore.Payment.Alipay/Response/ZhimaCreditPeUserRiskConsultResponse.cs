using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeUserRiskConsultResponse.
    /// </summary>
    public class ZhimaCreditPeUserRiskConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 用户在该场景下能否准入，返回true：准入，返回false：不准入。系统调用正确时有值。
        /// </summary>
        [JsonPropertyName("permit")]
        public bool Permit { get; set; }

        /// <summary>
        /// 不准入原因码，只有当permit为false时，值才具有价值。不同的不准入原因，取值会有不同的码，比如，ZM_SCORE_REFUSE，ZHIMA_NOT_OPEN，AGREEMENT_NOT_OPEN等等，商户一般只需要关注ZM_SCORE_REFUSE(芝麻分不足)、ZHIMA_NOT_OPEN(非芝麻会员)、AGREEMENT_NOT_OPEN(用户未授权)三个原因，其他原因无需详细关注，可采取统一处理措施。
        /// </summary>
        [JsonPropertyName("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 芝麻咨询单号，业务处理成功后，芝麻返回该字段，实际使用时请注意保存该字段。系统调用正确时有值。
        /// </summary>
        [JsonPropertyName("risk_order_no")]
        public string RiskOrderNo { get; set; }

        /// <summary>
        /// 场景分等级，如有需要，请在产品签约阶段联系产品或业务负责人申请
        /// </summary>
        [JsonPropertyName("scene_level")]
        public string SceneLevel { get; set; }

        /// <summary>
        /// 特殊输出字段，仅在特定业务场景下可能输出，输出值需要提前联系芝麻进行定制和确认后，在permit=true的情况下才会输出
        /// </summary>
        [JsonPropertyName("zm_score_level")]
        public string ZmScoreLevel { get; set; }
    }
}
