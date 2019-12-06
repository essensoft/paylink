using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpScoreGetResponse.
    /// </summary>
    public class ZhimaCreditEpScoreGetResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 企业评分的打分时间，格式为yyyyMMdd
        /// </summary>
        [JsonPropertyName("eval_date")]
        public string EvalDate { get; set; }

        /// <summary>
        /// 该企业无企业信用评分的原因。枚举值： STATUS_UNNORMAL（企业状态异常）；NOT_JURIDICAL_ENTITY（非法人实体）；USER_CLOSED（用户已经关闭）；CAN_NOT_GET_INFO（无法查询到信息）
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 被查询企业的芝麻信用评分，分值在[1000,2000]之间。如果无分则返回N/A。
        /// </summary>
        [JsonPropertyName("zm_score")]
        public string ZmScore { get; set; }
    }
}
