using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserAgreementExecutionplanModifyResponse.
    /// </summary>
    public class AlipayUserAgreementExecutionplanModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 周期性扣款产品，授权免密支付协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 商户下一次扣款时间，格式 "yyyy-MM-dd"。 例如：用户在1月1日开通了连续包月，使用了10天又另行购买了“季度包”，如果此时商户希望“季度包”立即优先生效，在季度包结束后能继续使用连续包月，那么原定的周期就被延后了。此时可以通过本接口将预计扣款时间推后“季度包”的时长。
        /// </summary>
        [JsonPropertyName("deduct_time")]
        public string DeductTime { get; set; }
    }
}
